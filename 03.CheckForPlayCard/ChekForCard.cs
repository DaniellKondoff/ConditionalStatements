using System;

    class ChekForCard
    {
        static void Main()
        {
            Console.Write("Enter character: ");
            string i = Console.ReadLine();

            if (i == "2" || i == "3" || i == "4" || i == "5" || i == "6" || i == "7" || i == "8" || i == "9" || i == "10" || i == "J" || i == "Q" || i == "K" || i == "A")
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }

