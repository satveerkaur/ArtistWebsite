using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArtistWebsite.Models
{
    public class Events
    {
        [Key]
        [Required]
        [Column(Order = 0, TypeName = "int")]
        public int EventID { get; set; }
        
        [Required]
        [Column(TypeName = "nvarchar(50)", Order = 1)]
        public string EventName { get; set; }
        [Required]
        [Column(TypeName = "DateTime", Order = 2)]
        public DateTime Date { get; set; }
        [Required]
        [Column(TypeName = "decimal(4,2)", Order = 3)]
        public decimal TicketPrice { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(30)", Order = 4)]
        public string City { get; set; }
    }
}
