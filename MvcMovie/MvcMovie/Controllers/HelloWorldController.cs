using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public String Index()
        {
            return "This is my <b>default<b> action...";
        }

        public String Welcome(String name, int id = 1)
        {
            return HttpUtility.HtmlEncode(String.Format("Welcome {0}, ID is:{1}",name,id));
        }
    }
}