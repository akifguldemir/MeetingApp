using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;

namespace MeetingApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["greeting"] = DateTime.Now.Hour > 12 ? "İyi Günler" : "Günaydın";
        ViewData["username"] = "Akif";

        var meetingInfo = new MeetingInfo() {
            Id = 1,
            Location = "İstanbul",
            Date = new DateTime(2024, 01, 20, 20, 0, 0),
            NumberOfPeople = 100
        };

        return View(meetingInfo);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
