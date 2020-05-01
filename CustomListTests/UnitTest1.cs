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
            int expected = 1;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList.countProperty;

            // assert
            Assert.AreEqual(expected, actual);
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
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_NewItemAddedAtEndAfterFive()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = -10;
            int expected = 50;
            int actual;

            // act
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(50);
            actual = testList[4];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_OriginalItemsPersists()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = -10;
            int expected = 40;
            int actual;

            // act
            testList.Add(40);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
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
            Assert.AreEqual(expected, actual);

            ///////////REMOVE//////
        }
        [TestMethod]
        public void Remove_MultipleValueToEmptyCustomList_RemoveOne_CheckingCount()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 1;
            int expected = 4;
            int actual;

            // act
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Add(itemToAdd);
            testList.Remove(itemToAdd);
            actual = testList.countProperty;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_MultipleValueToEmptyCustomList_RemoveOne_CheckingIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 20;
            int value2 = 25;
            int value3 = 30;
            int value4 = 35;
            int value5 = 40;
            int expected = 25;
            int actual;

            // act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Add(value4);
            testList.Add(value5);
            testList.Remove(value1);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_OneValueToEmptyCustomList_RemoveOne_ItemFive()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd1 = 20 ;
            int itemToAdd2 = 21;
            int itemToAdd3 = 22;
            int itemToAdd4 = 23;
            int itemToAdd5 = 24;
            int expected = 4;
            int actual;

            // act
            testList.Add(itemToAdd1);
            testList.Add(itemToAdd2);
            testList.Add(itemToAdd3);
            testList.Add(itemToAdd4);
            testList.Add(itemToAdd5);
            testList.Remove(itemToAdd5);
            actual = testList.capacityProperty;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_RemovingOneValueToEmptyCustomList_NextValueGoesToIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 9;
            int itemToAdd1 = 10;
            int itemToAdd2 = 11;
            int expected = 11;
            int actual;

            // act
            testList.Add(itemToAdd);
            testList.Add(itemToAdd1);
            testList.Add(itemToAdd2);
            testList.Remove(itemToAdd);
            actual = testList[0];

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_TwoPositiveValues_RemoveOneCheckingCapacity()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 5;
            int value2 = 10;
            int expected = 4;
            int actual;
            //act
            testList.Add(value1);
            testList.Add(value2);
            testList.Remove(value1);
            actual = testList.capacityProperty;
            //assert
            Assert.AreEqual(expected, actual);
        }




        // what happens if you add multiple things (or add to a CustomList that already has some values)?
        // what happens to the last-added item?
        // what happens to the Count?

        // what happens if you add more items than the initial Capacity of the CustomList?

    }
}
