﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_MutluArdaBetülRezervasyonApp.Entities.Abstractions;

namespace YB_MutluArdaBetülRezervasyonApp.Entities.Models
{
    public class Room : BaseEntity
    {
        public Guid HotelID { get; set; }
        public Hotel? Hotel { get; set; }
        public Guid TypeID { get; set; }
        public RoomType? RoomType { get; set; }
        public string? Status { get; set; }
    }
}
