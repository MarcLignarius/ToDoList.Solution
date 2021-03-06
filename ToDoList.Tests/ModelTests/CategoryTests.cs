using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using ToDoList.Models;

namespace ToDoList.Tests
{
    [TestClass]
    public class CategoryTests : IDisposable
    {
        public CategoryTests()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=to_do_list_test;";
        }

        // [TestMethod]
        // public void GetAll_CategoriesEmptyAtFirst_0()
        // {
        //     //Arrange, Act
        //     int result = Category.GetAll().Count;
        //
        //     //Assert
        //     Assert.AreEqual(0, result);
        // }
        //
        // [TestMethod]
        // public void Equals_ReturnsTrueIfNamesAreTheSame_Category()
        // {
        //     //Arrange, Act
        //     Category firstCategory = new Category("Household chores");
        //     Category secondCategory = new Category("Household chores");
        //
        //     //Assert
        //     Assert.AreEqual(firstCategory, secondCategory);
        // }
        //
        // [TestMethod]
        // public void Save_SavesCategoryToDatabase_CategoryList()
        // {
        //     //Arrange
        //     Category testCategory = new Category("Household chores");
        //     testCategory.Save();
        //
        //     //Act
        //     List<Category> result = Category.GetAll();
        //     List<Category> testList = new List<Category>{testCategory};
        //
        //     //Assert
        //     CollectionAssert.AreEqual(testList, result);
        // }
        //
        // [TestMethod]
        // public void Save_DatabaseAssignsIdToCategory_Id()
        // {
        //     //Arrange
        //     Category testCategory = new Category("Household chores");
        //     testCategory.Save();
        //
        //     //Act
        //     Category savedCategory = Category.GetAll()[0];
        //
        //     int result = savedCategory.GetId();
        //     int testId = testCategory.GetId();
        //
        //     //Assert
        //     Assert.AreEqual(testId, result);
        // }
        //
        // [TestMethod]
        // public void Find_FindsCategoryInDatabase_Category()
        // {
        //     //Arrange
        //     Category testCategory = new Category("Household chores");
        //     testCategory.Save();
        //
        //     //Act
        //     Category foundCategory = Category.Find(testCategory.GetId());
        //
        //     //Assert
        //     Assert.AreEqual(testCategory, foundCategory);
        // }
        //
        [TestMethod]
        public void GetItems_ReturnsAllCategoryItems_ItemList()
        {
            //Arrange
            DateTime itemDueDate =  new DateTime(1999, 12, 24);
            Category testCategory = new Category("Household chores");
            testCategory.Save();
            Item testItem1 = new Item("Mow the lawn", itemDueDate);
            testItem1.Save();
            Item testItem2 = new Item("Buy plane ticket", itemDueDate);
            testItem2.Save();

            //Act
            testCategory.AddItem(testItem1);
            List<Item> savedItems = testCategory.GetItems();
            List<Item> testList = new List<Item> {testItem1};

            //Assert
            CollectionAssert.AreEqual(testList, savedItems);
        }

        [TestMethod]
        public void Delete_DeletesCategoryAssociationsFromDatabase_CategoryList()
        {
            //Arrange
            DateTime itemDueDate =  new DateTime(1999, 12, 24);
            Item testItem = new Item("Mow the lawn", itemDueDate);
            testItem.Save();
            string testName = "Home stuff";
            Category testCategory = new Category(testName);
            testCategory.Save();

            //Act
            testCategory.AddItem(testItem);
            testCategory.Delete();
            List<Category> resultItemCategories = testItem.GetCategories();
            List<Category> testItemCategories = new List<Category> {};

            //Assert
            CollectionAssert.AreEqual(testItemCategories, resultItemCategories);
        }

        [TestMethod]
        public void Test_AddItem_AddsItemToCategory()
        {
            //Arrange
            Category testCategory = new Category("Household chores");
            testCategory.Save();
            DateTime itemDueDate =  new DateTime(1999, 12, 24);
            Item testItem = new Item("Mow the lawn", itemDueDate);
            testItem.Save();
            Item testItem2 = new Item("Water the garden", itemDueDate);
            testItem2.Save();

            //Act
            testCategory.AddItem(testItem);
            testCategory.AddItem(testItem2);
            List<Item> result = testCategory.GetItems();
            List<Item> testList = new List<Item>{testItem, testItem2};

            //Assert
            CollectionAssert.AreEqual(testList, result);
        }

        public void Dispose()
        {
            Item.ClearAll();
            Category.ClearAll();
        }

    }
}
