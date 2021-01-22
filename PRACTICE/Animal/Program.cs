﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Lion = new Lion();
            Animal Tiger = new Tiger();

            Tiger.Setme("Tiger", 100);
            Tiger.Show();
            Console.WriteLine();
            Lion.Setme("Lion", 200);
            Lion.Show();
            Console.ReadKey();
        }
    }
}
