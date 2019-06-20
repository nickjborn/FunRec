using System;
using System.Linq;

namespace FunRecs
{
    class Program
    {
        static void Main(string[] args)
        {
            //First Question

            Console.WriteLine("Got weekend plans? Let's find you something to do.");
            Console.WriteLine("What are you in the mood for?");
            Console.WriteLine("1. Action.");
            Console.WriteLine("2. Chilling.");
            Console.WriteLine("3. Danger.");
            Console.WriteLine("4. Good Food.");

            string Activity;
            string[] activities = { "nothing", "stock car racing", "hiking", "skydiving", "to Taco Bell" };
            string userinput1 = Console.ReadLine();
            int answerOne;

            bool TGPA = int.TryParse(userinput1, out answerOne);

            if (Enumerable.Range(1, 4).Contains(answerOne))
            {
                TGPA = true;
            }
            else
            {
                TGPA = false;
            }


            while (TGPA == false)
            {
                Console.WriteLine("{0} is not a valid option, enter a number 1-4", userinput1);
                userinput1 = Console.ReadLine();
                answerOne = 0;

                TGPA = int.TryParse(userinput1, out answerOne);
            }
            Activity = activities[answerOne];


            //Second Question     
            Console.WriteLine("How many people are you bringing?");
            Console.WriteLine("1. 0.");
            Console.WriteLine("2. 1-4.");
            Console.WriteLine("3. 5-10.");
            Console.WriteLine("4. 11 or more.");

            string transport;
            string[] transports = { "nothing", "walking.", "a sedan.", "a VW bus.", "an airplane." };
            string userinput2 = Console.ReadLine();
            int answerTwo;

            bool TGPA2 = int.TryParse(userinput2, out answerTwo);

            if (Enumerable.Range(1, 4).Contains(answerTwo))
            {
                TGPA2 = true;
            }
            else
            {
                TGPA2 = false;
            }


            while (TGPA2 == false)
            {
                Console.WriteLine("{0} is not a valid option, enter a number 1-4", userinput2);
                userinput2 = Console.ReadLine();
                answerTwo = 0;

                TGPA2 = int.TryParse(userinput2, out answerTwo);


               

            }
            transport = transports[answerTwo];
            //Print the answer

            Console.WriteLine("You should consider going " + Activity + " and get there by means of " + transport);
            Console.WriteLine("Have fun!");
            
        }
    }
}
