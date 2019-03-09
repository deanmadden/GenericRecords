﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using BusinessTests;
using Data;

namespace TestingConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            LiteDBWrapper dbwrapper = new LiteDBWrapper();
            CategoryManager categoryManager = new CategoryManager(dbwrapper);

            Category dog = TestsHelper.InitialiseDogCategory();
            //categoryManager.Create(dog);

            Category aeroplane = TestsHelper.InitialiseAeroplaneCategory();
            //categoryManager.Create(aeroplane);

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
