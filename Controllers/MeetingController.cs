using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MeetingApp.Models;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        private readonly ILogger<MeetingController> _logger;

        public MeetingController(ILogger<MeetingController> logger)
        {
            _logger = logger;
        }
 
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            Repository.addUser(model);
            ViewBag.UserCount = Repository.getUsers.Where(i => i.WillAttend == true).Count();
            return View("Thanks", model);
        }

        [HttpGet]
        public IActionResult List()
        {
            return View(Repository.getUsers);
        }
        
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}