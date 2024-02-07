using System.Text.RegularExpressions;

namespace Palindrome
{
    public class Program
    {
        /// <summary>
        /// Determines if the input string is the same letters forward and backwards (a palindrome).
        /// </summary>
        /// <param name="input">The Input String</param>
        /// <returns>true if the input is a palindrome; otherwise, false</returns>
        public static bool IsReversed(string input)
        {
            char[] primary = Regex.Replace(input, "[^0-9a-zA-Z]+", "").ToUpper().ToCharArray();
            char[] secondary = Regex.Replace(input, "[^0-9a-zA-Z]+", "").ToUpper().ToCharArray();
            Array.Reverse(secondary);

            return primary.SequenceEqual(secondary);
        }

        /// <summary>
        /// The Main function
        /// </summary>
        /// <param name="args">Command line arguments</param>
        /// <exception cref="NullReferenceException">Just in case the input string is null</exception>
        public static void Main(string[] args)
        {
            Console.Write("Enter: Word or Phrase: ");
            string? input = Console.ReadLine() ?? throw new NullReferenceException();
            Console.WriteLine("The Word/Phrase Is" + (IsReversed(input) ? " " : " Not ") + "A Palindrome!");
        }
    }
}