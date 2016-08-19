using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    public class Add : ICalculator
    {
        public double Calculate(CalculatorContext ctx)
        {
            double result = ctx.Accumulator + ctx.CurrentDisplay;
            return result;
        }

    }

    public class Substract : ICalculator
    {
        public double Calculate(CalculatorContext ctx)
        {
            double result = ctx.Accumulator - ctx.CurrentDisplay;
            return result;
        }

    }

    public class Square : ICalculator
    {
        public double Calculate(CalculatorContext ctx)
        {
            double result = ctx.Accumulator * ctx.Accumulator;
            return result;
        }

    }

    public class CalculatorContext
    {
        private double _accumulator;
        private double _currentDisplay;


        public CalculatorContext(double accumulator, double currentDisplay)
        {
            _accumulator = accumulator;
            _currentDisplay = currentDisplay;

        }
        public double Accumulator
        {
            get { return _accumulator; }
            set { _accumulator = value; }

        }
        public double CurrentDisplay
        {
            get { return _currentDisplay; }
            set { _currentDisplay = value; }

        }
         
    }
}
