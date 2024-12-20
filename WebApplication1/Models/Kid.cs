using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class Kid
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; } 
        public int Money { get; set; }
        public ICollection<Kid> Kids{ get; set; }
        public Kid()
        {
            Id = Guid.NewGuid();
            
        }
    }
}
