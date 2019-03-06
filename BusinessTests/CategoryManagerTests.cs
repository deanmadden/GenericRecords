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

            Category dog = new Category("Dog");
            List<string> dogfields = new List<string>(new string[] { "Breed", "Colour", "Size" });
            dog.Fields = dogfields;

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
    }
}
