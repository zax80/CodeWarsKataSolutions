using CodeWars;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodeWarTests
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CountDuplicatesTests()
        {
            Assert.AreEqual(0, CountDuplicates.Count(""));
            Assert.AreEqual(0, CountDuplicates.Count("abcde"));
            Assert.AreEqual(2, CountDuplicates.Count("aabbcde"));
            Assert.AreEqual(2, CountDuplicates.Count("aabBcde"), "should ignore case");
            Assert.AreEqual(1, CountDuplicates.Count("Indivisibility"));
            Assert.AreEqual(2, CountDuplicates.Count("Indivisibilities"), "characters may not be adjacent");
        }

        [Test]
        public void CountDuplicatesLinqTests()
        {
            Assert.AreEqual(0, CountDuplicates.CountLinq(""));
            Assert.AreEqual(0, CountDuplicates.CountLinq("abcde"));
            Assert.AreEqual(2, CountDuplicates.CountLinq("aabbcde"));
            Assert.AreEqual(2, CountDuplicates.CountLinq("aabBcde"), "should ignore case");
            Assert.AreEqual(1, CountDuplicates.CountLinq("Indivisibility"));
            Assert.AreEqual(2, CountDuplicates.CountLinq("Indivisibilities"), "characters may not be adjacent");
        }

        [Test]
        public void TestDubstep1()
        {
            Assert.AreEqual("ABC", Dubstep.SongDecoder("WUBWUBABCWUB"));
        }

        [Test]
        public void TestDubstep2()
        {
            Assert.AreEqual("R L", Dubstep.SongDecoder("RWUBWUBWUBLWUB"));
        }

        [Test]
        public void MultiplesOf3or5Test()
        {
            Assert.AreEqual(23, MultiplesOf3or5.Solution(10));
        }

        private static IEnumerable<TestCaseData> TestCasesIsograms
        {
            get
            {
                yield return new TestCaseData("Dermatoglyphics").Returns(true);
                yield return new TestCaseData("isogram").Returns(true);
                yield return new TestCaseData("moose").Returns(false);
                yield return new TestCaseData("isIsogram").Returns(false);
                yield return new TestCaseData("aba").Returns(false);
                yield return new TestCaseData("moOse").Returns(false);
                yield return new TestCaseData("thumbscrewjapingly").Returns(true);
                yield return new TestCaseData("").Returns(true);
            }
        }

        [Test, TestCaseSource("TestCasesIsograms")]
        public bool Test(string str) => Isograms.IsIsogram(str);

        [Test]
        public void SumOfOddNumbersTest()
        {
            Assert.AreEqual(1, SumOfOddNumbers.RowSumOddNumbers(1));
            Assert.AreEqual(74088, SumOfOddNumbers.RowSumOddNumbers(42));
        }

        [Test]
        public void OnesAndZerosTesting()
        {
            int[] Test1 = new int[] { 0, 0, 0, 0 };
            int[] Test2 = new int[] { 1, 1, 1, 1 };
            int[] Test3 = new int[] { 0, 1, 1, 0 };
            int[] Test4 = new int[] { 0, 1, 0, 1 };

            Assert.AreEqual(0, OnesAndZeros.BinaryArrayToNumber(Test1));
            Assert.AreEqual(15, OnesAndZeros.BinaryArrayToNumber(Test2));
            Assert.AreEqual(6, OnesAndZeros.BinaryArrayToNumber(Test3));
            Assert.AreEqual(5, OnesAndZeros.BinaryArrayToNumber(Test4));
        }

        [Test]
        public void SumsOfDigitsTest()
        {
            Assert.AreEqual(7, SumOfDigits.DigitalRoot(16));
            Assert.AreEqual(6, SumOfDigits.DigitalRoot(456));
        }

        [Test]
        public void SimpleMaxDigitSumTests()
        {
            Assert.AreEqual(1, SimpleMaxDigitSum.Solve(1));
            Assert.AreEqual(2, SimpleMaxDigitSum.Solve(2));
            Assert.AreEqual(18, SimpleMaxDigitSum.Solve(18));
            Assert.AreEqual(48, SimpleMaxDigitSum.Solve(48));
            Assert.AreEqual(99, SimpleMaxDigitSum.Solve(100));
            Assert.AreEqual(9, SimpleMaxDigitSum.Solve(10));
            Assert.AreEqual(99, SimpleMaxDigitSum.Solve(110));
            Assert.AreEqual(1999, SimpleMaxDigitSum.Solve(2090));
            Assert.AreEqual(999999999989, SimpleMaxDigitSum.Solve(999999999992));
        }

        [Test]
        public void ReplaceWithAlphabetPositionTest()
        {
            Assert.AreEqual("20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11", ReplaceWithAlphabetPosition.AlphabetPosition("The sunset sets at twelve o' clock."));
            Assert.AreEqual("20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20", ReplaceWithAlphabetPosition.AlphabetPosition("The narwhal bacons at midnight."));
        }

        [Test]
        public void DuplicateEncoderBasicTests()
        {
            Assert.AreEqual("(((", DuplicateEncoder.DuplicateEncode("din"));
            Assert.AreEqual("()()()", DuplicateEncoder.DuplicateEncode("recede"));
            Assert.AreEqual(")())())", DuplicateEncoder.DuplicateEncode("Success"), "should ignore case");
            Assert.AreEqual("))((", DuplicateEncoder.DuplicateEncode("(( @"));
        }

        [Test]
        public void TribonacciSequenceTests()
        {
            Assert.AreEqual(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 }, TribonacciSequence.Tribonacci(new double[] { 1, 1, 1 }, 10));
            Assert.AreEqual(new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 }, TribonacciSequence.Tribonacci(new double[] { 0, 0, 1 }, 10));
            Assert.AreEqual(new double[] { 0, 1, 1, 2, 4, 7, 13, 24, 44, 81 }, TribonacciSequence.Tribonacci(new double[] { 0, 1, 1 }, 10));
        }

        [Test, Description("Sample Tests")]
        public void Test()
        {
            Assert.AreEqual("128.114.17.104", Int32toIPv4.UInt32ToIP(2154959208));
            Assert.AreEqual("0.0.0.0", Int32toIPv4.UInt32ToIP(0));
            Assert.AreEqual("128.32.10.1", Int32toIPv4.UInt32ToIP(2149583361));
        }
    }
}