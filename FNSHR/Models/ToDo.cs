
using System;
using System.ComponentModel.DataAnnotations;

namespace FNSHR.Models
{
    public class toDo : IComparable
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Deadline { get; set; }

        [Required]
        public int pledgedPoints { get; set; }

        public int CompareTo(object obj)
        {
            if (obj is toDo task)
            {
                return String.Compare(this.Name, task.Name, StringComparison.Ordinal);
            }
            throw new ArgumentException("Object is not a Task");
        }
    }
}

