using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcajax.Models;

namespace mvcajax.Controllers
{
    public class CommentsController : Controller
    {
       public SampleEntities objent = new SampleEntities();
        // GET: Comments
        public ActionResult Index()
        {
            return View();
        }

        // GET: Comments/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Comments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Comments/Create
        [HttpPost]
        public ActionResult Create(Comment collection)
        {
            try
            {
                // TODO: Add insert logic here
                objent.Comments.Add(collection);
                objent.SaveChanges();
                List<Comment> list = new List<Comment>();
                if(Request.IsAjaxRequest())
                {
                   list = objent.Comments.ToList();


                    return View("LstC",list);
                }
                else
                {
                    return View(list);
                }
              
            }
            catch
            {
                return View();
            }
        }

        // GET: Comments/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Comments/Edit/5
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

        // GET: Comments/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Comments/Delete/5
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
