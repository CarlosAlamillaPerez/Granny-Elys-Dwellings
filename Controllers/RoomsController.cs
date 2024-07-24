using GrannyEly.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GrannyEly.Controllers
{
    public class RoomsController : Controller
    {

        private readonly RoomService _roomService;

        public RoomsController()
        {
            _roomService = new RoomService();
        }

        public IActionResult Index()
        {
            var rooms = _roomService.GetAllRooms();
            return View(rooms);
        }

        public IActionResult Details(int id)
        {
            var room = _roomService.GetRoom(id);
            if (room == null)
            {
                return NotFound();
            }
            return View(room);
        }
    }
}
