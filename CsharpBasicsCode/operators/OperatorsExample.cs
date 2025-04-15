using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasicsCode.operators
{
    public class OperatorsExample
    {
        //constructor
        public int a;
        public int b;

        public int c;
        public int d;


        //Constructor
        public OperatorsExample()
        {
            a = 30;
            b = 20;
        }



        //Functions

        //Addition
        public int Add()
        {
            var result = a + b;
            return result;
        }

        //subtraction
        public int Subtract()
        {
            var result = a - b;
            return result;
        }

        //Multiplication
        public int Multiply()
        {
            var result = a * b;
            return result;
        }


        //Division
        public float Divide()
        {
            float result = (float)a / b; // Cast one operand
            return result;
        }

    }
}
