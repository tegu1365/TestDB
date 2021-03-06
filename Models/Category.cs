﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TestDatabase.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CategoryName { get; set; }

        public ICollection<Content> Contents { get; set; }
    }
}
