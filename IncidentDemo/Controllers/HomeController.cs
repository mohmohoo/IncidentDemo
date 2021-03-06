﻿using IncidentDemo.Models;
using IncidentDemo.Repository;
using System.Web.Mvc;

namespace IncidentDemo.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<Incident> _repository;

        public HomeController(IRepository<Incident> repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            return View(_repository.List().Output);
        }

        public ActionResult List()
        {
            return View("Index", _repository.List().Output);
        }

        public ActionResult Delete(Incident incident)
        {
            _repository.Delete(incident);
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(Incident incident)
        {
            _repository.Create(incident);
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var incidentGetResult = _repository.Get(id);
            return View(incidentGetResult.Output);
        }

        [HttpPost]
        public ActionResult Update(Incident incident)
        {
            _repository.Update(incident);
            return RedirectToAction("List");
        }
    }
}