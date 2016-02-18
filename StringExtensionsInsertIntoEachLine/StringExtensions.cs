using System;
using System.Collections.Generic;

namespace StringExtensionsInsertIntoEachLine
{
    public static class StringExtensions
    {
        /// <summary>
        /// Returns a new string in which a specified string is inserted at a specified index position of each line in this instance.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <param name="startIndex">The zero-based index position of the insertion of each line.</param>
        /// <param name="value">The string to insert.</param>
        /// <returns></returns>
        public static string InsertIntoEachLine(this string input, int startIndex, string value)
        {
            string[] delims = { Environment.NewLine };
            var parts = input.Split(delims, StringSplitOptions.None);

            var results = new List<string>();
            foreach (var i in parts)
            {
                results.Add(i.PadRight(startIndex)
                             .Insert(startIndex, value));
            }
            return string.Join(Environment.NewLine, results);
        }
    }
}
