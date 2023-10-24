using asp_NguyenVanBac.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp_NguyenVanBac.Models
{
    public class HomeModel
    {
        public List<Product> ListProducts { get; set; }
        public List<Category> ListCategory { get; set; }
    }
}