using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IT___Telefaune.Models
{
    public class SiteModel
    {
        [Key]
        public int SiteId { get; set; }
        [DisplayName("Nom")][Required]
        public string NomSite { get; set; }
        [DisplayName("Ville")]
        [Required]
        public string Ville { get; set; }
        public string TypeServiceWrong { get; set; }

        [ForeignKey("ServiceModel")]
        public int ServiceId { get; set; }
        public ServiceModel TypeService { get; set; }

        public ICollection<SalarieModel> Salarie { get; set; }
    }
}
