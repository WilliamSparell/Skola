using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniräknare
{
    internal class Calculator
    {
        double memory= 0;
        char op = '+';
        public Calculator Digit (double d) 
        {
            switch (op)
            {
                case '+': memory += d; break;
                case '-': memory -= d; break;
                case '*': memory *= d; break;
                case '/': memory /= d; break;
                case 'C':
                case 'c': memory = 0; op = '+'; break;
            }
            return this;

        }
        public Calculator Operator(char op) 
        { 
            this.op = op;
            return this; 
        }
        public double Result() 
        {  
            return memory;
        }
    }
}
