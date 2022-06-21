using BusinessLayer2.Concreate;
using DataAccessLayer2.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Course_Second.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content


        ContentManager cm = new ContentManager(new EFContentDal());

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ContentByHeading(int id)
        {
            var contentvalues = cm.GetListByHeadingID(id);
            return View(contentvalues);
        }
    }
}