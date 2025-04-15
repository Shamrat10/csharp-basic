using CsharpBasicsCode.operators;
using CsharpBasicsCode.conditions;
using CsharpBasicsCode.strings;

namespace CsharpBasicsCode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // comment and uncomment > ctrl + k + c  and ctrl + k + u


            Console.WriteLine("=== Operators Example ===");
            OperatorsExample operatorsExample = new OperatorsExample();
            Console.WriteLine("Addition: " + operatorsExample.Add());
            Console.WriteLine("Sub: " + operatorsExample.Subtract());
            Console.WriteLine("Multiply: " + operatorsExample.Multiply());
            Console.WriteLine("Division: " + operatorsExample.Divide());



            Console.WriteLine("\n=== If-Else Example ===");
            IfElseExample ifElse = new IfElseExample();
            Console.WriteLine(ifElse.CheckEvenOrOdd(5));
            Console.WriteLine(ifElse.CheckEvenOrOdd(8));




            Console.WriteLine("\n=== Switch Case Example ===");
            SwitchCaseExample switchExample = new SwitchCaseExample();
            Console.WriteLine(switchExample.GetDayName(3));
            Console.WriteLine(switchExample.GetDayName(8)); // Invalid


            Console.WriteLine("\n=== String Operations Example ===");
            StringOperationsExample stringOps = new StringOperationsExample();
            string fullName = stringOps.Concatenate("Samrat", "Khan");
            Console.WriteLine("Full Name: " + fullName);
            Console.WriteLine("Length of name: " + stringOps.GetLength(fullName));
            Console.WriteLine("Uppercase: " + stringOps.ToUpperCase(fullName));
            Console.WriteLine("Contains 'Sa'? " + stringOps.ContainsWord(fullName, "Sa"));
        }
    }
}
