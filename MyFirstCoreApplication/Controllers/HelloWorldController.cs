using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstCoreLibrary;

namespace MyFirstCoreApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {

        [HttpGet("message")]
        public string Message()
        {
            var obj = new Class1();
            return obj.Message();
        }

        [HttpGet("message/{name}")]
        public string Message(string name)
        {
            return "Hello world!!! Hello " + name;
        }
    }
}