using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryPattern_Repository_Challenge;
using System;

namespace Repository_Pattern_Challenge
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void SetTitle_ShouldSetrCorrectString()
        {
            StreamingContent content = new StreamingContent();

            content.Title = "Toy Story";

            string expected = "Toy Story";
            string actual = content.Title;

            Assert.AreEqual(expected, actual);
        }
    }
}
