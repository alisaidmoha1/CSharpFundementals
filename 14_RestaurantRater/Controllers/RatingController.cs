using _14_RestaurantRater.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace _14_RestaurantRater.Controllers
{
    public class RatingController : ApiController
    {
        private readonly RestaurantDbContext _context = new RestaurantDbContext();

        //C
        //Post
        [HttpPost]
        public async Task<IHttpActionResult> CreateRating(Rating rating)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // to check the restaurant they want to add exist

            var restuarant = await _context.Restaurants.FindAsync(rating.RestaurantId);
            if (restuarant == null)
            {
                return BadRequest($"The restuarant with an Id of {rating.RestaurantId} does not exist");
            }

            _context.Ratings.Add(rating);
            if (await _context.SaveChangesAsync() == 1)
            {
                return Ok($"You successfully rated {restuarant.Name}!");
            }

            return InternalServerError();
        }
        //R
        //GET
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            List<RatingDisplay> ratings = await
                _context
                .Ratings
                .Select(r => new RatingDisplay
                {
                    Id = r.Id,
                    FoodScore = r.FoodScore,
                    AtmosphereScore = r.AtmosphereScore,
                    CleanlinessScore = r.CleanlinessScore,
                    Restaurant = new RestaurantListItem
                    {
                        Id = r.Restaurant.Id,
                        Name = r.Restaurant.Name,
                        Location = r.Restaurant.Location
                    }
                }).ToListAsync();
            return Ok(ratings);
        }

        //Get By ID
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            Rating rating = await _context
                .Ratings
                .FirstOrDefaultAsync
                (r =>
                r.Id == id);

            if (rating != null)
            {
                RatingDisplay display = new RatingDisplay
                {
                    Id = rating.Id,
                    FoodScore = rating.FoodScore,
                    AtmosphereScore = rating.AtmosphereScore,
                    CleanlinessScore = rating.CleanlinessScore,
                    Restaurant = new RestaurantListItem
                    {
                        Id = rating.Restaurant.Id,
                        Name = rating.Restaurant.Name,
                        Location = rating.Restaurant.Location

                    }
                };
                return Ok(display);
            }
            return NotFound();
        }

        //U
        //Put
        [HttpPut]
        public async Task<IHttpActionResult> UpdateRating([FromUri] int id, [FromBody] Rating updateRating)
        {
            if (ModelState.IsValid)
            {
                Rating OldRating = await _context.Ratings.FindAsync(id);
                if (OldRating != null)
                {
                    OldRating.AtmosphereScore = updateRating.AtmosphereScore;
                    OldRating.CleanlinessScore = updateRating.CleanlinessScore;
                    OldRating.FoodScore = updateRating.FoodScore;

                    await _context.SaveChangesAsync();
                    return Ok("Rating Updated!");
                }
                return NotFound();
            }
            return BadRequest(ModelState);
        }

        //D
        //Delete
        [HttpDelete]
        public async Task<IHttpActionResult> DeleteById(int id)
        {
            var rating = await _context.Ratings.FindAsync(id);
            if (rating == null)

                return NotFound();

            _context.Ratings.Remove(rating);

            if (await _context.SaveChangesAsync() == 1)

                return Ok("The Rating was deleted");

            return InternalServerError();

        }
    }
}
