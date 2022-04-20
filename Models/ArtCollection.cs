using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArtistWebsite.Models
{
    public class ArtCollection
    {
        [Key]
        [Required]
        [Column(Order =0, TypeName = "int")]
        public int ArtID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)",Order =1)]
        public string Name { get; set; }
        [Required]
        [Range(2000,2022)]
        [Column(Order =2)]
        public int Year { get; set; }
        [Required]
        [Column(TypeName = "decimal(6,2)",Order =3)]
        public decimal ArtPrice { get; set; }
        [Required]
        [Column(Order =3,TypeName ="int")]
        
        public int ArtistID { get; set; }
        [ForeignKey("ArtistID")]
        public Artists Artists { get; set; }
    }
}
