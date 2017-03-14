using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResearchUmbracoModelBuilder.Models;
using Umbraco.Web.Mvc;

namespace ResearchUmbracoModelBuilder.Controllers
{
    public class HomeController : RenderMvcController
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("HomePage", new Home(CurrentPage));
        }
    }
}