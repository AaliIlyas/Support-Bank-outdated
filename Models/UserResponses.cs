using System;

namespace Support_Bank.Models
{
    class getUserResponses
    {
        public static (string name, bool statement, bool summary) PromptUser()
        {
            Console.Write("What is your name? ");
            var name = Console.ReadLine();
            Console.Write("Would you like a statement of all your transactions? (y/n) ");
            var statement = Console.ReadLine() == "y";
            Console.Write("Would you like total amounts that you owe and are owed? (y/n) ");
            var summary = Console.ReadLine() == "y";

            return (name, statement, summary);
        }
    }
}
