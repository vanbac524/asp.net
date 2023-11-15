using asp_NguyenVanBac.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp_NguyenVanBac.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        websiteBHEntities objwebsiteBHEntities = new websiteBHEntities();
        public ActionResult Index()
        {
            var listProduct = objwebsiteBHEntities.Products.ToList();

            return View(listProduct);
        }
    }
}