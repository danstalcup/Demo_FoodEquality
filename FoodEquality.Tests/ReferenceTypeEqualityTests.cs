using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using FoodEquality.Reference;

namespace FoodEquality.Tests
{
    [TestClass]
    public class ReferenceTypeEqualityTests
    {
        
        #region Reference type equality - equality operator
        [TestMethod]
        public void ReferenceType_EqualityOperator_FoodRWithSameNameAndType_ExpectEquality()
        {
            FoodR banana1 = new FoodR("Banana", Shared.FoodGroup.Fruit);
            FoodR banana2 = new FoodR("Banana", Shared.FoodGroup.Fruit);
            Assert.IsTrue(banana1 == banana2);
        }
        [TestMethod]
        public void ReferenceType_EqualityOperator_FoodRWithSameNameAndDifferentType_ExpectInequality()
        {
            FoodR banana1 = new FoodR("Banana", Shared.FoodGroup.Fruit);
            FoodR banana2 = new FoodR("Banana", Shared.FoodGroup.Meat);
            Assert.IsFalse(banana1 == banana2);
        }
        [TestMethod]
        public void ReferenceType_EqualityOperator_FoodRWithDifferentNameAndSameType_ExpectInequality()
        {
            FoodR banana1 = new FoodR("Banana", Shared.FoodGroup.Fruit);
            FoodR banana2 = new FoodR("Pie", Shared.FoodGroup.Fruit);
            Assert.IsFalse(banana1 == banana2);
        }
        [TestMethod]
        public void ReferenceType_EqualityOperator_FoodRWithDifferentNameAndType_ExpectInequality()
        {
            FoodR banana1 = new FoodR("Banana", Shared.FoodGroup.Fruit);
            FoodR banana2 = new FoodR("Pie", Shared.FoodGroup.Sweets);
            Assert.IsFalse(banana1 == banana2);
        }
        [TestMethod]
        public void ReferenceType_EqualityOperator_FoodRWithNameCapitalizationDifference_ExpectEquality()
        {
            FoodR banana1 = new FoodR("Banana", Shared.FoodGroup.Fruit);
            FoodR banana2 = new FoodR("banAna", Shared.FoodGroup.Fruit);
            Assert.IsTrue(banana1 == banana2);
        }
        [TestMethod]
        public void ReferenceType_EqualityOperator_EqualFoods_ExpectOrderDoesntMatter()
        {
            FoodR banana1 = new FoodR("Banana", Shared.FoodGroup.Fruit);
            FoodR banana2 = new FoodR("Banana", Shared.FoodGroup.Fruit);

            bool equals1 = banana1 == banana2;
            bool equals2 = banana2 == banana1;

            Assert.AreEqual(equals1, equals2);
        }
        [TestMethod]
        public void ReferenceType_EqualityOperator_InequalFoods_ExpectOrderDoesntMatter()
        {
            FoodR banana1 = new FoodR("Banana", Shared.FoodGroup.Fruit);
            FoodR banana2 = new FoodR("Pie", Shared.FoodGroup.Sweets);

            bool equals1 = banana1 == banana2;
            bool equals2 = banana2 == banana1;

            Assert.AreEqual(equals1, equals2);
        }
        #endregion
        #region Reference type equality - inequality operator
        [TestMethod]
        public void ReferenceType_InequalityOperator_EqualValues_ExpectOppositeOfEqualityOperator()
        {
            FoodR banana1 = new FoodR("Banana", Shared.FoodGroup.Fruit);
            FoodR banana2 = new FoodR("Banana", Shared.FoodGroup.Fruit);

            bool equalityOperator = banana1 == banana2;
            bool inequalityOperator = banana1 != banana2;

            Assert.AreNotEqual(equalityOperator, inequalityOperator);
        }
        [TestMethod]
        public void ReferenceType_InequalityOperator_InequalValues_ExpectOppositeOfEqualityOperator()
        {
            FoodR banana1 = new FoodR("Banana", Shared.FoodGroup.Fruit);
            FoodR banana2 = new FoodR("Pie", Shared.FoodGroup.Sweets);

            bool equalityOperator = banana1 == banana2;
            bool inequalityOperator = banana1 != banana2;

            Assert.AreNotEqual(equalityOperator, inequalityOperator);
        }
        [TestMethod]
        public void ReferenceType_InequalityOperator_EqualFoods_ExpectOrderDoesntMatter()
        {
            FoodR banana1 = new FoodR("Banana", Shared.FoodGroup.Fruit);
            FoodR banana2 = new FoodR("Banana", Shared.FoodGroup.Fruit);

            bool equals1 = banana1 != banana2;
            bool equals2 = banana2 != banana1;

            Assert.AreEqual(equals1, equals2);
        }
        [TestMethod]
        public void ReferenceType_InequalityOperator_InequalFoods_ExpectOrderDoesntMatter()
        {
            FoodR banana1 = new FoodR("Banana", Shared.FoodGroup.Fruit);
            FoodR banana2 = new FoodR("Pie", Shared.FoodGroup.Sweets);

            bool equals1 = banana1 != banana2;
            bool equals2 = banana2 != banana1;

            Assert.AreEqual(equals1, equals2);
        }
        #endregion
        #region Reference type equality - object.Equals
        [TestMethod]
        public void ReferenceType_ObjectEquals_FoodRWithSameNameAndType_ExpectEquality()
        {
            FoodR banana1 = new FoodR("Banana", Shared.FoodGroup.Fruit);
            FoodR banana2 = new FoodR("Banana", Shared.FoodGroup.Fruit);
            Assert.IsTrue(banana1.Equals(banana2));
        }
        [TestMethod]
        public void ReferenceType_ObjectEquals_FoodRWithSameNameAndDifferentType_ExpectInequality()
        {
            FoodR banana1 = new FoodR("Banana", Shared.FoodGroup.Fruit);
            FoodR banana2 = new FoodR("Banana", Shared.FoodGroup.Meat);
            Assert.IsFalse(banana1.Equals(banana2));
        }
        [TestMethod]
        public void ReferenceType_ObjectEquals_FoodRWithDifferentNameAndSameType_ExpectInequality()
        {
            FoodR banana1 = new FoodR("Banana", Shared.FoodGroup.Fruit);
            FoodR banana2 = new FoodR("Pie", Shared.FoodGroup.Fruit);
            Assert.IsFalse(banana1.Equals(banana2));
        }
        [TestMethod]
        public void ReferenceType_ObjectEquals_FoodRWithDifferentNameAndType_ExpectInequality()
        {
            FoodR banana1 = new FoodR("Banana", Shared.FoodGroup.Fruit);
            FoodR banana2 = new FoodR("Pie", Shared.FoodGroup.Sweets);
            Assert.IsFalse(banana1.Equals(banana2));
        }
        [TestMethod]
        public void ReferenceType_ObjectEquals_FoodRWithNameCapitalizationDifference_ExpectEquality()
        {
            FoodR banana1 = new FoodR("Banana", Shared.FoodGroup.Fruit);
            FoodR banana2 = new FoodR("banAna", Shared.FoodGroup.Fruit);
            Assert.IsTrue(banana1.Equals(banana2));
        }
        [TestMethod]
        public void ReferenceType_ObjectEquals_EqualFoods_ExpectOrderDoesntMatter()
        {
            FoodR banana1 = new FoodR("Banana", Shared.FoodGroup.Fruit);
            FoodR banana2 = new FoodR("Banana", Shared.FoodGroup.Fruit);

            bool equals1 = banana1.Equals(banana2);
            bool equals2 = banana2.Equals(banana1);

            Assert.AreEqual(equals1, equals2);
        }
        [TestMethod]
        public void ReferenceType_ObjectEquals_InequalFoods_ExpectOrderDoesntMatter()
        {
            FoodR banana1 = new FoodR("Banana", Shared.FoodGroup.Fruit);
            FoodR banana2 = new FoodR("Pie", Shared.FoodGroup.Sweets);

            bool equals1 = banana1.Equals(banana2);
            bool equals2 = banana2.Equals(banana1);

            Assert.AreEqual(equals1, equals2);
        }
        #endregion        
        #region Reference type equality - GetHashCode
        [TestMethod]
        public void ReferenceType_GetHashCode_EquivalentItems_ExpectEqualHashCodes()
        {
            FoodR banana1 = new FoodR("Banana", Shared.FoodGroup.Fruit);
            FoodR banana2 = new FoodR("Banana", Shared.FoodGroup.Fruit);

            int b1hc = banana1.GetHashCode();
            int b2hc = banana2.GetHashCode();

            Assert.AreEqual(b1hc, b2hc);
        }
        #endregion
    }
}

