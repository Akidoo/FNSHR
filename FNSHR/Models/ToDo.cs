
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace FNSHR.Models
{
    public class toDo
    {
        
        public int Id { get; set; }

        public string Name { get; set; }

        public string Deadline { get; set; }

        public int pledgedPoints { get; set; }
    }

   
}
