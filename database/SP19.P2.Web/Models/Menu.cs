﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SP19.P2.Web.Models
{
    public class Menu
    {
        [Key]
        public string Name { get; set; }
        public MenuItem MenuItem { get; set; }
    }
}
