using Mvc5WithAngular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mvc5WithAngular.Controllers
{
    public class EmployeeWebApiController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<EmployeeVM> Get()
        {
            List<EmployeeVM> list = new List<EmployeeVM>() {
                new EmployeeVM() { Name="Hasitha" },
                new EmployeeVM() { Name="Kavindu" },
                new EmployeeVM() { Name="Kasuni" }
            };
            return list;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public HttpResponseMessage Post([FromBody]EmployeeVM employee)
        {
            var responce = new HttpResponseMessage(HttpStatusCode.OK);
            responce.Content = new StringContent("0001");
            return responce;
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}