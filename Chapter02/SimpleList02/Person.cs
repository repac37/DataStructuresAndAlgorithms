using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleList02
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public CountryEnum Country{ get; set; }

        public Person(string name, int age, CountryEnum country)
        {
            Name = name;
            Age = age;
            Country = country;
        }
    }
}
