﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Degree 
    {
        public int DegreeID { get; set; }
        public string DegreeAbbrev { get; set; }
        public string DegreeName { get; set; }
        public int NumberOfTerms { get; set; }
    }
}
