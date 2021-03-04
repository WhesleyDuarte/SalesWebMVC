using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SalesWebMVC.Services;

namespace SalesWebMVC.Controllers
{
    //Views deve ter o mesmo nome da classe, exemplo: SellersController -> Sellers (deve ser descosiderado o nome Controller)
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
    }
}
