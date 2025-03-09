﻿using DesignPattern.Repository;
using Microsoft.AspNetCore.Mvc;
using Tools.Generator;

namespace DesignPatternAsp.Controllers
{
    public class GeneratorFileController : Controller
    {
        private IUnitOfWork _unitOfWork;

        private GeneratorConcreteBuilder _generatorConcreteBuilder;

        public GeneratorFileController(IUnitOfWork unitOfWork, GeneratorConcreteBuilder generatorConcreteBuilder)
        {
            _unitOfWork = unitOfWork;
            _generatorConcreteBuilder = generatorConcreteBuilder;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateFile(int optionFile)
        {
            try
            {
                var beers = _unitOfWork.Beers.Get();
                List<string> content = beers.Select(x => x.Name).ToList();

                string path = "file" + DateTime.Now.Ticks + new Random().Next(1, 1000) + ".txt";
                var generatorDirector = new GeneratorDirector(_generatorConcreteBuilder);

                if(optionFile == 1)
                {
                    generatorDirector.CreateSimpleJsonGenerator(content, path);
                }
                else
                {
                    generatorDirector.CreateSimplePipesGenerator(content, path);
                }

                var generator = _generatorConcreteBuilder.GetGenerator();  
                generator.Save();

                return Json(new { message = "File created successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
