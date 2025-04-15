using CsharpBasicsCode.operators;

namespace CsharpBasicsCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Learning Operators 
            OperatorsExample operatorsExample = new OperatorsExample();


            Console.WriteLine("Addition: " + operatorsExample.Add());
            Console.WriteLine("Sub: " + operatorsExample.Subtract());
            Console.WriteLine("Multiply: " + operatorsExample.Multiply());
            Console.WriteLine("Division: " + operatorsExample.Divide());
            
        }
    }
}