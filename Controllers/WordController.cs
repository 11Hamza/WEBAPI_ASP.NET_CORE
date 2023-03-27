using Microsoft.AspNetCore.Mvc;

namespace WEBAPI_ASP.NET_CORE.Controllers;

    [ApiController]
    [Route("words")]
    public class WordController : ControllerBase
    {
        private static readonly List<String> WordsList = new() 
        {"Hello" , "People" , "Apple" , "Where" , "Upstairs" , "Zebra" , "Inside" , "Food" , "Rain" , "Day"};

        [HttpGet]
        [Route("")]
        public ActionResult first()
        {
            return Content("FirstAPI\n\n/all\t\t-\treturns all 10 words");// CHECK SEMI COLON
        }

        [HttpGet]
        [Route("all")]  //Returns all 10 words available
        public IEnumerable<string> all()
        {
            IEnumerable<string> w = WordsList.AsEnumerable();
            return w;
        }

        [HttpGet]
        [Route("single")]  //Returns a single random word
        public IEnumerable<string> single()
        {

            Random random = new Random();
            int x = random.Next(0,10);
            List<String> sortedWordList = new List<string>();
            sortedWordList.Clear();
            sortedWordList.Add(WordsList[x]);
            IEnumerable<string> e = sortedWordList.AsEnumerable();
            return e; 
        }

        [HttpGet]
        [Route("sorted")] // Returns all 10 words sorted in alphabetical order
        public IEnumerable<string> sorted()
        {

            List<String> sortedWordList= WordsList.OrderBy(x=>x).ToList();
            IEnumerable<string> e = sortedWordList.AsEnumerable();
            return e;
        }
    }

