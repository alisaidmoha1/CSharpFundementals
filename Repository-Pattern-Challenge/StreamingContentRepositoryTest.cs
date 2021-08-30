using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryPattern_Repository_Challenge;
using System;

namespace Repository_Pattern_Challenge
{
    [TestClass]
    public class StreamingContentRepositoryTest
    {
        private StreamingContentRepository _repo;
        private StreamingContent _content;
        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();

            _content = new StreamingContent("Rubber", "A car tyre come to life with power", "R", 5.5, false, GenreType.Drama);
            _repo.AddContentToList(_content);
        }
        
        
        
        //Add Method
        [TestMethod]
        public void AddToList_ShouldGetNotNull()
        {
            // Arrange ---> setting up the playing field
            StreamingContent content = new StreamingContent();
            content.Title = "Toy Story";
            StreamingContentRepository repo = new StreamingContentRepository();

            //Act --> Get/Run the code we want to test
            repo.AddContentToList(content);
            StreamingContent contentFromDirectory = repo.GetContentByTitle("Toy Story");

            //Assert --> Use the assert class to verify th expected outcome
            Assert.IsNotNull(contentFromDirectory);
        }

        //Update
        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            StreamingContent newContent = new StreamingContent("Rubber", "A car tyre come to life with power to make people to explode and goes on a murderous rampage through the Californian desert.", "PG13", 10, false, GenreType.RomCom);

            bool updateResult = _repo.UpdateExistingContent("Rubber", newContent);

            Assert.IsTrue(updateResult);
        }

        [DataTestMethod]
        [DataRow("Rubber", true)]
        [DataRow ("Toy Story", false)]
        public void UpdateExistingContent_ShouldMatchGivenBoool( string originalTitle, bool shouldUpdate)
        {
            StreamingContent newContent = new StreamingContent("Rubber", "A car tyre come to life with power to make people to explode and goes on a murderous rampage through the Californian desert.", "PG13", 10, false, GenreType.RomCom);

            bool updateResult = _repo.UpdateExistingContent("Rubber", newContent);

            Assert.AreEqual(shouldUpdate, updateResult);
        }

        [TestMethod]
        public void DeletCountent_ShouldReturnTrue()
        {
            bool deleteResult = _repo.RemoveContentFromList(_content.Title);
            Assert.IsTrue(deleteResult);
        }
    }
}
