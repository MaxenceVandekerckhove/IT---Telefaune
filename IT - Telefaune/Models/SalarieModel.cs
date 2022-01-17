using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IT___Telefaune.Models
{
    public class SalarieModel
    {
        [Key]
        public int SalarieId { get; set; }
        [DisplayName("Nom")][Required]
        public string Nom { get; set; }
        [DisplayName("Prenom")][Required]
        public string Prenom { get; set; }
        [DisplayName("Téléphone Fixe")]
        public int TelephoneFixe { get; set; }
        [DisplayName("Téléphone portable")][Required]
        public int TelephonePortable { get; set; }
        [DisplayName("Adresse Email")][Required]
        public string Email { get; set; }



        [DisplayName("Type de Service")][Required]
        public string TypeService { get; set; }
        [DisplayName("Nom du Site")][Required]
        public string NomSite { get; set; }

    }
}
