using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvYeni.Models.Entity;
using MvcCvYeni.Repositories;

namespace MvcCvYeni.Controllers
{
    public class HobilerController : Controller
    {
        // GET: Hobiler
        GenericRepository<TblHobilerim> repo = new GenericRepository<TblHobilerim>();

        [HttpGet]
        public ActionResult Index()
        {
            var hobiler = repo.List();
            return View(hobiler);
        }
    }
    
    
}