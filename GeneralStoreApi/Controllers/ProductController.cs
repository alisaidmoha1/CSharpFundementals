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
    public class ProductController : ApiController
    {
        private readonly GeneralStoreDbContext _context = new GeneralStoreDbContext();

        //Get
        [HttpGet]
        public async Task<IHttpActionResult> GetAllProducts()
        {
            // if we have soft delete, we would want to exclude archived/deleted products .Where(p => !p.Deleted_
            List<Product> products = await _context.Products.ToListAsync();
            return Ok(products);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetProductById(int id)
        {
            Product product = await _context.Products.FindAsync(id);

            if(product == null) // if (product == null || product.Deleted_ if we are using
            {
                return NotFound();
            }

            return Ok(product);
        }
        //Post
        [HttpPost]
        public async Task<IHttpActionResult> PostProduct( Product product)
        {
            if (ModelState.IsValid)
            {
                // This adds the product to the C# representation of the database not the actual database
                _context.Products.Add(product);
                //this  translates our change to sql and then excutes them
                await _context.SaveChangesAsync();
                return Ok("congrats you created a product");
            }

            return BadRequest(ModelState);
        }

        //Put
        [HttpPut]
        [Route("api/Product/{id}/Update")]
        public async Task<IHttpActionResult> UpdateProduct([FromUri] int id, [FromBody] ProductUpdate newProduct)
        {

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            var OldProduct = await _context.Products.FindAsync(id);

            if(OldProduct == null)
            {
                return NotFound();
            }

            OldProduct.Name = newProduct.Name;
            OldProduct.Price = newProduct.Price;
            //OldProduct.Quantity = newProduct.Quantity; 
            OldProduct.UPC = newProduct.UPC;

            await _context.SaveChangesAsync();
            return Ok();
        }

        //Put but restock product
        [HttpPut]
        [Route("api/Product/{id}/Restock")]

        // Define the pattern in App_Start/RouteConfig.cs
        //        Route     action
        //../api/Product/1/Restock
        //../api/Product/1/SomethingElse

        public async Task<IHttpActionResult> RestockProduct([FromUri] int id, [FromBody] Restock restock)
        {
            Product product = await _context.Products.FindAsync(id);

            if (product == null)
                return NotFound();

            product.Quantity += restock.Amount;

            await _context.SaveChangesAsync();
            return Ok();
        }

        //Delete
        [HttpDelete]

        public async Task<IHttpActionResult> DeleteProduct([FromUri] int id)
        {
            Product product = await _context.Products.FindAsync(id);

            if (product == null)
                return BadRequest();

            //Actually delete the product
            _context.Products.Remove(product);
            //Archive the product without taking it out of the DB
            //product.Deleted = true;
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
