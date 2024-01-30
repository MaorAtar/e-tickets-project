using eTicketsProject.Data;
using eTicketsProject.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace eTicketsProject.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allActors = await _service.GetAll();
            return View(allActors);
        }
    }
}
