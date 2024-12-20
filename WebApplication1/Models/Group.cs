using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Group
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("KidId")]
        public Guid KidId { get; set; }
        public Kid? Kid { get; set; }

        public Group()
        {
            Id = Guid.NewGuid();
        }
    }
}
