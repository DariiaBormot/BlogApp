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
    public class TagsController : Controller
    {
        private ITagService _service;

        private IMapper _mapper;

        public TagsController(ITagService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            var categoriesBL = _service.GetAll().ToList();
            var categoriesPL = _mapper.Map<IEnumerable<TagViewModel>>(categoriesBL);
            return View(categoriesPL);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(TagViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var modelBL = _mapper.Map<TagBL>(model);
            _service.Create(modelBL);
            return RedirectToAction("Index");

        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, TagViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var modelBL = _mapper.Map<TagBL>(model);
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
