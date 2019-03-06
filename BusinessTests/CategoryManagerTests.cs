using System;
using System.Collections.Generic;
using Business;
using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessTests
{
    [TestClass]
    public class CategoryManagerTests
    {
        [TestMethod]
        public void CreateDogCategoryTest()
        {
            // arrange

            MockDatabase mockDatabase = new MockDatabase();
            Category dog = TestsHelper.InitialiseDogCategory();

            CategoryManager categoryManager = new CategoryManager(mockDatabase);

            // act

            categoryManager.Create(dog);

            // assert

            Assert.AreEqual(1, mockDatabase.Categories.Count, "Category not created");
            Assert.AreEqual("Dog", mockDatabase.Categories[0].Name, "Incorrect category name");
            Assert.AreEqual(3, mockDatabase.Categories[0].Fields.Count, "Incorrect number of fields.");
            Assert.AreEqual("Breed", mockDatabase.Categories[0].Fields[0], "Incorrect field.");
            Assert.AreEqual("Colour", mockDatabase.Categories[0].Fields[1], "Incorrect field.");
            Assert.AreEqual("Size", mockDatabase.Categories[0].Fields[2], "Incorrect field.");
        }

        [TestMethod]
        public void CreateAeroplaneCategoryTest()
        {
            // arrange

            MockDatabase mockDatabase = new MockDatabase();
            Category aeroplane = TestsHelper.InitialiseAeroplaneCategory();

            CategoryManager categoryManager = new CategoryManager(mockDatabase);

            // act

            categoryManager.Create(aeroplane);

            // assert

            Assert.AreEqual(1, mockDatabase.Categories.Count, "Category not created");
            Assert.AreEqual("Aeroplane", mockDatabase.Categories[0].Name, "Incorrect category name");
            Assert.AreEqual(3, mockDatabase.Categories[0].Fields.Count, "Incorrect number of fields.");
            Assert.AreEqual("Make", mockDatabase.Categories[0].Fields[0], "Incorrect field.");
            Assert.AreEqual("Model", mockDatabase.Categories[0].Fields[1], "Incorrect field.");
            Assert.AreEqual("Engine", mockDatabase.Categories[0].Fields[2], "Incorrect field.");
        }

        [TestMethod]
        public void GetAllCategoriesTest()
        {
            // arrange

            MockDatabase mockDatabase = new MockDatabase();
            Category dog = TestsHelper.InitialiseDogCategory();
            Category aeroplane = TestsHelper.InitialiseAeroplaneCategory();
            CategoryManager categoryManager = new CategoryManager(mockDatabase);
            categoryManager.Create(aeroplane);
            categoryManager.Create(dog);

            // Act

            var result = categoryManager.GetAll();

            // Assert

            Assert.AreEqual(2, result.Count, "Incorrect count");
            Assert.AreEqual("Aeroplane", result[0].Name, "Incorrect aeroplane category");
            Assert.AreEqual("Dog", result[1].Name, "Incorrect dog category");
        }


    }
}
