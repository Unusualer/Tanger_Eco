using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TangerEco.Models
{
    public class PersonnelMinistreModel:IdentityUser
    {
        public String Name { get; set; } = "";
        public string Ministry { get; set; } = "";
        public string Role { get; set; } = "";

        public PersonnelMinistreModel()
        {
        }
    }
}
