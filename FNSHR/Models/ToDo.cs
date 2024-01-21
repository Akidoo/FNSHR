
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace FNSHR.Models
{
    public class toDo
    {
        
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Deadline { get; set; }

        [Required]
        public int pledgedPoints { get; set; }
    }

   
}
