using System.Collections.Generic;
using System.Web.Http;
using Business;
using Data;

namespace Service.Controllers
{
    public class CategoryController : ApiController
    {
        public IHttpActionResult Get()
        {
            MockDatabase mockDatabase = new MockDatabase();

            Category dog = InitialiseDogCategory();
            Category aeroplane = InitialiseAeroplaneCategory();
            CategoryManager categoryManager = new CategoryManager(mockDatabase);
            categoryManager.Create(aeroplane);
            categoryManager.Create(dog);

            var result = categoryManager.GetAll();

            var json = Json(result);

            return json;
        }

        private static Category InitialiseDogCategory()
        {
            Category dog = new Category("Dog");
            List<string> dogfields = new List<string>(new string[] { "Breed", "Colour", "Size" });
            dog.Fields = dogfields;
            return dog;
        }

        private static Category InitialiseAeroplaneCategory()
        {
            Category aeroplane = new Category("Aeroplane");
            List<string> aeroplanefields = new List<string>(new string[] { "Make", "Model", "Engine" });
            aeroplane.Fields = aeroplanefields;
            return aeroplane;
        }
    }
}
