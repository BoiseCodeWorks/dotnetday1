using System; //import 
using System.Collections.Generic;
using System.Linq;

namespace day1 //group all files of similar namespace together
{
    class Program  //always the first instatiated class by the dotnet core engine
    {
        static void Main(string[] args) //first method to run
        {
            Console.Clear();
            #region NOTES  

            //NOTE Strings
            //Console.WriteLine("Hello World");
            // Console.WriteLine("Hello " + "World");
            // Console.WriteLine("Hello {0}, My name is {1}", "World", "Mark");
            // var name = "Mark";
            // Console.WriteLine($@"
            // Hello {name}
            // Welcome to the Party!
            // ");

            //NOTE Readline and Implicit vs Explicit typing
            // Console.Write("What is your name: ");
            //Implicit
            // var name = Console.ReadLine();
            // Console.WriteLine($@"
            //  Hello {name}
            //  Welcome to the Party!
            //  ");

            // bool valid = false;
            // int ageInt = 0;
            //NOTE int: whole numbers, float/double/decimal
            //NOTE while loop
            // while (!valid)
            // {
            //     Console.WriteLine("How old are you: ");
            //     //Explicit
            //     string age = Console.ReadLine();
            //     valid = Int32.TryParse(age, out ageInt);//TryParse handles casting to numbers gracefully

            // }
            //NOTE Switch stuff
            // System.Console.WriteLine($"In 10 years you will be {ageInt + 10}");
            // switch (name.ToLower())
            // {
            //     case "mark":
            //         System.Console.WriteLine("thats still so young");
            //         break;
            //     case "jafar":
            //         System.Console.WriteLine("But your so oooold");
            //         break;
            //     default:
            //         System.Console.WriteLine("thats a bummer");
            //         break;
            // }

            #endregion

            // enter dice to roll 
            //1d20
            //returns a random number between 1 and 20

            //3d4
            // returns 3 rolls of 1 to 4 and the total of the rolls

            #region DICE
            Console.Write("Enter the dice to roll: ");
            string[] input = Console.ReadLine().ToLower().Split('d'); ;
            string rolls = input[0];
            string sides = "";
            if (input.Length > 1)
            {
                sides = input[1];
            }
            if (Int32.TryParse(rolls, out int rollsInt) && Int32.TryParse(sides, out int sidesInt) && sidesInt > 0)
            {
                Random rng = new Random();
                int total = 0;
                for (int i = 0; i < rollsInt; i++)
                {
                    int roll = rng.Next(1, sidesInt + 1);
                    total += roll;
                    System.Console.WriteLine(roll);
                }
                System.Console.WriteLine($"Total: [{total}]");
            }
            else
            {
                System.Console.WriteLine("INVALID INPUT GOODBYE");
            }
            #endregion

            //NOTE Arrays once created have fixed length
            string[] dogs = new string[]{
                "Rocky",
                "Minnie",
                "Bobo"
            };
            List<string> cats = new List<string>(){
                "garfield",
                "felix",
                "tom"
            };
            cats.Add("Mittens");
            cats.Find(cat => cat == "felix");



        }
    }
}
