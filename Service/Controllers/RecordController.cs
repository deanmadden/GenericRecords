using Business;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
    }
}
