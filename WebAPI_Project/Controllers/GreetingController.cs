using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    public class GreetingController : ApiController
    {
        public string Post()
        {
            return "Hello World!";
        }
        public string Get(int id)
        {
            return String.Format("Greetings to {0} people!", id);
        }
    }
}
