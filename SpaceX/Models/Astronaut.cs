using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceX.Models
{
    [Table("Astronauts")]
    public class Astronaut
    {
        [Key]
        public int AstronautId { get; set; }
        public string Name { get; set; }
    }
}
