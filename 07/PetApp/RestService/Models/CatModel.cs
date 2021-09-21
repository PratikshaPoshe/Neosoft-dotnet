﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestService.Models
{
    public class CatModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime? Dob { get; set; }
        public decimal? legLength { get; set; }
        public decimal? ribCage { get; set; }
        public string CatType { get; set; }
        public string FurType { get; set; }
    }
}