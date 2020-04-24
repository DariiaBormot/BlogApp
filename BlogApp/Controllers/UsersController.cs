using AutoMapper;
using BlogApp.Models;
using BlogBL.Interfaces;
using BlogBL.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService _service;
        private readonly IMapper _mapper;

        public UsersController(IUserService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public ActionResult Index(int? page)
        {
            var usersBL = _service.GetAll();
            var usersPL = _mapper.Map<IEnumerable<UserViewModel>>(usersBL);

            int pageSize = 4;
            int pageNumber = (page ?? 1);
            return View(usersPL.ToPagedList(pageNumber, pageSize));
        }


        public ActionResult Details(int id)
        {
            var usersBL = _service.GetById(id);
            var usersPL = _mapper.Map<UserViewModel>(usersBL);
            return View(usersPL);
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(UserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var modelBL = _mapper.Map<UserBL>(model);
            _service.Create(modelBL);
            return RedirectToAction("Index");

        }


        public ActionResult Edit(int id)
        {
            return View();
        }


        [HttpPost]
        public ActionResult Edit(int id, UserViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var modelBL = _mapper.Map<UserBL>(model);
            _service.Update(modelBL);
            return RedirectToAction("Index");

        }

 
        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            _service.Delete(id);
            return RedirectToAction("Index");

        }
    }
}
