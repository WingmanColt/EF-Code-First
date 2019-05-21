using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CodeFirtst.Models
{
    class DateFile
    {
  //      [Key]
        public int DateId { get; set; }

  //      [Key]
        public int FileId { get; set; }

        public virtual Date Date { get; set; }
        public virtual File File { get; set; }
    }
}
