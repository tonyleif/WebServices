﻿using System.Web.Mvc;
using WebServices.Models;

namespace WebServices.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        //private ReservationRespository repo = ReservationRespository.Current;
        //public ViewResult Index()
        //{
        //    return View(repo.GetAll());
        //}

        //public ActionResult Add(Reservation item)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        repo.Add(item);
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        return View("View");
        //    }
        //}

        //public ActionResult Remove(int id)
        //{
        //    repo.Remove(id);
        //    return RedirectToAction("Index");
        //}

        //public ActionResult Update(Reservation item)
        //{
        //    if(ModelState.IsValid && repo.Update(item))
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        return View("Index");
        //    }
        //}
    }
}