using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Teacher
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Service> Service { get; set; }
        public Teacher()
        {
            Id = Guid.NewGuid();
        }
    }
}
