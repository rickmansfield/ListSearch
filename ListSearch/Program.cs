using System;
using System.Collections.Generic;

namespace ListSearch
{
    class Program
    {
        static List<string> matches = new List<string> {
                                                    "life",
                                                    "i need",
                                                    "why don't",
                                                    "i can",
                                                    "are you",
                                                    "what",
                                                    "because",
                                                    "sorry"
                                                };

        static List<string> responses = new List<string> {
            "Life? Don't talk to me about life.",
            "Why do you need %1?",
            "Do you really think I don't %1?",
            "How do you know you can't %1?",
            "Why does it matter whether I am %1?",
            "Why do you ask?",
            "Is that the real reason?",
            "There are many times when no apology is needed.",
            "Please tell me more."
        };

        //static void Main(string[] args)
        //{
        //    //                  0123456789
        //    string userInput = "I think I need to learn C#";
        //    string output = "";

        //    for (int index = 0; index < matches.Count; index++)
        //    {
        //        string match = matches[index];
        //        int position = userInput.ToLower().IndexOf(match);
        //        if (position > -1)
        //        {
        //            // found a match
        //            output = responses[index];
        //            break;
        //        }
        //    }

        //    // If there wasn't a match, use the last item in the responses list.
        //    if (output == "")
        //    {
        //        output = responses[responses.Count - 1];
        //    }

        //    Console.WriteLine(output);
        //}

        //===============Sec 9 Video 126========================

        static void Main(string[] args)
        {                               //10's      20's      30's
            //                  01234567890123456789012345678901234
            string userInput = "I think I need to learn C# sorry";
            string output = "";
            string lowercaseInput = userInput.ToLower();

            for (int index = 0; index < matches.Count; index++)// loops through the matches list
            {
                string match = matches[index];// gets the current match. i.e. sets match to the current index in the matches list
                int position = lowercaseInput.IndexOf(match);// finds the position of the match in the lowercaseInput string. i.e. checks if the index VALUE of one string is in the other string. 
                if (position > -1)// if the position is greater than -1 a match is found
                {
                    output = responses[index];// sets the output to the current response
                    break;// breaks out of the loop
                }
            }
            // If there wasn't a match, use the last item in the responses list.
            if (output == "")// if the output is empty
            {
                output = responses[responses.Count - 1];// sets the output to the last item in the responses list
            }
            Console.WriteLine(output);
        }
    }
}
