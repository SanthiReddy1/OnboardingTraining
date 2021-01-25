﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton employeeInstance = Singleton.GetInstance;
            employeeInstance.PrintMethod("Employee Instance");
            Singleton studentInstance = Singleton.GetInstance;
            studentInstance.PrintMethod("Student Instance");
        }
    }
}
