using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _14_RestaurantRater.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        public virtual List<Rating> Ratings { get; set; } = new List<Rating>();

        public double AverageRating
        {
            get
            {
                double totalAverageRating = 0;

                foreach(var rating in Ratings)
                {
                    totalAverageRating += rating.AverageScore;
                }

                return (Ratings.Count > 0) ? totalAverageRating / Ratings.Count : 0;
            }
        }

        public double AverageFoodScore
        {
            get
            {
                double AverageFoodScore = 0;

                foreach (var rating in Ratings)
                {
                    AverageFoodScore += rating.FoodScore;
                }

                return (Ratings.Count > 0) ? AverageFoodScore / Ratings.Count : 0;
            }
        }

        public double AverageAtmosphereScore
        {
            get
            {
                double AverageAtmosphereScore = 0;

                foreach (var rating in Ratings)
                {
                    AverageAtmosphereScore += rating.AtmosphereScore;
                }

                return (Ratings.Count > 0) ? AverageAtmosphereScore / Ratings.Count : 0;
            }
        }

        public double AverageCleanliness
        {
            get
            {
                double AverageCleanlinessScore = 0;

                foreach (var rating in Ratings)
                {
                    AverageCleanlinessScore += rating.CleanlinessScore;
                }

                return (Ratings.Count > 0) ? AverageCleanlinessScore / Ratings.Count : 0;
            }
        }
    }
}