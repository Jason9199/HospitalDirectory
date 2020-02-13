using System;
using System.Linq;
using System.Web.Mvc;
using HospitalDirectory.Models;

namespace HospitalDirectory.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new HospitalDirectoryContext())
            {
                var hospitals = context.Hospitals.ToList();
                return View(hospitals);
            }
        }

        public ActionResult Create()
        {
            return View();
        }
        
        public ActionResult Edit(int id)
        {
            using (var context = new HospitalDirectoryContext())
            {
                var hospital = context.Hospitals.Single(h => h.Id == id);
                return View(hospital);
            }
        }

        public ActionResult Delete(int id)
        {
            using (var context = new HospitalDirectoryContext())
            {
                var hospital = context.Hospitals.Single(h => h.Id == id);
                context.Hospitals.Remove(hospital);
                context.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }
        
        public ActionResult Save(Hospital hospital)
        {
            using (var context = new HospitalDirectoryContext())
            {
                if (hospital.Id == 0)
                {
                    hospital.CreatedOn = DateTime.Now;
                    context.Hospitals.Add(hospital);
                }
                else
                {
                    var hospitalInDb = context.Hospitals.Single(h => h.Id == hospital.Id);
                    hospitalInDb.Name = hospital.Name;
                    hospitalInDb.Street = hospital.Street;
                    hospitalInDb.City = hospital.City;
                    hospitalInDb.State = hospital.State;
                    hospitalInDb.ZipCode = hospital.ZipCode;
                    hospitalInDb.LastModified = DateTime.Now;
                }
                context.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }
    }
}