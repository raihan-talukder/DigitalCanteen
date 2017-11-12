using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DigitalCanteen.Models;
using DigitalCanteen.Data;
using DigitalCanteen.Models.Entities;

namespace DigitalCanteen.Controllers
{
    public class HomeController : Controller
    {
        private DataContext _context;
        //
        // GET: /Home/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            if (Session["USER"] != null)
            {
                return RedirectToAction("Index", "User");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Login(UserCredential model)
        {

            if (ModelState.IsValid)
            {
                _context = new DataContext();

                var logger = _context.UserDetails.Include("UserCredential").FirstOrDefault(c =>
                                c.UserCredential.Username == model.Username &&
                                c.UserCredential.Password == model.Password);

                if (logger != null)
                {
                    if (logger.UserCredential.UserType == 0)
                    {
                        Session["USER"] = logger;
                        return RedirectToAction("Index", "User");
                    }
                    else
                    {
                        Session["USER"] = logger;
                        return RedirectToAction("UserIndex", "User");
                    }


                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        [HttpGet]
        public ActionResult LogOff()
        {
            Session.Clear();
            return RedirectToAction("Login", "Home");
        }


    }
}
