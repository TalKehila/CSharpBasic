using System;
using System.Xml.Linq;

namespace EqualsAnd__
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int a = 1;
            //int b = 2;
            //if (a == b)
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}

            Person p1 = new Person { Name = "John Doe", Age = 30 };
            Person p2 = new Person { Name = "John Doe", Age = 30 };
            if (p1.Equals(p2))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }     
    }
}
namespace EqualsAnd__
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

}

