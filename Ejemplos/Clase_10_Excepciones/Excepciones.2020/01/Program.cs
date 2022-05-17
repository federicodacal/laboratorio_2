﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escriba un número:");
                int i = int.Parse(Console.ReadLine());

                Console.WriteLine(i);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine($"\nStackTrace: \n{e.StackTrace}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine($"\nStackTrace: \n{e.StackTrace}");
            }

            Console.ReadLine();
        }
    }
}
