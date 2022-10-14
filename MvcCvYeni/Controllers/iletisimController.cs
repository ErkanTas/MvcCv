using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvYeni.Models.Entity;
using MvcCvYeni.Repositories;

namespace MvcCvYeni.Controllers
{
    public class iletisimController : Controller
    {
        // GET: iletisim

        GenericRepository<Tbliletisim> repo = new GenericRepository<Tbliletisim>();
        public ActionResult Index()
        {
            var mesajlar = repo.List();
            return View(mesajlar);
        }
    }
}