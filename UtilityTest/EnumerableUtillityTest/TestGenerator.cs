

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using CsUtility.Enumerable;


namespace UtilityTest.EnumerableUtillityTest
{

    public partial class EnumerableUtillityTest
    {

        [TestMethod]
        public void MinMaxTestOfSByteValueAsEnumerableOnNomal()
        {
            var testData = TestCase.NomalTestCase;
            var min = testData.Min(p => p.SByteValue);
            var max = testData.Max(p => p.SByteValue);
            var minItem = testData.First(p => p.SByteValue == min);
            var maxItem = testData.First(p => p.SByteValue == max);
            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.SByteValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.SByteValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.SByteValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.SByteValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfSbyteNullableValueAsEnumerableOnNomal()
        {
            var testData = TestCase.NomalTestCase;
            var min = testData.Min(p => p.SbyteNullableValue);
            var max = testData.Max(p => p.SbyteNullableValue);
            var minItem = testData.First(p => p.SbyteNullableValue == min);
            var maxItem = testData.First(p => p.SbyteNullableValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.SbyteNullableValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.SbyteNullableValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.SbyteNullableValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.SbyteNullableValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfSbyteNullableValueAsEnumerableOnAllNull()
        {
            var testData = TestCase.AllNullTestCase;
            var min = testData.Min(p => p.SbyteNullableValue);
            var max = testData.Max(p => p.SbyteNullableValue);
            var minItem = testData.First(p => p.SbyteNullableValue == min);
            var maxItem = testData.First(p => p.SbyteNullableValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.SbyteNullableValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.SbyteNullableValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.SbyteNullableValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.SbyteNullableValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfByteValueAsEnumerableOnNomal()
        {
            var testData = TestCase.NomalTestCase;
            var min = testData.Min(p => p.ByteValue);
            var max = testData.Max(p => p.ByteValue);
            var minItem = testData.First(p => p.ByteValue == min);
            var maxItem = testData.First(p => p.ByteValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.ByteValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.ByteValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.ByteValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.ByteValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfByteNullableValueAsEnumerableOnNomal()
        {
            var testData = TestCase.NomalTestCase;
            var min = testData.Min(p => p.ByteNullableValue);
            var max = testData.Max(p => p.ByteNullableValue);
            var minItem = testData.First(p => p.ByteNullableValue == min);
            var maxItem = testData.First(p => p.ByteNullableValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.ByteNullableValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.ByteNullableValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.ByteNullableValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.ByteNullableValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfByteNullableValueAsEnumerableOnAllNull()
        {
            var testData = TestCase.AllNullTestCase;
            var min = testData.Min(p => p.ByteNullableValue);
            var max = testData.Max(p => p.ByteNullableValue);
            var minItem = testData.First(p => p.ByteNullableValue == min);
            var maxItem = testData.First(p => p.ByteNullableValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.ByteNullableValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.ByteNullableValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.ByteNullableValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.ByteNullableValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfCharValueAsEnumerableOnNomal()
        {
            var testData = TestCase.NomalTestCase;
            var min = testData.Min(p => p.CharValue);
            var max = testData.Max(p => p.CharValue);
            var minItem = testData.First(p => p.CharValue == min);
            var maxItem = testData.First(p => p.CharValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.CharValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.CharValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.CharValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.CharValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfCharNullableValueAsEnumerableOnNomal()
        {
            var testData = TestCase.NomalTestCase;
            var min = testData.Min(p => p.CharNullableValue);
            var max = testData.Max(p => p.CharNullableValue);
            var minItem = testData.First(p => p.CharNullableValue == min);
            var maxItem = testData.First(p => p.CharNullableValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.CharNullableValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.CharNullableValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.CharNullableValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.CharNullableValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfCharNullableValueAsEnumerableOnAllNull()
        {
            var testData = TestCase.AllNullTestCase;
            var min = testData.Min(p => p.CharNullableValue);
            var max = testData.Max(p => p.CharNullableValue);
            var minItem = testData.First(p => p.CharNullableValue == min);
            var maxItem = testData.First(p => p.CharNullableValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.CharNullableValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.CharNullableValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.CharNullableValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.CharNullableValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfShortValueAsEnumerableOnNomal()
        {
            var testData = TestCase.NomalTestCase;
            var min = testData.Min(p => p.ShortValue);
            var max = testData.Max(p => p.ShortValue);
            var minItem = testData.First(p => p.ShortValue == min);
            var maxItem = testData.First(p => p.ShortValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.ShortValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.ShortValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.ShortValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.ShortValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfShortNullableValueAsEnumerableOnNomal()
        {
            var testData = TestCase.NomalTestCase;
            var min = testData.Min(p => p.ShortNullableValue);
            var max = testData.Max(p => p.ShortNullableValue);
            var minItem = testData.First(p => p.ShortNullableValue == min);
            var maxItem = testData.First(p => p.ShortNullableValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.ShortNullableValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.ShortNullableValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.ShortNullableValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.ShortNullableValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfShortNullableValueAsEnumerableOnAllNull()
        {
            var testData = TestCase.AllNullTestCase;
            var min = testData.Min(p => p.ShortNullableValue);
            var max = testData.Max(p => p.ShortNullableValue);
            var minItem = testData.First(p => p.ShortNullableValue == min);
            var maxItem = testData.First(p => p.ShortNullableValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.ShortNullableValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.ShortNullableValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.ShortNullableValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.ShortNullableValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfUshortValueAsEnumerableOnNomal()
        {
            var testData = TestCase.NomalTestCase;
            var min = testData.Min(p => p.UshortValue);
            var max = testData.Max(p => p.UshortValue);
            var minItem = testData.First(p => p.UshortValue == min);
            var maxItem = testData.First(p => p.UshortValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.UshortValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.UshortValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.UshortValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.UshortValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfUshortNullableValueAsEnumerableOnNomal()
        {
            var testData = TestCase.NomalTestCase;
            var min = testData.Min(p => p.UshortNullableValue);
            var max = testData.Max(p => p.UshortNullableValue);
            var minItem = testData.First(p => p.UshortNullableValue == min);
            var maxItem = testData.First(p => p.UshortNullableValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.UshortNullableValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.UshortNullableValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.UshortNullableValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.UshortNullableValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfUshortNullableValueAsEnumerableOnAllNull()
        {
            var testData = TestCase.AllNullTestCase;
            var min = testData.Min(p => p.UshortNullableValue);
            var max = testData.Max(p => p.UshortNullableValue);
            var minItem = testData.First(p => p.UshortNullableValue == min);
            var maxItem = testData.First(p => p.UshortNullableValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.UshortNullableValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.UshortNullableValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.UshortNullableValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.UshortNullableValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfIntValueAsEnumerableOnNomal()
        {
            var testData = TestCase.NomalTestCase;
            var min = testData.Min(p => p.IntValue);
            var max = testData.Max(p => p.IntValue);
            var minItem = testData.First(p => p.IntValue == min);
            var maxItem = testData.First(p => p.IntValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.IntValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.IntValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.IntValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.IntValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfIntNullableValueAsEnumerableOnNomal()
        {
            var testData = TestCase.NomalTestCase;
            var min = testData.Min(p => p.IntNullableValue);
            var max = testData.Max(p => p.IntNullableValue);
            var minItem = testData.First(p => p.IntNullableValue == min);
            var maxItem = testData.First(p => p.IntNullableValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.IntNullableValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.IntNullableValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.IntNullableValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.IntNullableValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfIntNullableValueAsEnumerableOnAllNull()
        {
            var testData = TestCase.AllNullTestCase;
            var min = testData.Min(p => p.IntNullableValue);
            var max = testData.Max(p => p.IntNullableValue);
            var minItem = testData.First(p => p.IntNullableValue == min);
            var maxItem = testData.First(p => p.IntNullableValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.IntNullableValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.IntNullableValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.IntNullableValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.IntNullableValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfUintValueAsEnumerableOnNomal()
        {
            var testData = TestCase.NomalTestCase;
            var min = testData.Min(p => p.UintValue);
            var max = testData.Max(p => p.UintValue);
            var minItem = testData.First(p => p.UintValue == min);
            var maxItem = testData.First(p => p.UintValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.UintValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.UintValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.UintValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.UintValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfUintNullableValueAsEnumerableOnNomal()
        {
            var testData = TestCase.NomalTestCase;
            var min = testData.Min(p => p.UintNullableValue);
            var max = testData.Max(p => p.UintNullableValue);
            var minItem = testData.First(p => p.UintNullableValue == min);
            var maxItem = testData.First(p => p.UintNullableValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.UintNullableValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.UintNullableValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.UintNullableValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.UintNullableValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfUintNullableValueAsEnumerableOnAllNull()
        {
            var testData = TestCase.AllNullTestCase;
            var min = testData.Min(p => p.UintNullableValue);
            var max = testData.Max(p => p.UintNullableValue);
            var minItem = testData.First(p => p.UintNullableValue == min);
            var maxItem = testData.First(p => p.UintNullableValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.UintNullableValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.UintNullableValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.UintNullableValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.UintNullableValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfLongValueAsEnumerableOnNomal()
        {
            var testData = TestCase.NomalTestCase;
            var min = testData.Min(p => p.LongValue);
            var max = testData.Max(p => p.LongValue);
            var minItem = testData.First(p => p.LongValue == min);
            var maxItem = testData.First(p => p.LongValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.LongValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.LongValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.LongValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.LongValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfLongNullableValueAsEnumerableOnNomal()
        {
            var testData = TestCase.NomalTestCase;
            var min = testData.Min(p => p.LongNullableValue);
            var max = testData.Max(p => p.LongNullableValue);
            var minItem = testData.First(p => p.LongNullableValue == min);
            var maxItem = testData.First(p => p.LongNullableValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.LongNullableValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.LongNullableValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.LongNullableValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.LongNullableValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfLongNullableValueAsEnumerableOnAllNull()
        {
            var testData = TestCase.AllNullTestCase;
            var min = testData.Min(p => p.LongNullableValue);
            var max = testData.Max(p => p.LongNullableValue);
            var minItem = testData.First(p => p.LongNullableValue == min);
            var maxItem = testData.First(p => p.LongNullableValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.LongNullableValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.LongNullableValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.LongNullableValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.LongNullableValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfUlongValueAsEnumerableOnNomal()
        {
            var testData = TestCase.NomalTestCase;
            var min = testData.Min(p => p.UlongValue);
            var max = testData.Max(p => p.UlongValue);
            var minItem = testData.First(p => p.UlongValue == min);
            var maxItem = testData.First(p => p.UlongValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.UlongValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.UlongValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.UlongValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.UlongValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfUlongNullableValueAsEnumerableOnNomal()
        {
            var testData = TestCase.NomalTestCase;
            var min = testData.Min(p => p.UlongNullableValue);
            var max = testData.Max(p => p.UlongNullableValue);
            var minItem = testData.First(p => p.UlongNullableValue == min);
            var maxItem = testData.First(p => p.UlongNullableValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.UlongNullableValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.UlongNullableValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.UlongNullableValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.UlongNullableValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfUlongNullableValueAsEnumerableOnAllNull()
        {
            var testData = TestCase.AllNullTestCase;
            var min = testData.Min(p => p.UlongNullableValue);
            var max = testData.Max(p => p.UlongNullableValue);
            var minItem = testData.First(p => p.UlongNullableValue == min);
            var maxItem = testData.First(p => p.UlongNullableValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.UlongNullableValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.UlongNullableValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.UlongNullableValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.UlongNullableValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfFloatValueAsEnumerableOnNomal()
        {
            var testData = TestCase.NomalTestCase;
            var min = testData.Min(p => p.FloatValue);
            var max = testData.Max(p => p.FloatValue);
            var minItem = testData.First(p => p.FloatValue == min);
            var maxItem = testData.First(p => p.FloatValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.FloatValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.FloatValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.FloatValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.FloatValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfFloatNullableValueAsEnumerableOnNomal()
        {
            var testData = TestCase.NomalTestCase;
            var min = testData.Min(p => p.FloatNullableValue);
            var max = testData.Max(p => p.FloatNullableValue);
            var minItem = testData.First(p => p.FloatNullableValue == min);
            var maxItem = testData.First(p => p.FloatNullableValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.FloatNullableValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.FloatNullableValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.FloatNullableValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.FloatNullableValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfFloatNullableValueAsEnumerableOnAllNull()
        {
            var testData = TestCase.AllNullTestCase;
            var min = testData.Min(p => p.FloatNullableValue);
            var max = testData.Max(p => p.FloatNullableValue);
            var minItem = testData.First(p => p.FloatNullableValue == min);
            var maxItem = testData.First(p => p.FloatNullableValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.FloatNullableValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.FloatNullableValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.FloatNullableValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.FloatNullableValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfDoubleValueAsEnumerableOnNomal()
        {
            var testData = TestCase.NomalTestCase;
            var min = testData.Min(p => p.DoubleValue);
            var max = testData.Max(p => p.DoubleValue);
            var minItem = testData.First(p => p.DoubleValue == min);
            var maxItem = testData.First(p => p.DoubleValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.DoubleValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.DoubleValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.DoubleValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.DoubleValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfDoubleNullableValueAsEnumerableOnNomal()
        {
            var testData = TestCase.NomalTestCase;
            var min = testData.Min(p => p.DoubleNullableValue);
            var max = testData.Max(p => p.DoubleNullableValue);
            var minItem = testData.First(p => p.DoubleNullableValue == min);
            var maxItem = testData.First(p => p.DoubleNullableValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.DoubleNullableValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.DoubleNullableValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.DoubleNullableValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.DoubleNullableValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfDoubleNullableValueAsEnumerableOnAllNull()
        {
            var testData = TestCase.AllNullTestCase;
            var min = testData.Min(p => p.DoubleNullableValue);
            var max = testData.Max(p => p.DoubleNullableValue);
            var minItem = testData.First(p => p.DoubleNullableValue == min);
            var maxItem = testData.First(p => p.DoubleNullableValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.DoubleNullableValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.DoubleNullableValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.DoubleNullableValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.DoubleNullableValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfDecimalValueAsEnumerableOnNomal()
        {
            var testData = TestCase.NomalTestCase;
            var min = testData.Min(p => p.DecimalValue);
            var max = testData.Max(p => p.DecimalValue);
            var minItem = testData.First(p => p.DecimalValue == min);
            var maxItem = testData.First(p => p.DecimalValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.DecimalValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.DecimalValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.DecimalValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.DecimalValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfDecimalNullableValueAsEnumerableOnNomal()
        {
            var testData = TestCase.NomalTestCase;
            var min = testData.Min(p => p.DecimalNullableValue);
            var max = testData.Max(p => p.DecimalNullableValue);
            var minItem = testData.First(p => p.DecimalNullableValue == min);
            var maxItem = testData.First(p => p.DecimalNullableValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.DecimalNullableValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.DecimalNullableValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.DecimalNullableValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.DecimalNullableValue), maxItem);
            
        }


        [TestMethod]
        public void MinMaxTestOfDecimalNullableValueAsEnumerableOnAllNull()
        {
            var testData = TestCase.AllNullTestCase;
            var min = testData.Min(p => p.DecimalNullableValue);
            var max = testData.Max(p => p.DecimalNullableValue);
            var minItem = testData.First(p => p.DecimalNullableValue == min);
            var maxItem = testData.First(p => p.DecimalNullableValue == max);

            var (utillMin, utillMax) = testData.AsEnumerable().MinMax(p => p.DecimalNullableValue);
            var (utillMinItem, utillMaxItem) = testData.AsEnumerable().MinMaxItem(p => p.DecimalNullableValue);

            Assert.AreEqual(utillMin, min);
            Assert.AreEqual(utillMax, max);
            Assert.AreEqual(utillMinItem, minItem);
            Assert.AreEqual(utillMaxItem, maxItem);
            Assert.AreEqual(testData.AsEnumerable().MinItem(p => p.DecimalNullableValue), minItem);
            Assert.AreEqual(testData.AsEnumerable().MaxItem(p => p.DecimalNullableValue), maxItem);
            
        }



        [TestMethod]
        public void MinMaxTextOfFloatNaNValue()
        {
            var testArray = new[] 
            { 
                float.MinValue, 
                float.MaxValue, 
                float.NegativeInfinity,
                float.NaN 
            };
            var nomalTestData = testArray.Select(p => new { Value = p }).ToArray();


            var min = nomalTestData.Min(p => p.Value);
            var max = nomalTestData.Max(p => p.Value);
            var minItem = nomalTestData.First(p => float.IsNaN(min) && float.IsNaN(p.Value) || p.Value == min);
            var maxItem = nomalTestData.First(p => float.IsNaN(max) && float.IsNaN(p.Value) || p.Value == max);

            var (utillMin, utillMax) = nomalTestData.MinMax(p => p.Value);
            var (utillMinItem, utillMaxItem) = nomalTestData.MinMaxItem(p => p.Value);

            Assert.AreEqual(min, utillMin);
            Assert.AreEqual(max, utillMax);
            Assert.AreEqual(minItem, utillMinItem);
            Assert.AreEqual(maxItem, utillMaxItem);
            Assert.AreEqual(minItem, nomalTestData.MinItem(p => p.Value));
            Assert.AreEqual(maxItem, nomalTestData.MaxItem(p => p.Value));

        }

        [TestMethod]
        public void MinMaxTextOfDoubleNaNValue()
        {
            var testArray = new[] 
            { 
                double.MinValue, 
                double.MaxValue, 
                double.NegativeInfinity,
                double.NaN 
            };
            var nomalTestData = testArray.Select(p => new { Value = p }).ToArray();


            var min = nomalTestData.Min(p => p.Value);
            var max = nomalTestData.Max(p => p.Value);
            var minItem = nomalTestData.First(p => double.IsNaN(min) && double.IsNaN(p.Value) || p.Value == min);
            var maxItem = nomalTestData.First(p => double.IsNaN(max) && double.IsNaN(p.Value) || p.Value == max);

            var (utillMin, utillMax) = nomalTestData.MinMax(p => p.Value);
            var (utillMinItem, utillMaxItem) = nomalTestData.MinMaxItem(p => p.Value);

            Assert.AreEqual(min, utillMin);
            Assert.AreEqual(max, utillMax);
            Assert.AreEqual(minItem, utillMinItem);
            Assert.AreEqual(maxItem, utillMaxItem);
            Assert.AreEqual(minItem, nomalTestData.MinItem(p => p.Value));
            Assert.AreEqual(maxItem, nomalTestData.MaxItem(p => p.Value));

        }

    }
}

