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
    public class CommentsController : Controller
    {
        private ICommentService _service;

        private IMapper _mapper;

        public CommentsController(ICommentService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            var postsBL = _service.GetAll();
            var postsPL = _mapper.Map<IEnumerable<CommentViewModel>>(postsBL);
            return View(postsPL);
        }

        // GET: Post/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Post/Create
        [HttpPost]
        public ActionResult Create(CommentViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var modelBL = _mapper.Map<CommentBL>(model);
            _service.Create(modelBL);
            return RedirectToAction("Index");

        }

        // GET: Post/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Post/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, CommentViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var modelBL = _mapper.Map<CommentBL>(model);
            _service.Update(modelBL);
            return RedirectToAction("Index");

        }

        // GET: Post/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Post/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            _service.Delete(id);
            return RedirectToAction("Index");

        }
    }
}
