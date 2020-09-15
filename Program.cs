using System;

namespace Week3LOgicalOperatorsOR
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Seasons
             * A program asks the user what mont they were born
             *December, January or February - You were born in winter
             *March, April or May - you were born in spring
             *June, Juli or August - You were born in summer
             *September, October or November - You born in autum
             */
            Console.WriteLine("What month were you born?");
            string month = Console.ReadLine().ToLower();
            // || - pipes alt + ctrl + <
            if (month == "december" || month == "january" || month == "february")
            {
                Console.WriteLine("You were born in winter.");
            }
            else if (month == "april" || month == "may" || month == "march")
            {
                Console.WriteLine("You were born in spring.");
            }
            else if (month == "june" || month == "juli" || month == "august")
            {
                Console.WriteLine("You were born in summer.");
            }
            else if (month == "september" || month == "october" || month == "november")
            {
                Console.WriteLine("You were born in autum.");
            }
            else
            {
                Console.WriteLine("Wrong answer.");
            }
        }
    }
}
