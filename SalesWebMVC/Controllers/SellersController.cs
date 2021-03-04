using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Controllers
{
    //Views deve ter o mesmo nome da classe, exemplo: SellersController -> Sellers (deve ser descosiderado o nome Controller)
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
