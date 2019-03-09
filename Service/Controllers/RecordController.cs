using Business;
using Data;
using System.Web.Http;

namespace Service.Controllers
{
    public class RecordController : ApiController
    {
        public IHttpActionResult Get()
        {
            LiteDBWrapper dbWrapper = new LiteDBWrapper();
            RecordManager recordManager = new RecordManager(dbWrapper);

            var result = recordManager.GetAll();

            var json = Json(result);

            return json;
        }

        [HttpPost]
        public void Create(Record item)
        {
            LiteDBWrapper dbWrapper = new LiteDBWrapper();
            RecordManager recordManager = new RecordManager(dbWrapper);
            recordManager.Create(item);
        }

        [HttpPost]
        public void Edit(Record item)
        {
            LiteDBWrapper dbWrapper = new LiteDBWrapper();
            RecordManager recordManager = new RecordManager(dbWrapper);
            recordManager.Edit(item);
        }
    }
}
