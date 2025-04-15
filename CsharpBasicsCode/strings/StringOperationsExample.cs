namespace CsharpBasicsCode.strings
{
    public class StringOperationsExample
    {
        public string Concatenate(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }

        public int GetLength(string input)
        {
            return input.Length;
        }

        public string ToUpperCase(string input)
        {
            return input.ToUpper();
        }

        public bool ContainsWord(string sentence, string word)
        {
            return sentence.Contains(word);
        }
    }
}
