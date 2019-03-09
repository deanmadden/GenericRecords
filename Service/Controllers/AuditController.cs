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
    public class AuditController : ApiController
    {
        public IHttpActionResult Get()
        {
            LiteDBWrapper dbWrapper = new LiteDBWrapper();
            var auditRecords = dbWrapper.GetAuditRecords();
            var json = Json(auditRecords);
            return json;
        }
    }
}
