/*
 *  Copyright 2024 Patrick L. Branson
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 * limitations under the License.
 */

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