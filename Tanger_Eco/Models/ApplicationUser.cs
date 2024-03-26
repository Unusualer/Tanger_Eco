using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Tanger_Eco.Models
{
    public class ApplicationUser:IdentityUser
    {
        public String Name { get; set; } = "";

    }
}
