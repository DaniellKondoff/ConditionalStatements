using System;

    class PlayWith
    {
        static void Main()
        {
            Console.WriteLine("Please choos a type:");
            Console.Write("1-->int\n2-->double\n3-->string\n");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.Write("int: ");
                    int a = int.Parse(Console.ReadLine());
                    int sum = a + 1;
                    Console.WriteLine(sum); break;
                case "2": Console.Write("double: ");
                    double b = double.Parse(Console.ReadLine());
                    double sum2 = b + 1;
                    Console.WriteLine(sum2); break;
                case "3": Console.Write("string:");
                    string c = Console.ReadLine();
                    Console.WriteLine(c + "*"); break;
            }
        }
    }

