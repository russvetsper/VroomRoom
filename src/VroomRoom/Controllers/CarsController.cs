using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VroomRoom.Models;



namespace VroomRoom.Controllers
{
    public class CarsController : Controller
    {
        private VroomRoomDbContext db = new VroomRoomDbContext();
        public IActionResult Index()
        {
            return View(db.Cars.ToList());
        }

        public IActionResult Details(int id)
        {
            var thisCar = db.Cars.FirstOrDefault(cars => cars.CarId == id);
            return View(thisCar);
        }
    }
}
