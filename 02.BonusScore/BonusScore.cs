using System;

    class BonusScore
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter score: ");
            int score = int.Parse(Console.ReadLine());
            switch (score)
            {
                case 1:
                case 2:
                case 3:
                    int sum = score * 10;
                    Console.WriteLine(sum); break;
                case 4:
                case 5:
                case 6:
                    int summ = score * 100;
                    Console.WriteLine(summ); break;
                case 7:
                case 8:
                case 9:
                    int summm = score * 1000;
                    Console.WriteLine(summm); break;
                default: Console.WriteLine("invalid score"); break;
            }
        }
    }

