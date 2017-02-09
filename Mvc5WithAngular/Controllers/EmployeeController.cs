using Mvc5WithAngular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mvc5WithAngular.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult GetEmployees()
        {
            List<EmployeeVM> list = new List<EmployeeVM>() {
                new EmployeeVM() { Name="Hasitha" },
                new EmployeeVM() { Name="Kavindu" },
                new EmployeeVM() { Name="Kasuni" }
            };

            var camelCaseFormatter = new JsonSerializerSettings();
            camelCaseFormatter.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var jsonResult = new ContentResult
            {
                Content = JsonConvert.SerializeObject(list,camelCaseFormatter),
                ContentType = "application/json"
            };
            return jsonResult;
        }

        public ActionResult Create(EmployeeVM employee) {
            return new HttpStatusCodeResult(201, "New Employee Added");
        }
    }
}