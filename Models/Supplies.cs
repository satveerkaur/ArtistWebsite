using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArtistWebsite.Models
{
    public class Supplies
    {
        [Key]
        [Required]
        [Column(Order = 0, TypeName = "int")]
        public int SupplyID { get; set; }
        
        [Required]
        [Column(TypeName = "nvarchar(50)", Order = 1)]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(25)", Order = 2)]
        public string Type { get; set; }
        [Required]
        [Column(TypeName = "decimal(5,2)", Order = 3)]
        public decimal Price { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)", Order = 4)]
        public string Link { get; set; }



    }
}
