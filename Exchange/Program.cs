﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(62.3, 73.8, 2.3);

            converter.FromUsd(120);
            converter.ToUsd(25000);

            Console.ReadKey();
        }
    }
}
