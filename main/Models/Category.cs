﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webProje.Models
{
    public class Category
    {
        [Key] 
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
