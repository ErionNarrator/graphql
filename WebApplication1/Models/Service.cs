﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Service
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }

        public long GroupId { get; set; }
        public Group? Group { get; set; }
       


    }
}
