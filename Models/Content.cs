using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TestDatabase.Models;

namespace TestDatabase
{
    public class Content
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public Category Category { get; set; }
        [Required]
        public File File { get; set; }
        //WTF IS THIS
        public Profile Upload { get; set; }// WTF
    }
}
