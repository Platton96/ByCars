﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class OwnerCar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string District { get; set; }
    }
}
