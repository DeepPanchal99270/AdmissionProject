using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdmissionAdmin.Models;

namespace AdmissionAdmin.Controllers
{
    public class SaveDataController : Controller
    {
        // GET: SaveData
        public ActionResult Index()
        {
            ViewBag.saveresult = "";
            return View();
        }

        [HttpPost]
        public ActionResult Index(StudentData student)
        {
            using (collegedataEntities entities = new collegedataEntities())
            {
                entities.StudentDatas.Add(student);
                entities.SaveChanges();
                ViewBag.saveresult = "Data Has Been Saved Successfully";
                ModelState.Clear();
            }

            return View(new StudentData());
        }
    }
}