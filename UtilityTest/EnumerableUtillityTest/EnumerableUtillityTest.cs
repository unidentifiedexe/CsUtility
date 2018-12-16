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
        [TestMethod]
        public void SplitTest()
        {
            var array = new[] { 0, 12, 31, 23, 64, 234, 546, 865, 234, 213 }.Select(p=>p.ToString()).ToArray();
            var splitCount = 3;
            var splitedArrayByOld =
                array
                .Select((p, i) => (Index: i, Item: p))
                .ToLookup(p => p.Index / splitCount, p => p.Item)
                .Select(p => p.ToArray());

            var splitedArrayByUtil = array.Split(splitCount);

            var isSame = splitedArrayByOld.Count() == splitedArrayByUtil.Count();
            if (isSame)
               isSame |= splitedArrayByOld.Zip(splitedArrayByUtil, (old, util) => old.SequenceEqual(util)).All(p => p == true);

            Assert.IsTrue(isSame);


        }

    }
}
