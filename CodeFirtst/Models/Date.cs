using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CodeFirtst.Models
{
    public class Date
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public DateTime SomeDate { get; set; }

        public virtual ICollection<File> Files { get; set; }
    }
}
