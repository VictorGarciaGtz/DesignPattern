using DesignPattern.Models.Data;
using DesignPattern.Repository;
using DesignPatternAsp.Configuration;
using DesignPatternAsp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using Tools;

namespace DesignPatternAsp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<MyConfig> _config;

        private readonly DesignPattern.Repository.IRepository<Beer> _repository;

        public HomeController(IOptions<MyConfig> config, IRepository<Beer> repository)
        {
            _config = config;
            _repository = repository;
        }

        public IActionResult Index()
        {
            Log.GetInstance(_config.Value.PathLog).Save("Home page index");

            IEnumerable<Beer> beers = _repository.Get();

            return View("Index", beers);
        }

        public IActionResult Privacy()
        {
            Log.GetInstance(_config.Value.PathLog).Save("Home page privacy");
            return View();
        }
    }
}
