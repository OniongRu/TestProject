using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TeledocTest.DBInteraction;
using TeledocTest.interfaces;
using TeledocTest.Models;

namespace TeledocTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAllClients _allClients;
        public HomeController(ILogger<HomeController> logger,IAllClients iAllClients)
        {
            _allClients = iAllClients;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {

            List<Client> c = _allClients.Clients.Where(c => c.Id == 3).ToList();
      


                
            Founder f = new Founder()
            {
                TIN = "memers1213",
                Name = "memer",
                Surname = "cool",
                Patronymic = "Masssa",
                AddingDate = DateTime.Now,
                ChangingDate = DateTime.Today,
                Client = c[0]
            };
            _allClients.AddFounder(f);
            return View();
        }
        
    }
}