﻿using System;
using System.Collections.Generic;
using System.Web.Http;

namespace LincolnHammed.Controllers.API
{
   
    public class SuppliersController : ApiController
    {
        // GET: api/Suppliers
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Suppliers/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Suppliers
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Suppliers/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Suppliers/5
        public void Delete(int id)
        {
        }
    }
}
