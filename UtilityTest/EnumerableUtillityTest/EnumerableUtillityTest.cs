using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using CsUtility;
using CsUtility.Enumerable;

namespace UtilityTest.EnumerableUtillityTest
{
    [TestClass]
    public partial class EnumerableUtillityTest
    {
        //[TestMethod]
        //public void MinMaxTextOfFloatNaNValue()
        //{
        //    var testArray = new[] { float.MinValue, float.MaxValue, float.NegativeInfinity, float.NaN };
        //    var nomalTestData = testArray.Select(p => new { Value = p }).ToArray();


        //    var min = nomalTestData.Min(p => p.Value);
        //    var max = nomalTestData.Max(p => p.Value);
        //    var minItem = nomalTestData.First(p => p.Value == min);
        //    var maxItem = nomalTestData.First(p => p.Value == max);

        //    var (utillMin, utillMax) = nomalTestData.MinMax(p => p.Value);
        //    var (utillMinItem, utillMaxItem) = nomalTestData.MinMaxItem(p => p.Value);

        //    Assert.AreEqual(min, utillMin);
        //    Assert.AreEqual(max, utillMax);
        //    Assert.AreEqual(minItem, utillMinItem);
        //    Assert.AreEqual(maxItem, utillMaxItem);
        //    Assert.AreEqual(minItem, nomalTestData.MinItem(p => p.Value));
        //    Assert.AreEqual(maxItem, nomalTestData.MaxItem(p => p.Value));

        //}

    }
}
