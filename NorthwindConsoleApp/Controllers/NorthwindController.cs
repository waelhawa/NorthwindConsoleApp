using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwindConsoleApp.Models;

namespace NorthwindConsoleApp.Controllers
{
    public class NorthwindController : Controller
    {
        private readonly NorthwindContext _context;

        public NorthwindController(NorthwindContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var customers = _context.Employees.ToList();
            return View(customers);
        }
    }
}
