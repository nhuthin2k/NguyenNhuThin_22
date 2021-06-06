using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NguyenNhuThin_22.Models;

namespace WebApplication3.Controllers
{
    [Authorize]
    public class NhaCungCapController : Controller
    {
        private LTQLDbcontext db = new LTQLDbcontext();

        // GET: NhaCungCap
        public ActionResult Index()
        {
            return View(db.NhaCungCaps.ToList());
        }

    }
}