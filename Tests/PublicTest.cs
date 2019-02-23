using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace PadawansTask15.Tests
{
    [TestFixture]
    public class PublicTest
    {
        #region GetUpperCaseStrings

        private static IEnumerable<TestCaseData> DataCasesForGetUpperCaseStringTest
        {
            get
            {
                yield return new TestCaseData(
                    new[] { "a", "b", "c" },
                    new[] { "A", "B", "C" },
                    "Method should return upper cased source strings");
                yield return new TestCaseData(
                    new[] { "A", "B", "C" },
                    new[] { "A", "B", "C" },
                    "Method should return source strings");
                yield return new TestCaseData(
                    new[] { "a", "A", "", null },
                    new[] { "A", "A", "", null },
                    "Method should not transform empty strings, upper string and nulls");
            }
        }

        [TestCaseSource(nameof(DataCasesForGetUpperCaseStringTest))]
        public void GetUppercaseStringsTests(IEnumerable<string> data, IEnumerable<string> expected, string message)
        {
            EnumerableTask task = new EnumerableTask();

            CollectionAssert.AreEqual(task.GetUppercaseStrings(data), expected, message: message);
        }

        #endregion

        #region GetStringsLength

        private static IEnumerable<TestCaseData> DataCasesForGetStringsLengthTest
        {
            get
            {
                {
                    yield return new TestCaseData(
                        new[] { "a", "aa", "aaa", "aaaa", "aaaaa" },
                        new[] { 1, 2, 3, 4, 5 },
                        "Method should return strings length.");
                    yield return new TestCaseData(
                        new[] { "a", "a", "a", string.Empty, null },
                        new[] { 1, 1, 1, 0, 0 },
                        "Method should return strings length (empty strings).");
                }
            }
        }

        [TestCaseSource(nameof(DataCasesForGetStringsLengthTest))]
        public void GetStringsLengthTests(IEnumerable<string> data, IEnumerable<int> expected, string message)
        {
            var target = new EnumerableTask();

            CollectionAssert.AreEqual(target.GetStringsLength(data), expected, message: message);
        }

        #endregion

        #region GetSquareSequence

        private static IEnumerable<TestCaseData> DataCasesForGetSquareSequenceTest
        {
            get
            {
                {
                    yield return new TestCaseData(
                        new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 },
                        new long[] { 100, 400, 900, 1600, 2500, 3600, 4900, 6400, 8100, 10000 },
                        "Method should return squares of source sequence."
                    );
                    yield return new TestCaseData(
                        new int[] { 1, -2, 3, -4, 5, -6, 7, -8, 9, -10 },
                        new long[] { 1, 4, 9, 16, 25, 36, 49, 64, 81, 100 },
                        "Method should return squares of source sequence."
                    );
                }
            }
        }

        [TestCaseSource(nameof(DataCasesForGetSquareSequenceTest))]
        public void GetSquareSequenceTests(IEnumerable<int> data, IEnumerable<long> expected, string message)
        {
            var target = new EnumerableTask();

            CollectionAssert.AreEqual(target.GetSquareSequence(data), expected, message: message);
        }

        #endregion

        #region GetPrefixItems

        private static IEnumerable<TestCaseData> DataCasesForGetPrefixItemsTest
        {
            get
            {
                {
                    yield return new TestCaseData("A horse, a kingdom for a horse!".Split(' '),
                        "horse",
                        new string[] { "horse,", "horse!" },
                        "Method should return items started with required prefix.");
                    yield return new TestCaseData("A horse, a kingdom for a horse!".Split(' '),
                        "cow",
                        new string[] { },
                        "Method should return empty sequence if no items started with required prefix.");
                }
            }
        }

        [TestCaseSource(nameof(DataCasesForGetPrefixItemsTest))]
        public void GetPrefixItemsTests(IEnumerable<string> data, string prefix, IEnumerable<string> expected, string message)
        {
            var target = new EnumerableTask();

            CollectionAssert.AreEqual(target.GetPrefixItems(data, prefix), expected, message: message);
        }

        #endregion

        #region Get3LargestItems

        private static IEnumerable<TestCaseData> DataCasesForGet3LargestItemsTest
        {
            get
            {
                {
                    yield return new TestCaseData(
                        new int[] { -1, 23, 56, 654, 1, 43, 0, -101, -23 },
                        new int[] { 654, 56, 43 },
                        "Method should return the 3 largest numbers."
                    );
                    yield return new TestCaseData(
                        new int[] { 1, 2 },
                        new int[] { 2, 1 },
                        "Method should return all items if source sequence consists of <3 items."
                    );
                }
            }
        }

        [TestCaseSource(nameof(DataCasesForGet3LargestItemsTest))]
        public void Get3LargestItemsTests(IEnumerable<int> data, IEnumerable<int> expected, string message)
        {
            var target = new EnumerableTask();

            CollectionAssert.AreEqual(target.Get3LargestItems(data), expected, message: message);
        }

        #endregion

        #region GetSumOfAllIntegers

        private static IEnumerable<TestCaseData> DataCasesForGetSumOfAllIntegersTest
        {
            get
            {
                {
                    yield return new TestCaseData(
                        new object[] { 1, true, "a", "b", false, 1 }, 2,
                        "Method should return the sum of all integers."
                    );
                    yield return new TestCaseData(
                        new object[] { true, false }, 0,
                        "Method should return zero if data does not contain integers."
                    );
                }
            }
        }

        [TestCaseSource(nameof(DataCasesForGetSumOfAllIntegersTest))]
        public void GetSumOfAllIntegersTests(object[] data, int expected, string message)
        {
            var target = new EnumerableTask();

            Assert.AreEqual(target.GetSumOfAllIntegers(data), expected, message: message);
        }

        #endregion
    }
}