using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArtistWebsite.Models
{
    public class Role
    {
        [Required]
        [MaxLength(256)]
        public string RoleName { get; set; }
    }
}
