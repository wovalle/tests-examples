using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.Project.Library
{
    public class Numbers
    {
        public int Sum(int number1, int number2) {
            return number1 + number2;
        }

        public int Substract(int number1, int number2) {
            return number1 - number2;
        }

        public int Multiply(int number1, int number2) {
            return number1 * number2;
        }

        public int Divide(int number1, int number2) {
            return number1 / number2;
        }
    }
}
