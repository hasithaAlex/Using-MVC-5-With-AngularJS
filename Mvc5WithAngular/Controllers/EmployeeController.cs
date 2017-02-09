using Mvc5WithAngular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Net;

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

        public ActionResult Create(EmployeeVM employee)
        {
            if (ModelState.IsValid)
            {
                return new HttpStatusCodeResult(HttpStatusCode.Created, "New Employee Added");
            }

            List<string> errors = new List<string>();
            errors.Add("Insert failed.");
            if (!ModelState.IsValidField("Name"))
                errors.Add("Name must be at least 5 characters long.");

            return new HttpStatusCodeResult(HttpStatusCode.InternalServerError, String.Join(" ",errors));
        }


        public ActionResult Update(EmployeeVM employee)
        {
            if (ModelState.IsValid)
            {
                return new HttpStatusCodeResult(HttpStatusCode.Created, "Update success");
            }

            List<string> errors = new List<string>();
            errors.Add("Insert failed.");
            if (!ModelState.IsValidField("Name"))
                errors.Add("Name must be at least 5 characters long.");

            return new HttpStatusCodeResult(HttpStatusCode.InternalServerError, String.Join(" ", errors));
        }
    }
}