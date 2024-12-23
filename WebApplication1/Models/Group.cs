using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Group
    {

        [Key] public long GropId { get; set; }
         public string Name { get; set; } 
        public long KidId{ get; set; }
        public Kid? Kid { get; set; }
        public long TeacherId { get; set; }
        public Teacher? Teacher { get; set; }

    }
}
