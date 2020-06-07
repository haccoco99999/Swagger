using DemoSwagger3.Models;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Data.Entity;
using System.Web.Mvc;

namespace DemoSwagger3.Controllers
{
    public class UsersController : ApiController
    {
        // GET api/<controller>
        private dbU_Entities databaseManager = new dbU_Entities();

        [System.Web.Http.HttpGet]
        [ResponseType(typeof(IEnumerable<User>))]
        public HttpResponseMessage AllUser()
        {
            List<User> listUser = databaseManager.Users.ToList();
            return Request.CreateResponse(HttpStatusCode.Created, listUser);
        }

        // GET api/<controller>/5
        [System.Web.Http.HttpGet]
        public string ID(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [System.Web.Http.HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        [System.Web.Http.HttpPut]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        [System.Web.Http.HttpDelete]
        public void Delete(int id)
        {
        }
    }
}