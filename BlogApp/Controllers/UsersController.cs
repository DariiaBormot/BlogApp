using AutoMapper;
using BlogApp.Helpers;
using BlogApp.Models;
using BlogBL.Interfaces;
using BlogBL.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.IO;
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

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewAll()
        {
            var usersBL = _service.GetAll();
            var usersPL = _mapper.Map<IEnumerable<UserViewModel>>(usersBL);

            return View(usersPL);
        }


        public ActionResult Details(int id)
        {
            var usersBL = _service.GetById(id);
            var usersPL = _mapper.Map<UserViewModel>(usersBL);
            return View(usersPL);
        }


        public ActionResult Create()
        {
            var newUser = new UserViewModel();
            return View(newUser);
        }


        [HttpPost]
        public ActionResult Create(UserViewModel user)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(user);
                }
                if (user.ImageUpload != null)
                {
                    var fileName = Path.GetFileNameWithoutExtension(user.ImageUpload.FileName);
                    var extension = Path.GetExtension(user.ImageUpload.FileName);
                    fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    user.Avatar = "~/assets/uploadImages/" + fileName;
                    user.ImageUpload.SaveAs(Path.Combine(Server.MapPath("~/assets/uploadImages/"), fileName));
                }

                var modelBL = _mapper.Map<UserBL>(user);
                _service.Create(modelBL);

                var users = _service.GetAll();
                var usersPL = _mapper.Map<IEnumerable<UserViewModel>>(users);

                return Json(new { success = true, html = RenderRazorViewToHtml.RenderRazorViewToString(this, "ViewAll", usersPL), message = "Submitted Successfully " }, JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }


        public ActionResult Edit(int id)
        {
            var userToEdit = _service.GetById(id);
            var userPL = _mapper.Map<UserViewModel>(userToEdit);
            return View(userPL);
        }


        [HttpPost]
        public ActionResult Edit(UserViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var modelBL = _mapper.Map<UserBL>(model);
            _service.Update(modelBL);

            var users = _service.GetAll();
            var usersPL = _mapper.Map<IEnumerable<UserViewModel>>(users);

            return Json(new { success = true, html = RenderRazorViewToHtml.RenderRazorViewToString(this, "ViewAll", usersPL), message = "Edited Successfully " }, JsonRequestBehavior.AllowGet);

        }


        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                _service.Delete(id);
                var users = _service.GetAll();
                var usersPL = _mapper.Map<IEnumerable<UserViewModel>>(users);
                return Json(new { success = true, html = RenderRazorViewToHtml.RenderRazorViewToString(this, "ViewAll", usersPL), message = "Deleted Successfully " }, JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }

        }
    }
}
