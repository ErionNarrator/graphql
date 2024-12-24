using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class Kid
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long KidId { get; set; }
        public string KidName { get; set; }
        public int KidMoney {  get; set; }

        public long GroupId { get; set; }
        public Group? Group { get; set; }
    }
}
