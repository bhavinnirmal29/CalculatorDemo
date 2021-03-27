using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello From Bhavin Nirmal");
            DisplayName();
            DisplayCompName();
            //Commit 1
            even();
            //Commit 2
            Merge();
            //Commit 3
            test1();
            //Commit 4
            test2();
            Console.Read();

        }
        static void DisplayName()
        {
            Console.WriteLine("Hello Disha here!");
        }
        static void DisplayCompName()
        {
            Console.WriteLine("Hello LNT from Azim !");
        }
        static void even()
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("even number");
            }
            else
            {
                Console.WriteLine("odd number");
            }
        }
        static void Merge()
        {
            Console.WriteLine("Test Merge");
        }
        public static void test1()
        {
            Console.WriteLine("Bhavin NIRMAL");
        }
        public static void test2()
        {
            Console.WriteLine("Azim Shaikh Again");
        }
        public static void test3()
        {
            Console.WriteLine("Azure Practice First Commit by Bhavin Nirmal");
        }

    }
}
