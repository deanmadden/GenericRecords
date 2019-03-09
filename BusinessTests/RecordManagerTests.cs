using System;
using Business;
using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessTests
{
    [TestClass]
    public class RecordManagerTests
    {
        [TestMethod]
        public void CreateDogRecordTest()
        {
            // arrange

            MockDatabase mockDatabase = new MockDatabase();
            Category dog = TestsHelper.InitialiseDogCategory();
            CategoryManager categoryManager = new CategoryManager(mockDatabase);
            categoryManager.Create(dog);

            Record record = new Record(dog);
            record.AddEntry("Breed", "Rottweiler");
            record.AddEntry("Colour", "Brown");
            record.AddEntry("Size", "Big");
            RecordManager recordManager = new RecordManager(mockDatabase);

            // act

            recordManager.Create(record);

            // assert

            Assert.AreEqual("Dog", mockDatabase.Records[0].Category.Name, "Incorrect category");
            Assert.AreEqual("Brown", mockDatabase.Records[0].Entries["Colour"], "Incorrect colour");
            Assert.AreEqual("Rottweiler", mockDatabase.Records[0].Entries["Breed"], "Incorrect Breed");
            Assert.AreEqual("Big", mockDatabase.Records[0].Entries["Size"], "Incorrect Size");
        }

        [TestMethod]
        public void CreateAeroplaneRecordTest()
        {
            // arrange

            MockDatabase mockDatabase = new MockDatabase();
            Category aeroplane = TestsHelper.InitialiseAeroplaneCategory();
            CategoryManager categoryManager = new CategoryManager(mockDatabase);
            categoryManager.Create(aeroplane);

            Record record = new Record(aeroplane);
            record.AddEntry("Make", "Airbus");
            record.AddEntry("Model", "A380");
            record.AddEntry("Engine", "GE");
            RecordManager recordManager = new RecordManager(mockDatabase);

            // act

            recordManager.Create(record);

            // assert

            Assert.AreEqual("Aeroplane", mockDatabase.Records[0].Category.Name, "Incorrect category");
            Assert.AreEqual("Airbus", mockDatabase.Records[0].Entries["Make"], "Incorrect Make");
            Assert.AreEqual("A380", mockDatabase.Records[0].Entries["Model"], "Incorrect Model");
            Assert.AreEqual("GE", mockDatabase.Records[0].Entries["Engine"], "Incorrect Engine");
        }

        [TestMethod]
        public void GetAllRecordsTest()
        {
            // arrange

            MockDatabase mockDatabase = new MockDatabase();
            Category dog = TestsHelper.InitialiseDogCategory();
            CategoryManager categoryManager = new CategoryManager(mockDatabase);
            categoryManager.Create(dog);

            Record record = new Record(dog);
            record.AddEntry("Breed", "Rottweiler");
            record.AddEntry("Colour", "Brown");
            record.AddEntry("Size", "Big");

            Category aeroplane = TestsHelper.InitialiseAeroplaneCategory();
            categoryManager.Create(aeroplane);

            Record record2 = new Record(aeroplane);
            record2.AddEntry("Make", "Airbus");
            record2.AddEntry("Model", "A380");
            record2.AddEntry("Engine", "GE");

            RecordManager recordManager = new RecordManager(mockDatabase);
            recordManager.Create(record);
            recordManager.Create(record2);

            // act

            var result = recordManager.GetAll();

            // assert

            Assert.AreEqual(2, result.Count, "Incorrect number of records");
            Assert.AreEqual("Dog", result[0].Category.Name, "Incorrect category");
            Assert.AreEqual("Aeroplane", result[1].Category.Name, "Incorrect category");

            Assert.AreEqual("Brown", result[0].Entries["Colour"], "Incorrect colour");
            Assert.AreEqual("Rottweiler", result[0].Entries["Breed"], "Incorrect Breed");
            Assert.AreEqual("Big", result[0].Entries["Size"], "Incorrect Size");

            Assert.AreEqual("Airbus", result[1].Entries["Make"], "Incorrect Make");
            Assert.AreEqual("A380", result[1].Entries["Model"], "Incorrect Model");
            Assert.AreEqual("GE", result[1].Entries["Engine"], "Incorrect Engine");
        }

        [TestMethod]
        public void EditRecordTest()
        {
            // arrange

            MockDatabase mockDatabase = new MockDatabase();
            Category dog = TestsHelper.InitialiseDogCategory();
            CategoryManager categoryManager = new CategoryManager(mockDatabase);
            categoryManager.Create(dog);

            Record record = new Record(dog);
            record.AddEntry("Breed", "Rottweiler");
            record.AddEntry("Colour", "Brown");
            record.AddEntry("Size", "Big");

            Category aeroplane = TestsHelper.InitialiseAeroplaneCategory();
            categoryManager.Create(aeroplane);

            Record record2 = new Record(aeroplane);
            record2.AddEntry("Make", "Airbus");
            record2.AddEntry("Model", "A380");
            record2.AddEntry("Engine", "GE");

            RecordManager recordManager = new RecordManager(mockDatabase);
            recordManager.Create(record);
            recordManager.Create(record2);

            record.Id = 0;
            record.Entries["Colour"] = "Black";

            // act

            recordManager.Edit(record);

            // assert

            Assert.AreEqual("Dog", mockDatabase.Records[0].Category.Name, "Incorrect category");
            Assert.AreEqual("Black", mockDatabase.Records[0].Entries["Colour"], "Incorrect colour");
            Assert.AreEqual("Rottweiler", mockDatabase.Records[0].Entries["Breed"], "Incorrect Breed");
            Assert.AreEqual("Big", mockDatabase.Records[0].Entries["Size"], "Incorrect Size");
        }
    }
}
