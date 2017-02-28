using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using FoodEquality.Value;

namespace FoodEquality.Tests
{
    [TestClass]
    public class BasicEqualityTests
    {        
        [TestMethod]
        public void BasicEquality_BasicInequality()
        {
            Food_Sample banana = new Food_Sample("banana");
            Food_Sample chocolate = new Food_Sample("chocolate");

            Assert.AreNotEqual(banana, chocolate);
        }

        [TestMethod]
        public void BasicEquality_StaticEqualsReferenceTest()
        {
            Food_Sample banana1 = new Food_Sample("banana");
            Food_Sample banana2 = new Food_Sample("banana");

            Assert.IsFalse(object.Equals(banana1, banana2));
        }

        [TestMethod]
        public void BasicEquality_StringStaticEquals()
        {
            string banana1 = "banana";
            string banana2 = "banana";

            Assert.AreEqual(banana1, banana2);
            Assert.IsTrue(object.Equals(banana1, banana2));            
        }

        [TestMethod]
        public void BasicEquality_NullEqualsNull()
        {
            object one = null;
            object two = null;
            Assert.IsTrue(object.Equals(one, two));
            Assert.AreEqual(one, two);
        }

        [TestMethod]
        public void BasicEquality_StringImmutable()
        {
            string banana1 = "banana";
            string banana2 = string.Copy(banana1);
            Assert.IsFalse(object.ReferenceEquals(banana1, banana2));
        }              
    }
}
