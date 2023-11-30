using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class SampleController : ApiController
    {
        public string Get()
        {
            return "Hello. This API run on .Net Framework 4.8";
        }
    }
}