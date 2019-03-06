using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;

namespace BusinessTests
{
    public class TestsHelper
    {
        public static Category InitialiseDogCategory()
        {
            Category dog = new Category("Dog");
            List<string> dogfields = new List<string>(new string[] { "Breed", "Colour", "Size" });
            dog.Fields = dogfields;
            return dog;
        }

        public static Category InitialiseAeroplaneCategory()
        {
            Category aeroplane = new Category("Aeroplane");
            List<string> aeroplanefields = new List<string>(new string[] { "Make", "Model", "Engine" });
            aeroplane.Fields = aeroplanefields;
            return aeroplane;
        }
    }
}
