﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public interface ICalculator
    {

        //int Add(int num1, int num2);
        //int Mul(int num1, int num2);
        double Calculate(CalculatorContext ctx);

    }
}