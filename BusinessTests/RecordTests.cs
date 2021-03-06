﻿using System;
using Business;
using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessTests
{
    [TestClass]
    public class RecordTests
    {
        [TestMethod]
        public void DogRecordConstructorTest()
        {
            // arrange

            MockDatabase mockDatabase = new MockDatabase();
            Category dog = TestsHelper.InitialiseDogCategory();
            Category aeroplane = TestsHelper.InitialiseAeroplaneCategory();
            CategoryManager categoryManager = new CategoryManager(mockDatabase);
            categoryManager.Create(aeroplane);
            categoryManager.Create(dog);

            // act

            Record record = new Record(dog);

            // assert

            Assert.AreEqual("Dog", record.Category.Name);
            Assert.AreEqual(3, record.Entries.Count, "Incorrect entry count");
            Assert.IsTrue(record.Entries.ContainsKey("Breed"), "Incorrect Breed key");
            Assert.IsTrue(record.Entries.ContainsKey("Colour"), "Incorrect Colour key");
            Assert.IsTrue(record.Entries.ContainsKey("Size"), "Incorrect Size key");
        }

        [TestMethod]
        public void AeroplaneRecordConstructorTest()
        {
            // arrange

            MockDatabase mockDatabase = new MockDatabase();
            Category dog = TestsHelper.InitialiseDogCategory();
            Category aeroplane = TestsHelper.InitialiseAeroplaneCategory();
            CategoryManager categoryManager = new CategoryManager(mockDatabase);
            categoryManager.Create(aeroplane);
            categoryManager.Create(dog);

            // act

            Record record = new Record(aeroplane);

            // assert

            Assert.AreEqual("Aeroplane", record.Category.Name);
            Assert.AreEqual(3, record.Entries.Count, "Incorrect entry count");
            Assert.IsTrue(record.Entries.ContainsKey("Make"), "Incorrect Make key");
            Assert.IsTrue(record.Entries.ContainsKey("Model"), "Incorrect Model key");
            Assert.IsTrue(record.Entries.ContainsKey("Engine"), "Incorrect Engine key");
        }

        [TestMethod]
        public void DogRecordTest()
        {
            // arrange

            MockDatabase mockDatabase = new MockDatabase();
            Category dog = TestsHelper.InitialiseDogCategory();
            Category aeroplane = TestsHelper.InitialiseAeroplaneCategory();
            CategoryManager categoryManager = new CategoryManager(mockDatabase);
            categoryManager.Create(aeroplane);
            categoryManager.Create(dog);
            Record record = new Record(dog);

            // act

            record.Entries["Breed"] = "Cavalier King Charles Spaniel";
            record.Entries["Colour"] = "Black and White";
            record.Entries["Size"] = "Small";

            // assert
            Assert.AreEqual(3, record.Entries.Count, "Incorrect count");
            Assert.AreEqual("Cavalier King Charles Spaniel", record.Entries["Breed"], "Incorrect Breed");
            Assert.AreEqual("Black and White", record.Entries["Colour"], "Incorrect Colour");
            Assert.AreEqual("Small", record.Entries["Size"], "Incorrect Size");
        }

        [TestMethod]
        public void AeroplaneRecordTest()
        {
            // arrange

            MockDatabase mockDatabase = new MockDatabase();
            Category dog = TestsHelper.InitialiseDogCategory();
            Category aeroplane = TestsHelper.InitialiseAeroplaneCategory();
            CategoryManager categoryManager = new CategoryManager(mockDatabase);
            categoryManager.Create(aeroplane);
            categoryManager.Create(dog);
            Record record = new Record(aeroplane);

            // act

            record.Entries["Make"] = "Boeing";
            record.Entries["Model"] = "747";
            record.Entries["Engine"] = "Rolls Royce";

            // assert
            Assert.AreEqual(3, record.Entries.Count, "Incorrect count");
            Assert.AreEqual("Boeing", record.Entries["Make"], "Incorrect Make");
            Assert.AreEqual("747", record.Entries["Model"], "Incorrect Model");
            Assert.AreEqual("Rolls Royce", record.Entries["Engine"], "Incorrect Engine");
        }

        [TestMethod]
        public void DogRecordAddEntryTest()
        {
            // arrange

            MockDatabase mockDatabase = new MockDatabase();
            Category dog = TestsHelper.InitialiseDogCategory();
            Category aeroplane = TestsHelper.InitialiseAeroplaneCategory();
            CategoryManager categoryManager = new CategoryManager(mockDatabase);
            categoryManager.Create(aeroplane);
            categoryManager.Create(dog);
            Record record = new Record(dog);

            // act

            bool result = record.AddEntry("Breed", "German Shepherd");

            // assert

            Assert.IsTrue(result, "Breed not added");
            Assert.AreEqual("German Shepherd", record.Entries["Breed"], "Record entry not added correctly");
        }

        [TestMethod]
        public void AeroplaneRecordAddEntryTest()
        {
            // arrange

            MockDatabase mockDatabase = new MockDatabase();
            Category dog = TestsHelper.InitialiseDogCategory();
            Category aeroplane = TestsHelper.InitialiseAeroplaneCategory();
            CategoryManager categoryManager = new CategoryManager(mockDatabase);
            categoryManager.Create(aeroplane);
            categoryManager.Create(dog);
            Record record = new Record(aeroplane);

            // act

            bool result = record.AddEntry("Engine", "Rolls Royce");

            // assert

            Assert.IsTrue(result, "Engine not added");
            Assert.AreEqual("Rolls Royce", record.Entries["Engine"], "Record entry not added correctly");
        }

        [TestMethod]
        public void CheckAddingAeroplaneEntryToDogRecordFailsTest()
        {
            // arrange

            MockDatabase mockDatabase = new MockDatabase();
            Category dog = TestsHelper.InitialiseDogCategory();
            Category aeroplane = TestsHelper.InitialiseAeroplaneCategory();
            CategoryManager categoryManager = new CategoryManager(mockDatabase);
            categoryManager.Create(aeroplane);
            categoryManager.Create(dog);
            Record record = new Record(dog);

            // act

            bool result = record.AddEntry("Engine", "Rolls Royce");

            // assert

            Assert.IsFalse(result, "Added Engine to Dog!");
        }
    }
}
