using AutoMapper;
using BlogApp.Models;
using BlogBL.Interfaces;
using BlogBL.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    public class PostsController : Controller
    {
        private IPostService _service;

        private IMapper _mapper;

        public PostsController(IPostService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public ActionResult Index(int page = 1)
        {
            int pageSize = 4;

            var postsBL = _service.GetAll();
            var postsPL = _mapper.Map<IEnumerable<PostViewModel>>(postsBL);

            var postsPerPage = postsPL.Skip((page - 1) * pageSize).Take(pageSize);
            var pageInfo = new PageInfo { PageNumber = page, ItemsOnPage = pageSize, TotalItems = postsPL.Count() };
            var paginationView = new BlogPostPaginationView { PageInfo = pageInfo, Posts = postsPerPage };

            return View(paginationView);
        }

        public ActionResult Details(int id)
        {
            var postsBL = _service.GetById(id);
            var postsPL = _mapper.Map<PostViewModel>(postsBL);
            return View(postsPL);
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

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var modelBL = _mapper.Map<BlogPostBL>(model);
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
        public ActionResult Edit(int id, PostViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var modelBL = _mapper.Map<BlogPostBL>(model);
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
