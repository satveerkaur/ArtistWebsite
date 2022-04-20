using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArtistWebsite.Models
{
    public class Artists
    {
        [Key]
        [Required]
        [Column(Order =0, TypeName = "int")]
        public int ArtistID { get; set; }
        public ICollection<ArtCollection> ArtCollections { get; set; }
        public ICollection<ArtCourses> ArtCourses { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)",Order =1)]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(25)",Order =2)]
        public string PhoneNumber { get; set; }
        [Required]
        [Column(TypeName = "decimal(5,2)",Order =3)]
        public decimal HourlyRate { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(25)",Order =4)]
        public string City { get; set; }

        

    }
}
