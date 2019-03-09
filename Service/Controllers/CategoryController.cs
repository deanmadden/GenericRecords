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
            LiteDBWrapper dBWrapper = new LiteDBWrapper();
            CategoryManager categoryManager = new CategoryManager(dBWrapper);

            var result = categoryManager.GetAll();

            var json = Json(result);

            return json;
        }
    }
}
