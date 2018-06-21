using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, Person> people = new SortedList<string, Person>();
            people.Add("Marcin", new Person("Marcin", 29, CountryEnum.PL));
            people.Add("Sabine", new Person("Sabine", 25, CountryEnum.DE));
            people.Add("Caroline", new Person("Caroline", 21, CountryEnum.UK));
            people.Add("John", new Person("John", 21, CountryEnum.UK));
            people.Add("Nick", new Person("Nick", 28, CountryEnum.DE));
            people.Add("Ann", new Person("Ann", 31, CountryEnum.PL));

            foreach(KeyValuePair<string,Person> person in people)
            {
                Console.WriteLine($"{person.Value.Name} ({person.Value.Age} years) from {person.Value.Country}");
            }

        }
    }
}
