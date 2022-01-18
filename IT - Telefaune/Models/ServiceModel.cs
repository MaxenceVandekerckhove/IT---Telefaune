using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IT___Telefaune.Models
{
    public class ServiceModel
    {
        [Key]
        public int ServiceId { get; set; }
        [DisplayName("Type de Service")][Required]
        public string TypeService { get; set; }


        public ICollection<SiteModel> Site { get; set; }
        public ICollection<SalarieModel> Salarie { get; set; }
    }
}
