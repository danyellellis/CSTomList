using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_AddedValueGoesToIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 10;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList[0];

             //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_CountOfCustomListIncrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 1;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList.countProperty;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_UsingEvenNumbers()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            
            int expected = 4;
            int actual;

            // act
            testList.Add(4);
            testList.Add(6);
            testList.Add(8);
            testList.Add(10);
            actual = testList.countProperty;
            

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_WithUnEqualNumbers()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = -16;
            int expected = 20;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList.countProperty;

            // assert
            Assert.AreNotEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_CapacityDoublesAfterFiveItems()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = -10;
            int expected = 8;
            int actual;

            // act
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            actual = testList.capacityProperty;

            // assert
            Assert.AreNotEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddingMultipleValueToEmptyCustomList_CheckLastItemAtCorrectIndexs()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 25;
            int actual;

            // act
            testList.Add(5);
            testList.Add(10);
            testList.Add(15);
            testList.Add(20);
            testList.Add(25);
            actual = testList[4];

            // assert
            Assert.AreNotEqual(expected, actual);
        }





        // what happens if you add multiple things (or add to a CustomList that already has some values)?
        // what happens to the last-added item?
        // what happens to the Count?

        // what happens if you add more items than the initial Capacity of the CustomList?

    }
}
