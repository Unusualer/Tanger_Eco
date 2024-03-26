using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tanger_Eco.Models;

namespace TangerEco.Models
{
    public class DemandeModel
    {
        [Key]
        public int DemandeModelId { get; set; }
        [Required]
        public string Title { get; set; } = "";
        [Required]
        public string  Description { get; set; } = "";
        [Required]
        public DateTime DateCreation { get; set; }
        [Required]
        public StatutDemande Statut { get; set; } = StatutDemande.EnAttente;

        [ForeignKey("DataCollector")]
        public String? DataCollectorModelId { get; set; }
        public ApplicationUser? DataCollector { get; set; }

        [ForeignKey("PersonnelMinistre")]
        public String? PersonnelMinistreId { get; set; }
        public PersonnelMinistreModel? PersonnelMinistre { get; set; }

        [ForeignKey("PersonnelUniversite")]
        public String? PersonnelUniversiteId { get; set; }
        public PersonnelUniversiteModel? PersonnelUniversite { get; set; }

        public enum StatutDemande
        {
            EnAttente,
            EnCours,
            Terminee
        }

        public DemandeModel() {
            DateCreation = DateTime.Now;
        }

    }
}
