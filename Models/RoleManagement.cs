using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtistWebsite.Models
{
    public class RoleManagement
    {
        public IdentityRole Role{ get; set;}
        public ICollection<IdentityUser> Members{ get; set;}
        public IEnumerable<IdentityUser> NonMembers{ get; set; }
    }
}
