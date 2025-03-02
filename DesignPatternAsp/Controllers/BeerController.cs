using DesignPattern.Models.Data;
using DesignPattern.Repository;
using DesignPatternAsp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DesignPatternAsp.Controllers
{
    public class BeerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public BeerController(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<BeerViewModel> beers = _unitOfWork.Beers.Get().Select(x => new BeerViewModel { Id = x.BeerId, Name = x.Name });
            return View("Index", beers);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var brand = _unitOfWork.Brands.Get();
            ViewBag.Brands = new SelectList(brand, "BrandId", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Add(FormBeerViewModel beerViewModel)
        {
            if (!ModelState.IsValid)
            {
                var brand = _unitOfWork.Brands.Get();
                ViewBag.Brands = new SelectList(brand, "BrandId", "Name");
                return View("Add", beerViewModel);
            }

            var beer = new Beer
            {
                Name = beerViewModel.Name
            };

            if(beerViewModel.BrandId.HasValue)
            {
                beer.BrandId = beerViewModel.BrandId;
            }
            else
            {
                var brand = new Brand
                {
                    BrandId = System.Guid.NewGuid(),
                    Name = beerViewModel.OtherBrand
                };
                beer .BrandId = brand.BrandId;
                _unitOfWork.Brands.Add(brand);               
            }

            _unitOfWork.Beers.Add(beer);
            _unitOfWork.Save();

            return RedirectToAction("Index");
        }
    }
}
