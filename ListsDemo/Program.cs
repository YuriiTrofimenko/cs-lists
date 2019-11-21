using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // object[] o1 = { "Hello", 2, true, true, false };

            /*ArrayList al1 = new ArrayList();
            Console.WriteLine(al1.Capacity);
            al1.Add("Hello");
            Console.WriteLine(al1.Capacity);
            al1.Add(2);
            Console.WriteLine(al1.Capacity);
            al1.Add(true);
            Console.WriteLine(al1.Capacity);
            al1.Add(true);
            Console.WriteLine(al1.Capacity);
            al1.Add(false);
            Console.WriteLine(al1.Capacity);*/

            // Error
            // List<string> strings = new List<string>() { "Hello", 2 };
            List<string> strings = new List<string>() { "Hello", "World", "A", "Z", "B" };
            strings.AddRange(new List<string>() { "!", "..." });
            // strings.RemoveAt(1);

            /* for (int i = 0; i < strings.Count; i++)
            {
                Console.WriteLine(strings[i]);
            } */

            // IEnumerator en = strings.GetEnumerator();

            /* while (en.MoveNext())
            {
                Console.WriteLine(en.Current);
            } */

            /* int i = 0;
            foreach (string item in strings)
            {
                if (i == 1)
                {
                    strings.Remove(item);
                }
                else {
                    Console.WriteLine(item);
                }
                i++;
            } */

            /*for (int i = 0; i < al1.Count; i++)
            {
                Console.WriteLine(al1[i]);
            }*/

            /* foreach (var item in strings)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("**************"); */

            /* for (int i = 0; i < strings.Count; i++)
            {
                Console.WriteLine(i);
                if (i == 1)
                {
                    strings.Remove(strings[i]);
                }
                else
                {
                    Console.WriteLine(strings[i]);
                }
            } */

            /* int i = 0;
            int oldCount = strings.Count;
            while (i < strings.Count)
            {
                // Console.WriteLine(i);
                if (i == 1 && (oldCount == strings.Count))
                {
                    strings.Remove(strings[i]);
                }
                else
                {
                    Console.WriteLine(strings[i]);
                    i++;
                }
            }

            strings.Reverse();

            Console.WriteLine("**************");

            foreach (var item in strings)
            {
                Console.WriteLine(item);
            } */

            /* foo(10, 5);
            foo(10.99, 9);
            // foo("Hello", "World");
            foo(true, false);
            foo('a', 'b'); */

            /*SortedList list = new SortedList();
            list.Add(1, "A");
            list.Add(10, "Z");
            list.Add(9, "U");
            list.Add(5, "B");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list.GetKey(i) + " -> " + list.GetValueList()[i]);
            }*/

            /*Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "A");
            dict.Add(10, "Z");
            dict.Add(9, "U");
            dict.Add(5, "B");
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
                Console.WriteLine(item);
            }*/

            List<Person> people = new List<Person>() {
                new Person(){ Id = 1, Name = "John", Age = 30 },
                new Person(){ Id = 2, Name = "Bill", Age = 34 }
            };

            List<Employee> employees = new List<Employee>() {
                new Employee(){ Id = 1, Name = "Maria", Age = 35, Salary = 20000 },
                new Employee(){ Id = 2, Name = "Yurii", Age = 33, Salary = 17000 }
            };

            PersonController<Person>.PrintPeople(people);
            PersonController<Employee>.PrintPeople(employees);
        }

        public static void foo<T>(T x, T y) where T:struct {
            //
            if (x is int || x is double)
            {
                dynamic x1 = x;
                dynamic y1 = y;
                Console.WriteLine(x1 + y1);
            }
            else
            {
                Console.WriteLine("Unknown result");
            }
        }
    }
}
