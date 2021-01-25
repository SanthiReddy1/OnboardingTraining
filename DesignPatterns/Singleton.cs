﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public sealed class Singleton
    {
        private static int counter = 0;
        public static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter);
        }
        public void PrintMethod(string Message)
        {
            Console.WriteLine("Print Method " + Message);
        }
    }
}