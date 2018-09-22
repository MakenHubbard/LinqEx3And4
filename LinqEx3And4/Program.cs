using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqEx3And4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda", "Gregorio",
                "Jean-Paul", "Evangelina", "Viktor", "Jacqueline", "Francisco", "Tre"
            };

            var descend = names.OrderByDescending(n => n);

            List<string> OrderedNames = descend.ToList();

            foreach(var person in OrderedNames)
            {
                Console.WriteLine(person);

            }

            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();

            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            List<int> OrderedNums = numbers.OrderBy(n => n).ToList();

            foreach(int num in OrderedNums)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
