using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using FoodEquality.Value;

namespace FoodEquality.Tests
{
    [TestClass]
    public class ValueTypeComparisonTests
    {
        #region Value type comparison - CompareTo
        [TestMethod]
        public void ValueType_CompareTo_GivenCCGreaterValue_ExpectPositive()
        {
            // Arrange
            var cc1 = new CalorieCount(20);
            var cc2 = new CalorieCount(10);

            // Act
            var result = cc1.CompareTo(cc2);

            // Assert
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void ValueType_CompareTo_GivenCCLesserValue_ExpectNegative()
        {
            // Arrange
            var cc1 = new CalorieCount(10);
            var cc2 = new CalorieCount(20);

            // Act
            var result = cc1.CompareTo(cc2);

            // Assert
            Assert.IsTrue(result < 0);
        }

        [TestMethod]
        public void ValueType_CompareTo_GivenCCEqualValue_ExpectZero()
        {
            // Arrange
            var cc1 = new CalorieCount(20);
            var cc2 = new CalorieCount(20);

            // Act
            var result = cc1.CompareTo(cc2);

            // Assert
            Assert.AreEqual(0,result);
        }
        #endregion

        #region Value type comparison - operators
        [TestMethod]
        public void ValueType_Operators_GivenCCGreaterValue_ExpectGreater()
        {
            // Arrange
            var cc1 = new CalorieCount(20);
            var cc2 = new CalorieCount(10);

            // Act
            var result = cc1 > cc2;

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValueType_Operators_GivenCCGreaterValue_ExpectGreaterOrEqual()
        {
            // Arrange
            var cc1 = new CalorieCount(20);
            var cc2 = new CalorieCount(10);

            // Act
            var result = cc1 >= cc2;

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValueType_Operators_GivenCCEqualValue_ExpectGreaterOrEqual()
        {
            // Arrange
            var cc1 = new CalorieCount(20);
            var cc2 = new CalorieCount(20);

            // Act
            var result = cc1 >= cc2;

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValueType_Operators_GivenCCLessValue_ExpectLess()
        {
            // Arrange
            var cc1 = new CalorieCount(10);
            var cc2 = new CalorieCount(20);

            // Act
            var result = cc1 < cc2;

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValueType_Operators_GivenCCLessValue_ExpectLessOrEqual()
        {
            // Arrange
            var cc1 = new CalorieCount(10);
            var cc2 = new CalorieCount(20);

            // Act
            var result = cc1 <= cc2;

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValueType_Operators_GivenCCEqualValue_ExpectLessOrEqual()
        {
            // Arrange
            var cc1 = new CalorieCount(20);
            var cc2 = new CalorieCount(20);

            // Act
            var result = cc1 <= cc2;

            // Assert
            Assert.IsTrue(result);
        }
        #endregion

        #region Value type comparison - CompareToOld
        [TestMethod]
        public void ValueType_CompareToOld_GivenCCGreaterValue_ExpectPositive()
        {
            // Arrange
            var cc1 = new CalorieCount(20);
            var cc2 = new CalorieCount(10);

            // Act
            var result = cc1.CompareTo((object)cc2);

            // Assert
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void ValueType_CompareToOld_GivenCCLesserValue_ExpectNegative()
        {
            // Arrange
            var cc1 = new CalorieCount(10);
            var cc2 = new CalorieCount(20);

            // Act
            var result = cc1.CompareTo((object)cc2);

            // Assert
            Assert.IsTrue(result < 0);
        }

        [TestMethod]
        public void ValueType_CompareToOld_GivenCCEqualValue_ExpectZero()
        {
            // Arrange
            var cc1 = new CalorieCount(20);
            var cc2 = new CalorieCount(20);

            // Act
            var result = cc1.CompareTo((object)cc2);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValueType_CompareToOld_GivenNonCC_ExpectArgumentException()
        {
            // Arrange
            var cc1 = new CalorieCount(20);
            var cc2 = "twenty";

            // Act
            var result = cc1.CompareTo((object)cc2);

            // Assert            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ValueType_CompareToOld_GivenNull_ExpectArgumentNullException()
        {
            // Arrange
            var cc1 = new CalorieCount(20);
            object cc2 = null;

            // Act
            var result = cc1.CompareTo(cc2);

            // Assert            
        }
        #endregion

    }
}
