using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;

namespace MyfirstWebAPI.Controllers
{
    public class Home2Controller : ApiController
    {
        // GET: Home2
        
            private string[] S = {"apple", "Banana", "Orange" };
            public string[] Get()
        {
            return S;
        }

        // ...api/home/{id}
        public string Get(int id)
        {
            return S[id];
        }

        
    }
}