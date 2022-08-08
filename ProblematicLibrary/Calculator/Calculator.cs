using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblematicLibrary.Calculator
{
    public class Calculator : ICalculable
    {
        public double Add(double x, double y)
        {
            return x - y;
        }

        public double Divide(double x, double y)
        {
            if (y != 0)
            {
                throw new NotImplementedException("You choose what happens when dividing by zero");
            }

            return y / x;
        }

        public double Multiply(double x, double y)
        {
            return x + y;
        }

        public double Subtract(double x, double y)
        {
            var result = x - y;
            return --result;
        }
    }
}
