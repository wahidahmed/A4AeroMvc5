using A4AeroTest_MVC5.Models;
using DAL.Entity;
using Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace A4AeroTest_MVC5.Controllers
{
    public class BusinessController : Controller
    {
        private readonly IService<BusinessEntity> repository;
        public BusinessController()
        {
            this.repository = new Service<BusinessEntity>();
        }
        // GET: Business
        public ActionResult Index(int? id)
        {
            if (id > 0)
            {
                ViewBag.id = id;
            }
            else
            {
                ViewBag.id = 0;
            }
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(BusinessViewModel model)
        {
            if (!ModelState.IsValid)
            {
         
                return View(model);
            }
            BusinessEntity entity = new BusinessEntity
            {
                Id = model.Id,
                Code = model.Code,
                Name = model.Name,
                Email = model.Email,
                Street = model.Street,
                City = model.City,
                State = model.State,
                Mobile = model.Mobile,
                Phone = model.Phone,
                Status = 1,
                Country=model.Country,
                Zip=model.Zip,
                Logo=model.Logo,
                ContactPerson=model.ContactPerson,
                ReferredBy=model.ReferredBy,
                Balance = model.Balance,
                LoginUrl = "",
                SMTPPort = 1,
                CreatedOnUtc = DateTime.UtcNow,
                UpdatedOnUtc = DateTime.UtcNow,
                Deleted = false
            };

            if (model.Id > 0)
            {
                repository.Update(entity);
            }
            else
            {
                repository.Insert(entity);
               
            }
            return RedirectToAction("List");
        }


        public ActionResult List()
        {
            return View();
        }

        public JsonResult GetAll()
        {
            var result = repository.Get();
            return Json(result,JsonRequestBehavior.AllowGet);
        }



        public JsonResult GetById(int id)
        {
            var result =repository.GetById(id);
            return Json(result,JsonRequestBehavior.AllowGet);
        }

        public JsonResult Delete(int id)
        {
            repository.Delete(id);
            return Json(true);
        }
    }
} 