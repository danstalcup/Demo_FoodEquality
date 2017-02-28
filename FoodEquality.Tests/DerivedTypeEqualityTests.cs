using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using FoodEquality.Reference;

namespace FoodEquality.Tests
{
    [TestClass]
    public class DerivedTypeEqualityTests
    {
        #region Derived type equality - object.Equals
        [TestMethod]
        public void DerivedType_ObjectEquals_CookedFoodWithSameNameSameTypeSameCookingMethod_ExpectEquality()
        {
            CookedFood banana1 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            CookedFood banana2 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            Assert.IsTrue(banana1.Equals(banana2));
        }
        [TestMethod]
        public void DerivedType_ObjectEquals_CookedFoodWithSameNameDifferentTypeSameCookingMethod_ExpectInequality()
        {
            CookedFood banana1 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            CookedFood banana2 = new CookedFood("Banana", Shared.FoodGroup.Meat, "Baked");
            Assert.IsFalse(banana1.Equals(banana2));
        }
        [TestMethod]
        public void DerivedType_ObjectEquals_CookedFoodWithDifferentNameSameTypeSameCookingMethod_ExpectInequality()
        {
            CookedFood banana1 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            CookedFood banana2 = new CookedFood("Pie", Shared.FoodGroup.Fruit, "Baked");
            Assert.IsFalse(banana1.Equals(banana2));
        }
        [TestMethod]
        public void DerivedType_ObjectEquals_CookedFoodWithDifferentNameDifferentTypeSameCookingMethod_ExpectInequality()
        {
            CookedFood banana1 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            CookedFood banana2 = new CookedFood("Pie", Shared.FoodGroup.Sweets, "Baked");
            Assert.IsFalse(banana1.Equals(banana2));
        }
        public void DerivedType_ObjectEquals_CookedFoodWithSameNameSameTypeDifferentCookingMethod_ExpectInequality()
        {
            CookedFood banana1 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            CookedFood banana2 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Fried");
            Assert.IsFalse(banana1.Equals(banana2));
        }
        [TestMethod]
        public void DerivedType_ObjectEquals_CookedFoodWithSameNameDifferentTypeDifferentCookingMethod_ExpectInequality()
        {
            CookedFood banana1 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            CookedFood banana2 = new CookedFood("Banana", Shared.FoodGroup.Meat, "Fried");
            Assert.IsFalse(banana1.Equals(banana2));
        }
        [TestMethod]
        public void DerivedType_ObjectEquals_CookedFoodWithDifferentNameSameTypeDifferentCookingMethod_ExpectInequality()
        {
            CookedFood banana1 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            CookedFood banana2 = new CookedFood("Pie", Shared.FoodGroup.Fruit, "Fried");
            Assert.IsFalse(banana1.Equals(banana2));
        }
        [TestMethod]
        public void DerivedType_ObjectEquals_CookedFoodWithDifferentNameDifferentTypeDifferentCookingMethod_ExpectInequality()
        {
            CookedFood banana1 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            CookedFood banana2 = new CookedFood("Pie", Shared.FoodGroup.Sweets, "Fried");
            Assert.IsFalse(banana1.Equals(banana2));
        }
        [TestMethod]
        public void DerivedType_ObjectEquals_CookedFoodWithNameCapitalizationDifference_ExpectEquality()
        {
            CookedFood banana1 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            CookedFood banana2 = new CookedFood("banAna", Shared.FoodGroup.Fruit, "Baked");
            Assert.IsTrue(banana1.Equals(banana2));
        }
        [TestMethod]
        public void DerivedType_ObjectEquals_EqualFoods_ExpectOrderDoesntMatter()
        {
            CookedFood banana1 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            CookedFood banana2 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");

            bool equals1 = banana1.Equals(banana2);
            bool equals2 = banana2.Equals(banana1);

            Assert.AreEqual(equals1, equals2);
        }
        [TestMethod]
        public void DerivedType_ObjectEquals_InequalFoods_ExpectOrderDoesntMatter()
        {
            CookedFood banana1 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            CookedFood banana2 = new CookedFood("Pie", Shared.FoodGroup.Sweets, "Baked");

            bool equals1 = banana1.Equals(banana2);
            bool equals2 = banana2.Equals(banana1);

            Assert.AreEqual(equals1, equals2);
        }
        #endregion
        #region Derived type equality - equality operator
        [TestMethod]
        public void DerivedType_EqualityOperator_CookedFoodWithSameNameSameTypeSameCookingMethod_ExpectEquality()
        {
            CookedFood banana1 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            CookedFood banana2 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            Assert.IsTrue(banana1 == banana2);
        }
        [TestMethod]
        public void DerivedType_EqualityOperator_CookedFoodWithSameNameDifferentTypeSameCookingMethod_ExpectInequality()
        {
            CookedFood banana1 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            CookedFood banana2 = new CookedFood("Banana", Shared.FoodGroup.Meat, "Baked");
            Assert.IsFalse(banana1 == banana2);
        }
        [TestMethod]
        public void DerivedType_EqualityOperator_CookedFoodWithDifferentNameSameTypeSameCookingMethod_ExpectInequality()
        {
            CookedFood banana1 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            CookedFood banana2 = new CookedFood("Pie", Shared.FoodGroup.Fruit, "Baked");
            Assert.IsFalse(banana1 == banana2);
        }
        [TestMethod]
        public void DerivedType_EqualityOperator_CookedFoodWithDifferentNameDifferentTypeSameCookingMethod_ExpectInequality()
        {
            CookedFood banana1 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            CookedFood banana2 = new CookedFood("Pie", Shared.FoodGroup.Sweets, "Baked");
            Assert.IsFalse(banana1 == banana2);
        }
        [TestMethod]
        public void DerivedType_EqualityOperator_CookedFoodWithSameNameSameTypeDifferentCookingMethod_ExpectInequality()
        {
            CookedFood banana1 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            CookedFood banana2 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Fried");
            Assert.IsFalse(banana1 == banana2);
        }
        [TestMethod]
        public void DerivedType_EqualityOperator_CookedFoodWithSameNameDifferentTypeDifferentCookingMethod_ExpectInequality()
        {
            CookedFood banana1 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            CookedFood banana2 = new CookedFood("Banana", Shared.FoodGroup.Meat, "Fried");
            Assert.IsFalse(banana1 == banana2);
        }
        [TestMethod]
        public void DerivedType_EqualityOperator_CookedFoodWithDifferentNameSameTypeDifferentCookingMethod_ExpectInequality()
        {
            CookedFood banana1 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            CookedFood banana2 = new CookedFood("Pie", Shared.FoodGroup.Fruit, "Fried");
            Assert.IsFalse(banana1 == banana2);
        }
        [TestMethod]
        public void DerivedType_EqualityOperator_CookedFoodWithDifferentNameDifferentTypeDifferentCookingMethod_ExpectInequality()
        {
            CookedFood banana1 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            CookedFood banana2 = new CookedFood("Pie", Shared.FoodGroup.Sweets, "Fried");
            Assert.IsFalse(banana1 == banana2);
        }
        [TestMethod]
        public void DerivedType_EqualityOperator_CookedFoodWithNameCapitalizationDifference_ExpectEquality()
        {
            CookedFood banana1 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            CookedFood banana2 = new CookedFood("banAna", Shared.FoodGroup.Fruit, "Baked");
            Assert.IsTrue(banana1 == banana2);
        }
        [TestMethod]
        public void DerivedType_EqualityOperator_EqualFoods_ExpectOrderDoesntMatter()
        {
            CookedFood banana1 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            CookedFood banana2 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");

            bool equals1 = banana1 == banana2;
            bool equals2 = banana2 == banana1;

            Assert.AreEqual(equals1, equals2);
        }
        [TestMethod]
        public void DerivedType_EqualityOperator_InequalFoods_ExpectOrderDoesntMatter()
        {
            CookedFood banana1 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            CookedFood banana2 = new CookedFood("Pie", Shared.FoodGroup.Sweets, "Baked");

            bool equals1 = banana1 == banana2;
            bool equals2 = banana2 == banana1;

            Assert.AreEqual(equals1, equals2);
        }
        #endregion
        #region Derived type equality - inequality operator
        [TestMethod]
        public void DerivedType_InequalityOperator_EqualValues_ExpectOppositeOfEqualityOperator()
        {
            CookedFood banana1 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            CookedFood banana2 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");

            bool equalityOperator = banana1 == banana2;
            bool inequalityOperator = banana1 != banana2;

            Assert.AreNotEqual(equalityOperator, inequalityOperator);
        }
        [TestMethod]
        public void DerivedType_InequalityOperator_InequalValues_ExpectOppositeOfEqualityOperator()
        {
            CookedFood banana1 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            CookedFood banana2 = new CookedFood("Pie", Shared.FoodGroup.Sweets, "Fried");

            bool equalityOperator = banana1 == banana2;
            bool inequalityOperator = banana1 != banana2;

            Assert.AreNotEqual(equalityOperator, inequalityOperator);
        }
        [TestMethod]
        public void DerivedType_InequalityOperator_EqualFoods_ExpectOrderDoesntMatter()
        {
            CookedFood banana1 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            CookedFood banana2 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");

            bool equals1 = banana1 != banana2;
            bool equals2 = banana2 != banana1;

            Assert.AreEqual(equals1, equals2);
        }
        [TestMethod]
        public void DerivedType_InequalityOperator_InequalFoods_ExpectOrderDoesntMatter()
        {
            CookedFood banana1 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            CookedFood banana2 = new CookedFood("Pie", Shared.FoodGroup.Sweets, "Fried");

            bool equals1 = banana1 != banana2;
            bool equals2 = banana2 != banana1;

            Assert.AreEqual(equals1, equals2);
        }
        #endregion
        #region Derived type equality - GetHashCode
        [TestMethod]
        public void DerivedType_GetHashCode_EquivalentItems_ExpectEqualHashCodes()
        {
            CookedFood banana1 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");
            CookedFood banana2 = new CookedFood("Banana", Shared.FoodGroup.Fruit, "Baked");

            int b1hc = banana1.GetHashCode();
            int b2hc = banana2.GetHashCode();

            Assert.AreEqual(b1hc, b2hc);
        }
        #endregion
    }
}
