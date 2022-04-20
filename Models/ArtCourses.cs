using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ArtistWebsite.Models
{
    public class ArtCourses
    {
        [Key]
        [Required]
        [Column(Order = 0, TypeName = "int")]
        public int CourseID { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)", Order = 1)]
        public string CourseName { get; set; }
        [Required]
        
        [Column(Order = 2)]
        public int Duration { get; set; }
        [Required]
        [Column(TypeName = "decimal(5,2)", Order = 3)]
        public decimal Price { get; set; }
        [Required]
        [Column(Order = 3, TypeName = "int")]

        public int ArtistID { get; set; }
        [ForeignKey("ArtistID")]
        public Artists Artists { get; set; }
    }
}
