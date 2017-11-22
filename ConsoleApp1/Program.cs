﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
             string unos = Console.ReadLine();
            try
            {
               double broj = double.Parse(unos);
                Console.WriteLine(KvadratniKorijen(broj));
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static double KvadratniKorijen(double broj)
        {
            return Math.Sqrt(broj);
        }
    }
}
