using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using FoodEquality.Value;

namespace FoodEquality.Tests
{
    [TestClass]
    public class ValueTypeEqualityTests
    {
        #region Value type equality - equality operator
        [TestMethod]
        public void ValueType_EqualityOperator_FoodVWithSameNameAndType_ExpectEquality()
        {
            FoodV banana1 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            FoodV banana2 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            Assert.IsTrue(banana1 == banana2);
        }
        [TestMethod]
        public void ValueType_EqualityOperator_FoodVWithSameNameAndDifferentType_ExpectInequality()
        {
            FoodV banana1 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            FoodV banana2 = new FoodV("Banana", Shared.FoodGroup.Meat);
            Assert.IsFalse(banana1 == banana2);
        }
        [TestMethod]
        public void ValueType_EqualityOperator_FoodVWithDifferentNameAndSameType_ExpectInequality()
        {
            FoodV banana1 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            FoodV banana2 = new FoodV("Pie", Shared.FoodGroup.Fruit);
            Assert.IsFalse(banana1 == banana2);
        }
        [TestMethod]
        public void ValueType_EqualityOperator_FoodVWithDifferentNameAndType_ExpectInequality()
        {
            FoodV banana1 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            FoodV banana2 = new FoodV("Pie", Shared.FoodGroup.Sweets);
            Assert.IsFalse(banana1 == banana2);
        }
        [TestMethod]
        public void ValueType_EqualityOperator_FoodVWithNameCapitalizationDifference_ExpectEquality()
        {
            FoodV banana1 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            FoodV banana2 = new FoodV("banAna", Shared.FoodGroup.Fruit);
            Assert.IsTrue(banana1 == banana2);
        }
        [TestMethod]
        public void ValueType_EqualityOperator_EqualFoods_ExpectOrderDoesntMatter()
        {
            FoodV banana1 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            FoodV banana2 = new FoodV("Banana", Shared.FoodGroup.Fruit);

            bool equals1 = banana1 == banana2;
            bool equals2 = banana2 == banana1;

            Assert.AreEqual(equals1,equals2);
        }
        [TestMethod]
        public void ValueType_EqualityOperator_InequalFoods_ExpectOrderDoesntMatter()
        {
            FoodV banana1 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            FoodV banana2 = new FoodV("Pie", Shared.FoodGroup.Sweets);

            bool equals1 = banana1 == banana2;
            bool equals2 = banana2 == banana1;

            Assert.AreEqual(equals1, equals2);
        }
        #endregion
        #region Value type equality - inequality operator
        [TestMethod]
        public void ValueType_InequalityOperator_EqualValues_ExpectOppositeOfEqualityOperator()
        {
            FoodV banana1 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            FoodV banana2 = new FoodV("Banana", Shared.FoodGroup.Fruit);

            bool equalityOperator = banana1 == banana2;
            bool inequalityOperator = banana1 != banana2;

            Assert.AreNotEqual(equalityOperator, inequalityOperator);
        }
        [TestMethod]
        public void ValueType_InequalityOperator_InequalValues_ExpectOppositeOfEqualityOperator()
        {
            FoodV banana1 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            FoodV banana2 = new FoodV("Pie", Shared.FoodGroup.Sweets);

            bool equalityOperator = banana1 == banana2;
            bool inequalityOperator = banana1 != banana2;

            Assert.AreNotEqual(equalityOperator, inequalityOperator);
        }
        [TestMethod]
        public void ValueType_InequalityOperator_EqualFoods_ExpectOrderDoesntMatter()
        {
            FoodV banana1 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            FoodV banana2 = new FoodV("Banana", Shared.FoodGroup.Fruit);

            bool equals1 = banana1 != banana2;
            bool equals2 = banana2 != banana1;

            Assert.AreEqual(equals1, equals2);
        }
        [TestMethod]
        public void ValueType_InequalityOperator_InequalFoods_ExpectOrderDoesntMatter()
        {
            FoodV banana1 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            FoodV banana2 = new FoodV("Pie", Shared.FoodGroup.Sweets);

            bool equals1 = banana1 != banana2;
            bool equals2 = banana2 != banana1;

            Assert.AreEqual(equals1, equals2);
        }
        #endregion
        #region Value type equality - IEquatable
        [TestMethod]
        public void ValueType_IEquatable_FoodVWithSameNameAndType_ExpectEquality()
        {
            FoodV banana1 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            FoodV banana2 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            Assert.IsTrue(banana1.Equals(banana2));
        }
        [TestMethod]
        public void ValueType_IEquatable_FoodVWithSameNameAndDifferentType_ExpectInequality()
        {
            FoodV banana1 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            FoodV banana2 = new FoodV("Banana", Shared.FoodGroup.Meat);
            Assert.IsFalse(banana1.Equals(banana2));
        }
        [TestMethod]
        public void ValueType_IEquatable_FoodVWithDifferentNameAndSameType_ExpectInequality()
        {
            FoodV banana1 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            FoodV banana2 = new FoodV("Pie", Shared.FoodGroup.Fruit);
            Assert.IsFalse(banana1.Equals(banana2));
        }
        [TestMethod]
        public void ValueType_IEquatable_FoodVWithDifferentNameAndType_ExpectInequality()
        {
            FoodV banana1 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            FoodV banana2 = new FoodV("Pie", Shared.FoodGroup.Sweets);
            Assert.IsFalse(banana1.Equals(banana2));
        }
        [TestMethod]
        public void ValueType_IEquatable_FoodVWithNameCapitalizationDifference_ExpectEquality()
        {
            FoodV banana1 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            FoodV banana2 = new FoodV("banAna", Shared.FoodGroup.Fruit);
            Assert.IsTrue(banana1.Equals(banana2));
        }
        [TestMethod]
        public void ValueType_IEquatable_EqualFoods_ExpectOrderDoesntMatter()
        {
            FoodV banana1 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            FoodV banana2 = new FoodV("Banana", Shared.FoodGroup.Fruit);

            bool equals1 = banana1.Equals(banana2);
            bool equals2 = banana2.Equals(banana1);

            Assert.AreEqual(equals1, equals2);
        }
        [TestMethod]
        public void ValueType_IEquatable_InequalFoods_ExpectOrderDoesntMatter()
        {
            FoodV banana1 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            FoodV banana2 = new FoodV("Pie", Shared.FoodGroup.Sweets);

            bool equals1 = banana1.Equals(banana2);
            bool equals2 = banana2.Equals(banana1);

            Assert.AreEqual(equals1, equals2);
        }
        #endregion
        #region Value type equality - object.Equals        
        [TestMethod]
        public void ValueType_ObjectEquals_FoodVWithSameNameAndType_ExpectEquality()
        {
            FoodV banana1 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            FoodV banana2 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            Assert.IsTrue(banana1.Equals((object)banana2));
        }
        [TestMethod]
        public void ValueType_ObjectEquals_FoodVWithSameNameAndDifferentType_ExpectInequality()
        {
            FoodV banana1 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            FoodV banana2 = new FoodV("Banana", Shared.FoodGroup.Meat);
            Assert.IsFalse(banana1.Equals((object)banana2));
        }
        [TestMethod]
        public void ValueType_ObjectEquals_FoodVWithDifferentNameAndSameType_ExpectInequality()
        {
            FoodV banana1 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            FoodV banana2 = new FoodV("Pie", Shared.FoodGroup.Fruit);
            Assert.IsFalse(banana1.Equals((object)banana2));
        }
        [TestMethod]
        public void ValueType_ObjectEquals_FoodVWithDifferentNameAndType_ExpectInequality()
        {
            FoodV banana1 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            FoodV banana2 = new FoodV("Pie", Shared.FoodGroup.Sweets);
            Assert.IsFalse(banana1.Equals((object)banana2));
        }
        [TestMethod]
        public void ValueType_ObjectEquals_FoodVWithNameCapitalizationDifference_ExpectEquality()
        {
            FoodV banana1 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            FoodV banana2 = new FoodV("banAna", Shared.FoodGroup.Fruit);
            Assert.IsTrue(banana1.Equals((object)banana2));
        }
        [TestMethod]
        public void ValueType_ObjectEquals_EqualFoods_ExpectOrderDoesntMatter()
        {
            FoodV banana1 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            FoodV banana2 = new FoodV("Banana", Shared.FoodGroup.Fruit);

            bool equals1 = banana1.Equals((object)banana2);
            bool equals2 = banana2.Equals((object)banana1);

            Assert.AreEqual(equals1, equals2);
        }
        [TestMethod]
        public void ValueType_ObjectEquals_InequalFoods_ExpectOrderDoesntMatter()
        {
            FoodV banana1 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            FoodV banana2 = new FoodV("Pie", Shared.FoodGroup.Sweets);

            bool equals1 = banana1.Equals((object)banana2);
            bool equals2 = banana2.Equals((object)banana1);

            Assert.AreEqual(equals1, equals2);
        }
        [TestMethod]
        public void ValueType_ObjectEquals_SecondItemNotIFodd_ExpectInequality()
        {
            FoodV banana1 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            string banana2 = "Banana";

            Assert.AreNotEqual(banana1, banana2);
        }
        #endregion
        #region Value type equality - GetHashCode
        [TestMethod]
        public void ValueType_GetHashCode_EquivalentItems_ExpectEqualHashCodes()
        {
            FoodV banana1 = new FoodV("Banana", Shared.FoodGroup.Fruit);
            FoodV banana2 = new FoodV("Banana", Shared.FoodGroup.Fruit);

            int b1hc = banana1.GetHashCode();
            int b2hc = banana2.GetHashCode();

            Assert.AreEqual(b1hc, b2hc);
        }
        #endregion
    }
}
