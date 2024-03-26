using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TangerEco.Models
{
    public class PersonnelUniversiteModel:IdentityUser
    {
        public String Name { get; set; } = "";
        public String University { get; set; } = "";
        public String Poste { get; set; } = "";

        public PersonnelUniversiteModel() { }

    }
}
