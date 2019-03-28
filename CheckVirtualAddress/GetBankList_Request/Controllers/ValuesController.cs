using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Hosting;
using GetBankList.DataAccess;
using GetBankList.Models;
using Newtonsoft.Json;

namespace GetBankList_Request.Controllers
{
    public class ValuesController : ApiController
    {


        // POST api/values
        [HttpPost]
        public HttpResponseMessage Post([FromBody] GetBankListRequest value)
        {
            var responseObject = new GetBankListResponse() { status = "s", bankMasterList = new Files().GetBanks() };
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, responseObject);
            string mystr = JsonConvert.SerializeObject(value);
            System.IO.File.WriteAllText(@"E:\jsonfiles\WriteLines.txt", mystr);          
            return response;
        }


    }
}
