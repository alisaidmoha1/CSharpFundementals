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
    public class CustomerController : ApiController
    {
        private readonly GeneralStoreDbContext _context = new GeneralStoreDbContext();

        //Get
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            Customer[] customers = await _context.Customers.ToArrayAsync();

            if (customers == null)
            {
                return NotFound();
            }

            return Ok(customers);

        }

        // Get by ID
        [HttpGet]
        public async Task<IHttpActionResult> GetCustomerByID (int id)
        {
            Customer customer = await _context.Customers.FindAsync(id);

            if(customer != null)
            {
                return Ok(customer);
            }

            return NotFound();
        }

        //Post
        [HttpPost] 
        public async Task<IHttpActionResult> PostCustomer(CustomerCreate customer)
        {
            if (ModelState.IsValid)
            {
                Customer newCustomer = new Customer();
                newCustomer.Name = customer.Name;
                newCustomer.Email = customer.Email;
                newCustomer.DateJoined = DateTime.Now;

                _context.Customers.Add(newCustomer);
                await _context.SaveChangesAsync();
                return Ok();
            }

            return BadRequest(ModelState);
        }

        // Put 
        [HttpPut]
        public async Task<IHttpActionResult> UpdateCustomer ([FromUri] int id, [FromBody] CustomerCreate newCustomer)
        { 
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Customer OldCustomer = await _context.Customers.FindAsync(id);

            if (OldCustomer == null)
                return NotFound();

            OldCustomer.Name = newCustomer.Name;
            OldCustomer.Email = newCustomer.Email;
           // OldCustomer.DateJoined = newCustomer.DateJoined;

            await _context.SaveChangesAsync();
            return Ok();
        }

        //Delete
        [HttpDelete]

        public async Task<IHttpActionResult> DeleteCustomer([FromUri] int id)
        {
            Customer customer = await _context.Customers.FindAsync(id);

            if (customer == null)
                return NotFound();

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
