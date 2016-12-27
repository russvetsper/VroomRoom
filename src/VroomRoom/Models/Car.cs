using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VroomRoom.Models
{

    [Table("Cars")]
    public class Car 
    {
        [Key]
        public int CarId { get; set; }
        public string Img { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Engine { get; set; }
        public int Horsepower { get; set; }
        public int Torque { get; set; }
        public int TopSpeed { get; set; }
        public string QuarterMileStats  { get; set; }
        public string Price { get; set; }


    }
}
