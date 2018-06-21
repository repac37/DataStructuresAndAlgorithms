using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleList02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person("Marcin", 29, CountryEnum.PL));
            people.Add(new Person("Sabine", 25, CountryEnum.DE));
            people.Add(new Person("Caroline", 21, CountryEnum.UK));
            people.Add(new Person("John", 21, CountryEnum.UK));
            people.Add(new Person("Nick", 28, CountryEnum.DE));
            people.Add(new Person("Ann", 31, CountryEnum.PL));

            WriteHeader("Alphabetical order");
            List<Person> results = people.OrderBy(p => p.Name).ToList();
            foreach (Person p in results)
            {
                Console.WriteLine($"{p.Name} ({p.Age} years) from {p.Country}.");
            }

            WriteHeader("Filtering with method syntax");
            List<string> names = people.Where(p => p.Age <= 30)
                .OrderBy(p => p.Name)
                .Select(p => p.Name)
                .ToList();

            foreach (String p in names)
            {
                Console.WriteLine(p);
            }

            WriteHeader("Filtering with query syntax");
            List<string> namesQuery = (from p in people
                                       where p.Age <= 30
                                       orderby p.Name
                                       select p.Name).ToList();

            foreach (String p in namesQuery)
            {
                Console.WriteLine(p);
            }


        }

        static void WriteHeader(string header, bool addLine = true)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine((addLine ? Environment.NewLine : string.Empty) + header);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
