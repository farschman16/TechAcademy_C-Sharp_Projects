﻿using System;
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

        //separate method for calculating age unnecessary, commented for reference
        //public static int GetAge(DateTime birthDate)
        //{
        //    using (InsuranceEntities db = new InsuranceEntities())
        //    {
        //        DateTime n = DateTime.Now;
        //        DateTime birthDate = Convert.ToDateTime(Insuree.DateOfBirth);
        //        int age = n.Year - birthDate.Year;

        //        if (n.Month < birthDate.Month || (n.Month == birthDate.Month && n.Day < birthDate.Day))
        //            age--;

        //        return age;
        //    }
            
        //}
        public static int CalcRate(double Quote, Insuree insuree)
        {
            int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
            using (InsuranceEntities db = new InsuranceEntities())
            {
                if (insuree.Id > 0)
                {
                    Quote += 50;
                }
                if (age >= 18)
                {
                    Quote = (Quote + 100);
                }
                if (age >= 19 && age <= 25)
                {
                    Quote = (Quote + 50);
                }
                if (age >= 26)
                {
                    Quote = (Quote + 25);
                }
                if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
                {
                    Quote = (Quote + 25);
                }
                if (insuree.CarMake == "Porsche" && insuree.CarModel != "911 Carrera")
                {
                    Quote = (Quote + 25);
                }
                if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
                {
                    Quote = (Quote + 50);
                }
                if (insuree.SpeedingTickets > 0)
                {
                    Quote = (Quote + (insuree.SpeedingTickets * 10));
                }
                if (insuree.DUI == true)
                {
                    Quote = (Quote) * (Convert.ToDouble(1.25));
                }
                if (insuree.CoverageType == true)
                {
                    Quote = (Quote) * (Convert.ToDouble(1.5));
                }
                return Convert.ToInt32(Quote);
            }
                
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = CalcRate((double)insuree.Quote, insuree);
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
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
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
