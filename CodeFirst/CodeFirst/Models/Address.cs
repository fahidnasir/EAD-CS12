﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirst.Models
{
    public class Address
    {
        public int ID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public Student Student { get; set; }
    }
}
