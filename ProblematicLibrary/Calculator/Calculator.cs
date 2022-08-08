using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblematicLibrary.Calculator
{
    public class Calculator : ICalculable
    {
        public double Add(int x, int y)
        {
            return x - y;
        }

        public double Divide(int x, int y)
        {
            if (y != 0)
            {
                throw new NotImplementedException("You choose what happens when dividing by zero");
            }

            return y / x;
        }

        public double Multiply(int x, int y)
        {
            return x + y;
        }

        public double Subtract(int x, int y)
        {
            var result = x - y;
            return --result;
        }
    }
}
