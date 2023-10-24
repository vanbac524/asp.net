using asp_NguyenVanBac.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp_NguyenVanBac.Controllers
{
    public class ProductController : Controller
    {
        websiteBHEntities objwebsiteBHEntities = new websiteBHEntities();
        // GET: Product
        public ActionResult Detail(int Id)
        {
            var objProduct = objwebsiteBHEntities.Products.Where(n => n.Id == Id).FirstOrDefault();
            return View(objProduct);
        }
    }
}
