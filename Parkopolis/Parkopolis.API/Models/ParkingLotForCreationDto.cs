﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parkopolis.API.Models
{
    public class ParkingLotForCreationDto
    {
        public int AreaId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public bool IsPaid { get; set; }
        public bool IsStateOwned { get; set; }
        public int TotalParkingSpaces { get; set; }
        public bool HasSecurity { get; set; }
        //public string Owner { get; set; }
        //public DateTime FreeInterval { get; set; }
    }
}
