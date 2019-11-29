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
     

        public Category Category { get; set; }     
        public File File { get; set; }     
        public Profile Uploader { get; set; }
    }
}
