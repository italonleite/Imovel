﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imovel.Domain.Models
{
    public class Address
    {
        public string street { get; set; }
        public string city { get; set; }
        public string complement { get; set; }
        public string district { get; set; }
        public string number { get; set; }
        public string state { get; set; }
        public string zip { get; set; }        
    }
}