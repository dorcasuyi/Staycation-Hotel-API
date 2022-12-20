using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayCation.Hotel.Core.DTO
{
    public class DetailsDto
    {
        public byte NumberOfBedrooms { get; set; }
        public byte NumberOfLivingrooms { get; set; }
        public byte NumberOfBathrooms { get; set; }
        public int InternetSpeed { get; set; }
        public byte NumberOfAc { get; set; }
        public byte NumberOfRefrigerators { get; set; }
        public byte NumberOfTelevisions { get; set; }
    }
}
