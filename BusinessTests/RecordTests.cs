using System;
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
            Assert.AreEqual("Breed", record.Entries.AllKeys[0], "Incorrect Breed key");
            Assert.AreEqual("Colour", record.Entries.AllKeys[1], "Incorrect Colour key");
            Assert.AreEqual("Size", record.Entries.AllKeys[2], "Incorrect Size key");
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
            Assert.AreEqual("Make", record.Entries.AllKeys[0], "Incorrect Make key");
            Assert.AreEqual("Model", record.Entries.AllKeys[1], "Incorrect Model key");
            Assert.AreEqual("Engine", record.Entries.AllKeys[2], "Incorrect Engine key");
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
    }
}
