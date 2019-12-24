using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Calculator
    {
        public int num { get; set; }

        public static void calcular(ref int num)
        {
           num *= 2;
        }
    }
}
