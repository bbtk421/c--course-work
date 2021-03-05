using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,insuree.Quote")] Insuree insuree)
        {
            if (string.IsNullOrEmpty(insuree.FirstName) || string.IsNullOrEmpty(insuree.LastName) || string.IsNullOrEmpty(insuree.EmailAddress)
                || string.IsNullOrEmpty(insuree.CarMake) || string.IsNullOrEmpty(insuree.CarModel))
			{
                return View("~/Views/Shared/Error.cshtml");
			}

            if (ModelState.IsValid)
            {
                
                using (InsuranceEntities db = new InsuranceEntities())
                {
                    var signup = new Insuree();
                    signup.FirstName = insuree.FirstName;
                    signup.LastName = insuree.LastName;
                    signup.EmailAddress = insuree.EmailAddress;
                    signup.DateOfBirth = insuree.DateOfBirth;
                    signup.CarYear = insuree.CarYear;
                    signup.CarMake = insuree.CarMake;
                    signup.CarModel = insuree.CarModel;
                    signup.SpeedingTickets = insuree.SpeedingTickets;
                    signup.DUI = insuree.DUI;
                    signup.CoverageType = insuree.CoverageType;
                    signup.Quote = insuree.Quote;

                    insuree.Quote = 50;
                    var today = DateTime.Today;
                    var age = today.Year - insuree.DateOfBirth.Year;
                    // age penalties
                    if (age <= 18)
                    {
                        insuree.Quote += 100;
                    }
                    else if (age >= 19 && age <= 25)
                    {
                        insuree.Quote += 50;
                    }
                    else if (age > 25)
                    {
                        insuree.Quote += 25;
                    }
                    // too old or too new    
                    if (insuree.CarYear < 2000)
                    {
                        insuree.Quote += 25;
                    }
                    else if (insuree.CarYear > 2015)
                    {
                        insuree.Quote += 25;
                    }
                    else
                    {
                    }
                    // Porsche penalties
                    if (insuree.CarMake == "Porsche")
                    {
                        insuree.Quote += 25;
                    }
                    if (insuree.CarModel == "911 Carrera")
                    {
                        insuree.Quote += 25;
                    }
                    // tickets & duis
                    if (insuree.SpeedingTickets > 0)
                    {
                        insuree.Quote += (insuree.SpeedingTickets * 10);
                    }
                    if (insuree.DUI == true)
                    {
                        insuree.Quote += (insuree.Quote * 25 / 100);
                    }
                    else
                    {
                    }
                    // full coverage?
                    if (insuree.CoverageType == true)
                    {
                        insuree.Quote += (insuree.Quote * 50 / 100);
                    }
                    else
                    {
                    }

                    signup.Quote = insuree.Quote;
                }
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,insuree.Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
