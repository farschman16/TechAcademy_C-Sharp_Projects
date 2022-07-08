﻿using CarInsurance.Models;
using CarInsurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insurees = db.Insurees;
                var insureeVms = new List<InsureeVm>();
                foreach (var insuree in insureeVms)
                {
                    var insureeVm = new InsureeVm();
                    insureeVm.Id = insuree.Id;
                    insureeVm.FirstName = insuree.FirstName;
                    insureeVm.LastName = insuree.LastName;
                    insureeVm.EmailAddress = insuree.EmailAddress;
                    insureeVm.Quote = insuree.Quote;
                    insureeVms.Add(insureeVm);
                }
                return View(insureeVms);
            }
               
        }
    }
}