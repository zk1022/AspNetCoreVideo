using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreVideo.Controllers
{
    // [Route("[controller]")]
    //[Route("company/[controller]")]
    [Route("company/[controller]/[action]")]
    public class EmployeeController:Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

       
        //public string Name()
        //{
        //    return "Jonas";
        //}

        public ContentResult Name()
        {
            return Content("Jonas");
        }

        public string Country()
        {
            return "Sweden";
        }
        public string Index()
        {
            return "Hello from Employee";
        }

    }
}