
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_1
{
    class Program
    {
        static void Main(string[] args)
        {
        //    string[] cars = { "BMW", "Volvo", "Ford" };
        //    cars[0] = "Toyota";
        //    Console.WriteLine(cars[0]);

        //        int[] numbers = { 23, 25, 45, 67, 56 };
        //    Console.WriteLine(numbers[4]);
        //    Console.ReadLine();

        string firstName = "Alex";
        string lastName = "Doolan";

        string myFullName = string.Concat(firstName, lastName);
        Console.WriteLine(myFullName);

            Console.WriteLine(firstName.IndexOf("x"));
            Console.WriteLine(firstName[3]);
            Console.ReadLine();
        }
    }
}
