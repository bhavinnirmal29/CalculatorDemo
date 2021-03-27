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
            //Commit 5
            test3();
            //Commit 6
            add();
            //Commit 7
            mul();
            //Commit 8
            div();
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
            int n = 10;
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
        public static void add()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("A + B = {0}",(a+b));
        }
        public static void mul()
        {
            int a = 4;
            int b = 20;
            Console.WriteLine("A x B = {0}",(a*b));
        }
        public static void div()
        {
            int a = 10;
            int b = 5;
            Console.WriteLine("A / B =  "+(a/b));
        }

    }
}
