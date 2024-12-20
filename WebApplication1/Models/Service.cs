using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Service
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Сost { get; set; }

        [ForeignKey("Teacher")]
        public Guid TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public Service()
        {
            Id = Guid.NewGuid();
        }


    }
}
