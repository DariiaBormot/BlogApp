using AutoMapper;
using BlogApp.Models;
using BlogBL.Interfaces;
using BlogBL.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    public class PostController : Controller
    {
        private IPostService _service;

        private IMapper _mapper;

        public PostController(IPostService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            var postsBL = _service.GetAll().ToList();
            var mapedPosts = _mapper.Map<IEnumerable<PostViewModel>>(postsBL);
            return View(mapedPosts);
        }

        public ActionResult Details(int id)
        {
            var modelBL = _service.GetById(id);
            var viewModel = _mapper.Map<PostViewModel>(modelBL);
            return View(viewModel);
        }

        // GET: Post/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Post/Create
        [HttpPost]
        public ActionResult Create(PostViewModel model)
        {
            try
            {
                var modelBL = _mapper.Map<PostModel>(model);
                _service.Create(modelBL);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Post/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Post/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, PostViewModel model)
        {
            try
            {
                var modelBL = _mapper.Map<PostModel>(model);
                _service.Update(modelBL);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
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
            try
            {

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
