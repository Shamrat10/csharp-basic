namespace CsharpBasicsCode.conditions
{
    public class IfElseExample
    {
        public string CheckEvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                return $"{number} is Even";
            }
            else
            {
                return $"{number} is Odd";
            }
        }


        // Grade Check 

        // TODO:
        // 1. pass int number
        // 2. cgeck if number is greater than or equal to 80, return "A+"
        // 3. check if number is greater than or equal to 70, return "A"
        // 4. check if number is greater than or equal to 60, return "A-"
        // 5. check if number is greater than or equal to 50, return "B"
        // 6. check if number is greater than or equal to 40, return "C"
        // 7. check if number is greater than or equal to 33, return "D"
    }
}
