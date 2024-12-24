using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Group
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long GroupId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public long TeacherId { get; set; }
        public Teacher? Teachers { get; set; }
        public ICollection<Kid>? Kids { get; set; }
        public ICollection<Service> Services { get; set; }



    }
}
