using GrannyEly.Models;
using GrannyEly.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GrannyEly.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RoomService _roomService;

        public HomeController(ILogger<HomeController> logger, RoomService roomService)
        {
            _logger = logger;
            _roomService = roomService;
        }

        public IActionResult Index()
        {
            var rooms = _roomService.GetAllRooms();
            return View(rooms);
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
}