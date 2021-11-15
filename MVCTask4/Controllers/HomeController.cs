using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyDataBase.DBOperations;
using MyModels;

namespace MVCTask4.Controllers
{
    public class HomeController : Controller
    {
        StudentRepository repository = null;
        public HomeController()
        {
            repository = new StudentRepository();
        }
        // GET: Home
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentModel model)
        {
            if(ModelState.IsValid)
            {
                int id = repository.AddStudent(model);
                 if (id > 0)
                {
                    ModelState.Clear();
                    ViewBag.issuccess = "Data Added";
                }
            }
            return View();
        }
    }
}