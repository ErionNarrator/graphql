using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class Kid
    {
        [Key] public long KidId { get; set; }
        public string KidName { get; set; }
        public int KidMoney {  get; set; }
        public ICollection<Group>? Groups{ get; set; }
    }
}
