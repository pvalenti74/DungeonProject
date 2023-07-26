using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block1
{
    internal class Magic8Ball
    {
        static void Main(string[] args)
        {
            /*
             * REQUIREMENTS:
             * 1) Ask the user for their yes/no question
             * 2) Respond with a random answer from your set (collection)
             * of answers
             * 3) Set the program to loop based on user choice
             */

            Console.WriteLine("Welcome to the Magic 8 Ball!");
            Console.Title = "The 8 ball knows all!!!";

            string[] magic8BallAnswers =
            {
                "It is certain",
                "It is decidedly so",
                "Without a doubt",
                "Yes, definitely",
                "You may rely on it",
                "As I see it, yes",
                "Most likely",
                "Outlook good",
                "Yes",
                "Signs point to yes",
                "Reply hazy try again",
                "Ask again later",
                "Better not tell you now",
                "Cannot predict now",
                "Concentrate and ask again",
                "Don't count on it",
                "My reply is no",
                "My sources say no",
                "Outlook not so good",
                "Very doubtful"
            };


            string userAnswer = "";
            do
            {
                Console.WriteLine("\nWhat is your question?");
                Console.ReadLine();

                Random rand = new Random();

                Console.WriteLine("{0}\n",
                    magic8BallAnswers[rand.Next(magic8BallAnswers.Length)]);

                Console.Write("Do you have another question for the Magic 8 Ball? Y/N: \n");
                userAnswer = Console.ReadKey(false).Key.ToString();
                Console.Clear();
                if (userAnswer != "N" && userAnswer != "Y")
                {
                    //erroneous answer.
                    Console.WriteLine("Response not understood. Go ahead and ask another question.");
                    userAnswer = "Y";//force another question.
                }
            } while (userAnswer == "Y");
            Console.WriteLine("Fine. I was tired of answering questions anyway.");
        }
    }
}
