using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day1Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedObjects;

namespace Day1Homework.Tests
{
    [TestClass()]
    public class ProductGroupingTests
    {
        [TestMethod()]
        public void GetProductSubTotalTest_3筆一組_取Cost總和_結果應為6_15_24_21()
        {
            // arrange
            var size = 3;
            var colName = "Cost";
            var sut = new ProductGrouping();

            // atc
            var actual = sut.GetProductSubTotal(size, colName);

            // assert
            var expected = new decimal[] { 6, 15, 24, 21 };

            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod()]
        public void GetProductSubTotalTest_4筆一組_取Revenue總和_結果應為50_66_601()
        {
            // arrange
            var size = 4;
            var colName = "Revenue";
            var sut = new ProductGrouping();

            // atc
            var actual = sut.GetProductSubTotal(size, colName);

            // assert
            var expected = new decimal[] { 50, 66, 60 };

            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}