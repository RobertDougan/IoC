using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IoC.BusinessLogic.Concretes;
using IoC.Helpers;

namespace IoC.Controllers
{
    public class MailController : Controller
    {
        public ActionResult SendMail(string toAddress, string subject)
        {
            var mh = new MailHelper(new MailSender());
            var mailString = mh.SendMail(toAddress, subject);
            ViewBag.MailString = mailString;
            return View();
        }

        //
        // GET: /Mail/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Mail/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Mail/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Mail/Create

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

        //
        // GET: /Mail/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Mail/Edit/5

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

        //
        // GET: /Mail/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Mail/Delete/5

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
