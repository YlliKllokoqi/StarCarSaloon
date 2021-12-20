using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class GetCarDTO
    {
        public int id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Body { get; set; }
        public int Year { get; set; }
        public long Mileage { get; set; }
        public string FuelType { get; set; }
        public string Transmission { get; set; }
    }
}
