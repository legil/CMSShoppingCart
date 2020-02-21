using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IRepository repository;

        public ProductsController(IRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {
            //return View(new Repository().Products);
            return View(repository.Products);
        }

        public IActionResult Create()
        {
            repository.AddProduct(new Product { Name = "Apples", Price = 1.50M });

            return RedirectToAction("Index");
        }

        public IActionResult Delete()
        {
            
            return RedirectToAction("Index");
        }
    }
}