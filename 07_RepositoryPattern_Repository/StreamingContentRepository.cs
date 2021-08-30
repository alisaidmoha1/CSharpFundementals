using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
   public class StreamingContentRepository
    {
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        // CRUD - our basic operations of persistent storage.
        //Create
        //Read
        //Update
        //Delete
        
        // Repository pattern = a "database" or list + CRUD methods.

        //Create method

        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(content);

            bool wasAdded = _contentDirectory.Count > startingCount;
            return wasAdded;

            // return _contentDirectory.Count > startingCount;
        }
        // Read Method
        public List<StreamingContent> GetContents()
        {
            return _contentDirectory;
        }

        //Another Read method with value

        public StreamingContent GetContentByTitle(string title)
        {
            // Pseudocode:
            //Loop through the list
            //If content item has correct title return the item 
            // or return null or throw an error if the item is not correct title or does not have title.
            foreach(StreamingContent item in _contentDirectory)
            {
                if (item.Title == title)
                {
                    return item;
                }
            }

            return null;
        }

        public List<StreamingContent> GetFamilyFriendlyContent()
        {
            // get all contents
            // make empty lists
            // loop through contents
            //if friendly 
            //add to list
            //return to the list
            List<StreamingContent> content = GetContents();
            List<StreamingContent> familyFriendlyContents = new List<StreamingContent>();

            foreach (StreamingContent item in content)
            {   
                if (item.IsFamilyFriendly)
                {
                    familyFriendlyContents.Add(item);
                }
            }

            return familyFriendlyContents;

            //Fancy version using LINQ
            //                           lambda expression
            return GetContents().Where(s => s.IsFamilyFriendly).ToList();

        }

        // create a method to retun movies by genre (GetContentsByGenre)

        /*public List<StreamingContent> GetContentsByGenre()
        {
            List<StreamingContent> content = GetContents();
            List<StreamingContent> getbyGenre = new List<StreamingContent>();

            foreach (StreamingContent item in content)
            {

                if (item = GenreType)
                {
                   getbyGenre.Add(item);
                }
            }

            return getbyGenre;
        } */

        //update

        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.StarRating = newContent.StarRating;
                oldContent.GenreType = newContent.GenreType;

                return true;
            } 

            return false;


        }

        // Delete

        public bool DeleteExistingContent(StreamingContent existingContent)
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }
    }
}


