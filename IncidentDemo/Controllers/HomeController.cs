using IncidentDemo.Models;
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

        public void Delete(Incident incident)
        {
            RedirectToAction("Index");
        }
    }
}