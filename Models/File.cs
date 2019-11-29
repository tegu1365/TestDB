using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TestDatabase.Models
{
    public class File
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Path { get; set; }

        public int ContentId { get; set; }
        public Content Content { get; set; }
    }
}
