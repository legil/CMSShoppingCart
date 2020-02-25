using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMSShoppingCart.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace CMSShoppingCart.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PagesController : Controller
    {
        private readonly CMSShoppingCartContext context;

        public PagesController(CMSShoppingCartContext context)
        {
            this.context = context;
        }
        public string Index()
        {
            return "test";
        }
    }
}