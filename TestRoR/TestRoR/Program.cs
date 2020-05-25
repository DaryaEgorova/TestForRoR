using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Collections;
using System.Linq;
using System.Text;

namespace TestRoR
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Введите число, для которого будет создана последовательность");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину последовательности (кол-во строк в последовательности)");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine();

            

            var numbers = new Sequence(n, k);

        }



    }
}