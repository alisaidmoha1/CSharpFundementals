using _07_RepositoryPattern_Repository;
using _08_StreamingContent_Inhertance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11_StreamingContentUIRefactor.UI
{
    public class ProgramUI
    {
        private readonly StreamingRepository _repo = new StreamingRepository();

            private IConsole _console;
        public ProgramUI(IConsole console)
        {
            _console = console;
        }


        public void Run()
        {
            SeedContent();
            Menu();
        }

        public void SeedContent()
        {
            _console.WriteLine("seeding contents...");
            StreamingContent sharknado = new StreamingContent("Sharknado", "A killer shark", MaturityRating.PG13, 5.5, GenreType.Action);
            StreamingContent freaked = new StreamingContent("Freaked", "a Comedy toy", MaturityRating.NC17, 7.2, GenreType.Comedy);
            StreamingContent hawkJones = new StreamingContent("Hawk Jones", "Buddy cop movie", MaturityRating.PG, 5, GenreType.Action);

            _repo.AddContentToDirectory(sharknado);
            _repo.AddContentToDirectory(freaked);
            _repo.AddContentToDirectory(hawkJones);
            
        }

        public void Menu()
        {
            bool continueToRun = true;
            while(continueToRun)
            {
                _console.Clear();

                _console.WriteLine("Menu:\n" +
                    "1. Show all streaming content\n" +
                    "2. Find streaming content by title\n" +
                    "3. Add new streaming content\n" +
                    "4. Remove streaming content\n" +
                    "5. Exit");

                string userInput = _console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        //show all content
                        ShowAllContents();
                        break;
                    case "2":
                        //find by title
                        GetContentByTitle();
                        break;
                    case "3":
                        //add new content;
                        AddNewContent();
                        break;
                    case "4":
                        //Remove content
                        RemoveContent();
                        break;
                    case "5":
                        //Exit
                        continueToRun = false;
                        break;
                    default:
                        _console.WriteLine("Please enter valid input\n" +
                            "Press any key to continue");
                        _console.ReadKey();
                        break;
                }

            }

            _console.Clear();
            _console.WriteLine("Goodbye!");
            Thread.Sleep(2000); // the screen will stay 2 seconds before closing.
            //_console.WriteLine("Menu: .....");
            //_console.WriteLine("Press any key to exit the program, dude...");
            //_console.ReadKey();

        }

        private void ShowAllContents()
        {
            _console.Clear();

            List<StreamingContent> listOfContents = _repo.GetContents();

            foreach (StreamingContent content in listOfContents)
            {
                DisplayContent(content);
            }

            ContinueMessage();
        }

        private void GetContentByTitle()
        {
            _console.Clear();
            _console.WriteLine("Enter a title: ");
            string title = _console.ReadLine();
            StreamingContent content = _repo.GetContentByTitle(title);

            if (content == null)
            {
                _console.WriteLine("Content not found :(");
            } else
            {
                DisplayContent(content);
            }

            ContinueMessage();
        }

        private void DisplayContent(StreamingContent content)
        {
            _console.WriteLine($"{content.Title} ({content.MaturityRating}) - {content.Description} - {content.StarRating} {(content.StarRating == 1.0 ? "star" : "stars")}");
        }

        private void ContinueMessage()
        {
            _console.WriteLine("\nPress any key to continue...");
            _console.ReadKey();
        }

        private void AddNewContent()
        {
            _console.Clear();

            StreamingContent newContent = new StreamingContent();

            //Title
            bool isValidTitle = false;
            while (!isValidTitle) {
                _console.Write("Enter the Title: ");
                string title = _console.ReadLine();
                //newContent.Title = string.IsNullOrWhiteSpace(title) ? "Untitled" : title;
                if(string.IsNullOrWhiteSpace(title))
                {
                    _console.WriteLine("Please enter a valid title (press any key to continue");
                } else
                {
                    newContent.Title = title;
                    isValidTitle = true;
                }
            }
            // Description
            _console.Write("Enter Description: ");
            string description = _console.ReadLine();
            newContent.Description = string.IsNullOrWhiteSpace(description) ? "(No Description)" : description;

            // Star Rating

            _console.Write("Star Rating (0-5): ");
            double stars = double.Parse(_console.ReadLine());
            if (stars > 5)
            {
                newContent.StarRating = 5;
            } else if (stars < 0)
            {
                newContent.StarRating = 0;
            } else
            {
                newContent.StarRating = stars;
            }

            // Maturity

            _console.WriteLine("1. G\n" +
                "2. PG\n" +
                "3. PG-13\n" +
                "4. R\n" +
                "5. NC-17\n" +
                "6. TVMA\n" +
                "7. TVG\n" +
                "8. TVY\n");

            _console.Write("Maturity rating: ");
            string maturityInput = _console.ReadLine();
            int maturityId = int.Parse(maturityInput);
            newContent.MaturityRating = (MaturityRating)maturityId;
            // compile-time error gives you a red line, wont build or run
            // run-time error does not happen untill the code builds and runs

            //Genre 
            _console.WriteLine("1. Scifi\n" +
                "2. Comedy\n" +
                "3. Horror\n" +
                "4. Romantic Comedy\n" +
                "5. Documentery\n" +
                "6. Western\n" +
                "7. Action");
            _console.Write("Genre: ");
            string genreInput = _console.ReadLine();
           
            switch(genreInput)
            {
                case "scifi":
                case "SCIFI":
                case "1":
                    newContent.GenreType = GenreType.SciFi;
                    break;
                case "comedy":
                case "2":
                    newContent.GenreType = GenreType.Comedy;
                    break;

                case "Horror":
                case "3":
                    newContent.GenreType = GenreType.Horror;
                    break;
                case "RomCom":
                case "Romantic Comedy":

                case "4":
                    newContent.GenreType = GenreType.RomCom;
                    break;

                case "5":
                    newContent.GenreType = GenreType.Documentry;
                    break;

                case "6":
                    newContent.GenreType = GenreType.Western;
                    break;

                case "7":
                    newContent.GenreType = GenreType.Action;
                    break;
                default:
                    newContent.GenreType = 0;
                    break;
            }

            _repo.AddContentToDirectory(newContent);

        }

        private void RemoveContent()
        {
            _console.Clear();

            _console.Write("Enter title of the item to remove: ");

            string title = _console.ReadLine();
            StreamingContent content = _repo.GetContentByTitle(title);

            if (content == null)
            {
                _console.WriteLine("Content not found");
            } else
            {
                DisplayContent(content);
                _console.WriteLine("Are you sure you want to delete this? (y/n)");
                string answer = _console.ReadLine();
                if(answer.ToLower() == "y" || answer.ToLower() == "yes")
                {
                    _repo.DeleteExistingContent(content);
                    _console.WriteLine("Content removed");
                } else
                {
                    _console.WriteLine("Nevermind then...");
                }
            }

            ContinueMessage();

        }
    }
}
