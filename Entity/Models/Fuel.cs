﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Models
{
    public class Fuel
    {
        [Key]
        public Guid Id { get; set; }

        public string FuelType { get; set; }
    }
}
