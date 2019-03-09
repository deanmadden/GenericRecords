using Business;
using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessTests
{
    [TestClass]
    public class AuditTests
    {
        [TestMethod]
        public void AuditCreateTest()
        {
            // arrange

            MockDatabase mockDatabase = new MockDatabase();
            Audit audit = new Audit(mockDatabase);

            Category dog = TestsHelper.InitialiseDogCategory();
            CategoryManager categoryManager = new CategoryManager(mockDatabase);
            categoryManager.Create(dog);

            Record record = new Record(dog);
            record.AddEntry("Breed", "Rottweiler");
            record.AddEntry("Colour", "Brown");
            record.AddEntry("Size", "Big");

            // act

            audit.Create(record);

            // assert
            Assert.AreEqual(1, mockDatabase.AuditLogs.Count, "Incorrect number of audit logs.");
            Assert.AreEqual("Added record type Dog, Breed=Rottweiler, Colour=Brown, Size=Big.", mockDatabase.AuditLogs[0].Message, "Incorrect audit message.");
        }
    }
}
