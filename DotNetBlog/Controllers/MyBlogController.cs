using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetBlog.Controllers
{
    public class MyBlogController : Controller
    {
        // GET: MyBlog
        public ActionResult Index()
        {
            return View();
        }
    }
}