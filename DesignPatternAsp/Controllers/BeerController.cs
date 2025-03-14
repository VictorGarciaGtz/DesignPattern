﻿using DesignPattern.Models.Data;
using DesignPattern.Repository;
using DesignPatternAsp.Models.ViewModels;
using DesignPatternAsp.Strategies;
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
            GetBrandsData();
            return View();
        }

        [HttpPost]
        public IActionResult Add(FormBeerViewModel beerViewModel)
        {
            if (!ModelState.IsValid)
            {
                GetBrandsData();
                return View("Add", beerViewModel);
            }

            var context = beerViewModel.BrandId == null ? new BeerContext(new BeerWithBrandStrategy()) : new BeerContext(new BeerStrategy());
            context.Add(beerViewModel, _unitOfWork);

            return RedirectToAction("Index");
        }

        #region HELPER
        private void GetBrandsData()
        {
            var brand = _unitOfWork.Brands.Get();
            ViewBag.Brands = new SelectList(brand, "BrandId", "Name");
        }
        #endregion
    }
}
