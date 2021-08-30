﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using _07_RepositoryPattern_Repository;
using System;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            StreamingContent movie =  new StreamingContent();
            Console.WriteLine($"{movie.Title} is a {movie.GenreType} movie about {movie.Description} rated {movie.MaturityRating}");

        }

        [TestMethod]
        public void SetTitle_ShouldSetCorrectString()
        {
            //AAA Patern
            //Arrange
            StreamingContent content = new StreamingContent();
            //ACT
            content.Title = "Double Down";
            Console.WriteLine($"Movie tite: {content.Title}");
            //Assert
            string expected = "DOUBLE DOWN";
            string actual = content.Title;
            Assert.AreEqual(expected, actual);


        }

        //[TestMethod]

        [DataTestMethod]
        [DataRow (MaturityRating.G, true)]
        [DataRow (MaturityRating.TVG, true)]
        [DataRow (MaturityRating.R, false)]
        [DataRow (MaturityRating.PG13, false)]

        public void SetMaturity_ShouldGetCorrectFamilyFriendly( MaturityRating rating, bool expected)
        {
            // Arrange
            StreamingContent content = new StreamingContent("Fateful Findings", "A fantastic movie", rating, 5.0, GenreType.SciFi);

            // Act
            bool actual = content.IsFamilyFriendly;
            //bool expected = true;
            // Assert
            Assert.AreEqual(actual, expected);
            //Assert.IsTrue(actual)

        }
    }
}
