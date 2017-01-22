using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    public class ProjectController : Controller
    {
        // curs 6 exercitiu 2 
        public ActionResult DoAnAction()
        {
            return Content("Hello world!");
        }


        //curs 6 exercitiu 5 
        public ActionResult HelloAlpha(string alpha)
        {
             return Content("Hello "+ alpha);
        }

        //curs 6 exercitiu 6
        public ActionResult HelloUser(string name)
        {
           // return Content(("Hello:" + name));

         // curs 6 exercitiu 7 
           var encodedName = Server.HtmlEncode(name);
           return Content("Hello ", encodedName);
        }
    }
}