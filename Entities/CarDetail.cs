using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CarDetail:BaseModel
    {
        public required string BaseImage  { get; set; }
        public required string Description { get; set; }
        public required string CarColor { get; set; }
        public required string Price { get; set; }
        public required string MinPrice { get; set; } //Kapora

        public required string Garage { get; set; }
        public bool Ornamet { get; set; }

        public required string  Oil { get; set; }
        public required string Service { get; set; }

        public string? Image2 { get; set; }
        public string? Image3{ get; set; }
        public string? Image4 { get; set; }
        public string? Image5 { get; set; }

    }
}
