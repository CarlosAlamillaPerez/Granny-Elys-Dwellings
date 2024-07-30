using GrannyEly.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GrannyEly.Controllers
{
    public class RoomsController : Controller
    {

        private readonly RoomService _roomService;

        public RoomsController(RoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public IActionResult Index(int status = 1)
        {
            var rooms = _roomService.GetAllRooms().Where(r => r.Status == status).ToList();
            ViewBag.CurrentStatus = status;
            return View(rooms);
        }

        [HttpGet]
        public IActionResult Detalles(int id, int status)
        {
            var room = _roomService.GetRoom(id);
            if (room == null)
            {
                return NotFound();
            }

            ViewBag.CurrentStatus = status;

            return View(room);
        }
    }
}
