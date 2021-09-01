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
            List<Product> products = await _context.Products.ToListAsync();
            return Ok(products);
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
        //Delete
    }
}
