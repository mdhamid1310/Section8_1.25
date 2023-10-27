using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section8_1._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
            Console.ReadLine();
        }
        public static void runApp()
        {
            string[] students = { "Alice", "Bob", "Charlie", "David", "Ella", "Frank", "Grace", "Henry", "Ivy", "Jack" };

            Console.WriteLine("Students (Recursion):");
            printViaRecursion(students, 0, students.Length);
        }

        public static void printViaRecursion(string[] arr, int index, int length)
        {
            if (index < length)
            {
                Console.WriteLine(arr[index]);
                printViaRecursion(arr, index + 1, length);
            }
        }


    }
}
