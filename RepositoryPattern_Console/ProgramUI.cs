using RepositoryPattern_Repository_Challenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_Console
{
    class ProgramUI
    { 

    private StreamingContentRepository _contentRepo = new StreamingContentRepository();

     // Method that runs the application
        public void Run()
        {
            seedContentList();
            Menu();

        }

        // Menu Method

        private void Menu()
        {

            bool KeepRunning = true;

            while (KeepRunning)
            { 

            //Display our options to the user

            Console.WriteLine("Select a menu option: \n" +
            "1. Create New Content\n" +
            "2. View All Content\n" +
            "3. View Content By Title\n" +
            "4. Update Existing Content\n" +
            "5. Delete Exist Content\n" +
            "6. Exit");

            // Get the user's input

            string input = Console.ReadLine();

            //Evaluate the user's input and act accordingly

            switch (input)
            {
                case "1":
                        //Create new Content
                        CreateNewContent();
                    break;
                case "2":
                        // View All Content
                        DisplayAllContent();
                    break;
                case "3":
                        //View Content by Title
                        DisplayContentByTitle();
                    break;
                case "4":
                        //Update Existing Content
                        UpdateExistingContent();
                    break;
                case "5":
                        //Delete Existing Content
                        DeleteExistingContent();
                    break;
                case "6":
                        //Exit
                        Console.WriteLine("Goodbye!");
                        KeepRunning = false;
                    break;
                default:
                    Console.WriteLine("Please enter a valid number");
                    break;
        
            }
                Console.WriteLine("Please press any key to continue");
                Console.ReadKey();
                Console.Clear();

            }

        }

        //Create new StreamingContent

        private void CreateNewContent()
        {

            Console.Clear();
            StreamingContent newContent = new StreamingContent();

            //Title 
            Console.WriteLine("Enter the title for the content:");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the description for the content: ");
            newContent.Description = Console.ReadLine();

            //Maturity Rating
            Console.WriteLine("Enter the rating for the content (G, PSG, PG-13 etc): ");
            newContent.MaturityRating = Console.ReadLine();

            //Star Rating 
            Console.WriteLine("Enter the star count for the content (5.8, 10, 1.5 etc): ");
            string starsAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starsAsString);

            //IsFamilyFriendly
            Console.WriteLine("Is this content family friendly? (y/n)");
            string familyFriendlyString = Console.ReadLine().ToLower();

            if (familyFriendlyString == "y")
            {
                newContent.IsFamilyFriendly = true;
            }
            else
            {
                newContent.IsFamilyFriendly = false;
            }

            //GenreType
            Console.WriteLine("Enter the Genre Number: \n" +
                "1. Action\n" +
                "2. Comedy\n" +
                "3. Horror\n" +
                "4. SciFi\n" +
                "5. Drama\n" +
                "6. Documentry");

            string genreAsString = Console.ReadLine();
            int genreAsInt = int.Parse(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt; // this is casting

            _contentRepo.AddContentToList(newContent);

        }

        // View Current Streaming Content that is saved

        private void DisplayAllContent()
        {

            Console.Clear();
            List<StreamingContent> listOfContent = _contentRepo.GetContentList();

            foreach(StreamingContent content in listOfContent)
            {
                Console.WriteLine($"Title: {content.Title},\n" +
                    $" Description: {content.Description}");
            }
        }

        //View Existing content by titl

        private void DisplayContentByTitle()
        {
            Console.WriteLine("Enter your title here: ");
            string userInput = Console.ReadLine();
            StreamingContent title = _contentRepo.GetContentByTitle(userInput);

            if(title != null)
            {
                Console.WriteLine($"Title: {title.Title},\n" +
                    $" Description: {title.Description}\n" +
                    $"Maturity Rating: {title.MaturityRating}\n" +
                    $"Star Rating: {title.MaturityRating}\n" +
                    $"Is Family Friendly: {title.IsFamilyFriendly}\n" +
                    $"Genre: {title.TypeOfGenre}");
            } else
            {
                Console.WriteLine("No title has been found.");
            }

        }

       // Update Existing Content 

        private void UpdateExistingContent()
        {

        }

        // Delete Existing Content

        private void DeleteExistingContent()
        {

        }

        public void seedContentList() // a temp database for the read method
        {
            StreamingContent sharknado = new StreamingContent("Sharknado", "A killer shark", "R", 5.5, false, GenreType.Action);
            StreamingContent toystory = new StreamingContent("Toy Story", "a Comedy toy", "G", 7.2, true, GenreType.Comedy);
            StreamingContent zootobia = new StreamingContent("Zootobia", "zoo animals", "PG", 6.5, false, GenreType.RomCom);

            _contentRepo.AddContentToList(sharknado);
            _contentRepo.AddContentToList(toystory);
            _contentRepo.AddContentToList(zootobia);


        }
    }
}
