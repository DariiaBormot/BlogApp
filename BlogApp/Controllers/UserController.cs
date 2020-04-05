using AutoMapper;
using BlogApp.Models;
using BlogBL.Interfaces;
using BlogBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    public class UserController : Controller
    {
        private IUserService _service;

        private IMapper _mapper;

        public UserController(IUserService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        // GET: User
        public ActionResult Index()
        {
            var usersBL = _service.GetAll().ToList();
            var usersPL = _mapper.Map<IEnumerable<UserViewModel>>(usersBL);
            return View(usersPL);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            var modelBL = _service.GetById(id);
            var viewModel = _mapper.Map<UserViewModel>(modelBL);
            return View(viewModel);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(UserViewModel model)
        {
            try
            {
                var modelBL = _mapper.Map<UserModel>(model);
                _service.Create(modelBL);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, UserViewModel model)
        {
            try
            {
                var modelBL = _mapper.Map<UserModel>(model);
                _service.Update(modelBL);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                _service.Delete(id);
                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }
    }
}
