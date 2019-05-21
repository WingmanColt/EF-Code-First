using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace CodeFirtst.Models
{
   public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public virtual ICollection<File> Files { get; set; }
    }
}
