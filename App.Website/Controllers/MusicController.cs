using App.Model.Model;
using App.Service.Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.Website.Controllers
{
    public class MusicController : Controller
    {
        IBaiHatService _bhService;

        public MusicController(IBaiHatService bhService)
        {
            this._bhService = bhService;
        }

        // GET: Music
        public ActionResult Index()
        {
            BaiHat viewModel = new BaiHat();

            viewModel = _bhService.GetSingleById(1);


            return View(viewModel);
        }

        // GET: Music/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }






        // GET: Music/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Music/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Music/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Music/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Music/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Music/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
