using System;
using System.Collections.Generic;

namespace ListSearch
{
    class Program
    {
        static List<string> matches = new List<string> {
                                                    "life",//1
                                                    "i need",//2
                                                    "why don't",//3
                                                    "i can",//4
                                                    "are you",//5
                                                    "what",//6
                                                    "because",//7
                                                    "sorry"//8
                                                };

        static List<string> responses = new List<string> {
            "Life? Don't talk to me about life.",//1
            "Why do you need %1?",//2
            "Do you really think I don't %1?",//3
            "How do you know you can't %1?",//4
            "Why does it matter whether I am %1?",//5
            "Why do you ask?",//6
            "Is that the real reason?",//7
            "There are many times when no apology is needed.",//8
            "Please tell me more."//9
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
            string userInput = "I think why I need to learn C# sorry";
            string output = "";
            string lowercaseInput = userInput.ToLower();

            for (int index = 0; index < matches.Count; index++)// loops through the matches list
            {
                string match = matches[index];// gets the current match. i.e. sets match to the current index integer in the matches list
                int position = lowercaseInput.IndexOf(match);// finds the position of the match in the lowercaseInput string. i.e. checks if the index VALUE of one string is in the other string. 
                if (position > -1)// if the position is greater than -1 a match is found
                {
                    output = responses[index];// sets the output to the current response with the same index integer
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
