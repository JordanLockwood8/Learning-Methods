using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    internal class Methods
    {
        public static int Add(params int[] ints)
        {
            return ints.Sum();
        }
        public static int Sub(int num1,int num2)
        {
            var sub = num1 - num2;
            return sub;

        }
        public static int Mul(int num1,int num2)
        {
            var mul = num1 * num2;
            return mul;
        }
        public static int Div(int num1, int num2)
        {
            var div = num1 / num2;
            return div;
        }

        public static int Compute(char op, int num1, int num2)
        {
            if (op == '+')
            {
                return Add(num1, num2);
            }
            else if (op == '-')
            {
                return Sub(num1, num2);
            }
            else if (op == '*')
            {
                return Mul(num1, num2);
            }
            else if (op == '/')
            {
                return Div(num1, num2);
            }
           
        }

    }

 }