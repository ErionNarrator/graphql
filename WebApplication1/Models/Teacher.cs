using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Teacher
    {
        [Key] public long TeacherId {  get; set; }
        public string TeacherName { get; set; }
        public ICollection<Group> Groups { get; set; }
        public ICollection<Service> Services { get; set; }

        
    }
}
