using Business;
using BusinessTests;
using Data;

namespace TestingConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            //CreateCategoriesAndDogRecord();
            //CreateAeroplaneRecord();
            //EditRecord();
        }

        private static void EditRecord()
        {
            LiteDBWrapper dbwrapper = new LiteDBWrapper();
            RecordManager recordManager = new RecordManager(dbwrapper);
            var records = recordManager.GetAll();

            Record editRecord = records[0];
            editRecord.Entries["Size"] = "Massive";
            recordManager.Edit(editRecord);
        }

        private static void CreateAeroplaneRecord()
        {
            LiteDBWrapper dbwrapper = new LiteDBWrapper();
            CategoryManager categoryManager = new CategoryManager(dbwrapper);
            var categories = categoryManager.GetAll();

            Record record = new Record(categories[1]);
            record.AddEntry("Make", "Airbus");
            record.AddEntry("Model", "A380");
            record.AddEntry("Engine", "GE");
            RecordManager recordManager = new RecordManager(dbwrapper);
            recordManager.Create(record);
        }

        private static void CreateCategoriesAndDogRecord()
        {
            LiteDBWrapper dbwrapper = new LiteDBWrapper();
            CategoryManager categoryManager = new CategoryManager(dbwrapper);

            Category dog = TestsHelper.InitialiseDogCategory();
            categoryManager.Create(dog);

            Category aeroplane = TestsHelper.InitialiseAeroplaneCategory();
            categoryManager.Create(aeroplane);

            var categories = categoryManager.GetAll();

            Record record = new Record(dog);
            record.AddEntry("Breed", "Rottweiler");
            record.AddEntry("Colour", "Brown");
            record.AddEntry("Size", "Big");
            RecordManager recordManager = new RecordManager(dbwrapper);
            recordManager.Create(record);

            var records = recordManager.GetAll();

            var audits = dbwrapper.GetAuditRecords();
        }
    }
}
