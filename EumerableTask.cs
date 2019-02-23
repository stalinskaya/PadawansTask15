using System;
using System.Collections.Generic;
using System.Linq;

namespace PadawansTask15
{
    public class EnumerableTask
    {
        /// <summary> Transforms all strings to upper case.</summary>
        /// <param name="data">Source string sequence.</param>
        /// <returns>
        ///   Returns sequence of source strings in uppercase.
        /// </returns>
        /// <example>
        ///    {"a", "b", "c"} => { "A", "B", "C" }
        ///    { "A", "B", "C" } => { "A", "B", "C" }
        ///    { "a", "A", "", null } => { "A", "A", "", null }
        /// </example>
        public IEnumerable<string> GetUppercaseStrings(IEnumerable<string> data)
        {
            List<string> upper = new List<string>();
            foreach (string d in data)
            {
                if (!String.IsNullOrEmpty(d)) upper.Add(d.ToUpper());
                else upper.Add(d);
            }
            return upper;// TODO : Implement GetUppercaseStrings
            throw new NotImplementedException();
        }

        /// <summary> Transforms an each string from sequence to its length.</summary>
        /// <param name="data">Source strings sequence.</param>
        /// <returns>
        ///   Returns sequence of strings length.
        /// </returns>
        /// <example>
        ///   { } => { }
        ///   {"a", "aa", "aaa" } => { 1, 2, 3 }
        ///   {"aa", "bb", "cc", "", "  ", null } => { 2, 2, 2, 0, 2, 0 }
        /// </example>
        public IEnumerable<int> GetStringsLength(IEnumerable<string> data)
        {
            List<int> length = new List<int>();
            foreach (string d in data)
            {
                if (String.IsNullOrEmpty(d)) length.Add(0);
                else length.Add(d.Length);
            }
            return length;
            // TODO : Implement GetStringsLength
            throw new NotImplementedException();
        }

        /// <summary>Transforms integer sequence to its square sequence, f(x) = x * x. </summary>
        /// <param name="data">Source int sequence.</param>
        /// <returns>
        ///   Returns sequence of squared items.
        /// </returns>
        /// <example>
        ///   { } => { }
        ///   { 1, 2, 3, 4, 5 } => { 1, 4, 9, 16, 25 }
        ///   { -1, -2, -3, -4, -5 } => { 1, 4, 9, 16, 25 }
        /// </example>
        public IEnumerable<long> GetSquareSequence(IEnumerable<int> data)
        {
            List<long> squares = new List<long>();
            foreach (int d in data)
            {
                squares.Add((long)d * d);
            }
            return squares;
            // TODO : Implement GetSquareSequence
            throw new NotImplementedException();
        }

        /// <summary> Filters a string sequence by a prefix value (case insensitive).</summary>
        /// <param name="data">Source string sequence.</param>
        /// <param name="prefix">Prefix value to filter.</param>
        /// <returns>
        ///  Returns items from data that started with required prefix (case insensitive).
        /// </returns>
        /// <exception cref="ArgumentNullException">Thrown when prefix is null.</exception>
        /// <example>
        ///  { "aaa", "bbbb", "ccc", null }, prefix = "b"  =>  { "bbbb" }
        ///  { "aaa", "bbbb", "ccc", null }, prefix = "B"  =>  { "bbbb" }
        ///  { "a","b","c" }, prefix = "D"  => { }
        ///  { "a","b","c" }, prefix = ""   => { "a","b","c" }
        ///  { "a","b","c", null }, prefix = ""   => { "a","b","c" }
        ///  { "a","b","c" }, prefix = null => ArgumentNullException
        /// </example>
        public IEnumerable<string> GetPrefixItems(IEnumerable<string> data, string prefix)
        {
            if (prefix == null) throw new ArgumentNullException();

            List<string> pref = new List<string>();

            if (prefix == "")
            {
                foreach (string d in data)
                {
                    if (d == null) continue;
                    else pref.Add(d);
                }
                return pref;
            }
            else
            {
                foreach (string d in data)
                {
                    if (d == null) continue;
                    if (d.StartsWith(prefix.ToLower()) || d.StartsWith(prefix.ToUpper()))
                        pref.Add(d);
                }
                return pref;
            }
                // TODO : Implement GetPrefixItems
                throw new NotImplementedException();
        }

        /// <summary> Finds the 3 largest numbers from a sequence.</summary>
        /// <param name="data">Source sequence.</param>
        /// <returns>
        ///   Returns the 3 largest numbers from a sequence.
        /// </returns>
        /// <example>
        ///   { } => { }
        ///   { 1, 2 } => { 2, 1 }
        ///   { 1, 2, 3 } => { 3, 2, 1 }
        ///   { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } => { 10, 9, 8 }
        ///   { 10, 10, 10, 10 } => { 10, 10, 10 }
        /// </example>
        public IEnumerable<int> Get3LargestItems(IEnumerable<int> data)
        {
            int number = data.Count();
            IEnumerable<int> largest = data.OrderByDescending(d => d);
            if (data.Count() >= 3)
            {
                largest = largest.Take(3);
            }
            else largest = largest.Take(number);
            return largest;
            // TODO : Implement Get3LargestItems
            throw new NotImplementedException();
        }

        /// <summary> Calculates sum of all integers from object array.</summary>
        /// <param name="data">Source array.</param>
        /// <returns>
        ///    Returns the sum of all integers from object array.
        /// </returns>
        /// <example>
        ///    { 1, true, "a", "b", false, 1 } => 2
        ///    { true, false } => 0
        ///    { 10, "ten", 10 } => 20 
        ///    { } => 0
        /// </example>
        public int GetSumOfAllIntegers(object[] data)
        {
            int sum = 0;
            foreach (var d in data)
            {
                if (d == null) continue;
                if (d.GetType() == typeof(int)) sum += (int)d;
            }
            return sum;
            // TODO : Implement GetSumOfAllIntegers
            throw new NotImplementedException();
        }
    }
}