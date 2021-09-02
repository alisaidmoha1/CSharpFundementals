using GeneralStoreApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace GeneralStoreApi.Controllers
{
    public class TransanctionController : ApiController
    {
        private readonly GeneralStoreDbContext _context = new GeneralStoreDbContext();

        [HttpPost]
        public async Task<IHttpActionResult> PostTransaction(TransactionCreate transaction)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (transaction.Quantity <= 0) // you can but zero boxes
                return BadRequest("You have to buy at least one");

            Product product = await _context.Products.FindAsync(transaction.ProductId);

            if (product == null)
                return BadRequest("Ivalid Product ID");

            if (product.Quantity == 0)
            {
                return BadRequest("This item is currently out of stock");
            }

            if(product.Quantity < transaction.Quantity)
            {
                return BadRequest("Not enough items in stock");
            }

            //if the product is bought we need to take away from the quantity of product

            //how many are in stock  minus how many are been bought
            product.Quantity -= transaction.Quantity;

            Transaction newTransaction = new Transaction();

            newTransaction.CustomerId = transaction.CustomerId;
            newTransaction.ProductId = transaction.ProductId;
            newTransaction.Quantity = transaction.Quantity;
            newTransaction.DateOfTransaction = DateTime.Now;

            _context.Transactions.Add(newTransaction);
            await _context.SaveChangesAsync();
            return Ok();
            
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAllTransactions()
        {
            List<TransactionListItem> transactions = await _context.Transactions
                .Select(t => new TransactionListItem()
                {
                    CustomerName = t.Customer.Name,
                    ProductName = t.Product.Name,
                    PurchaseDate = t.DateOfTransaction,
                    NumberOfPurchased = t.Quantity,
                    TotalCost = t.Quantity * t.Product.Price
                }).ToListAsync();
            return Ok(transactions);
        }
    }
}
