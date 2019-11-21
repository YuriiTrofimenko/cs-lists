using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsDemo
{
    class PersonController<T> where T: Person
    {
        public static void PrintPeople(List<T> people) {
            foreach (T person in people)
            {
                Console.WriteLine(person.Name + " " + person.Age);
            }
        }
    }
}
