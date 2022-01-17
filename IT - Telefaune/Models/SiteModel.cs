using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IT___Telefaune.Models
{
    public class SiteModel
    {
        [Key]
        public int SiteId { get; set; }
        [DisplayName("Nom")][Required]
        public string Nom { get; set; }
        [DisplayName("Ville")]
        [Required]
        public string Ville { get; set; }


        [DisplayName("Service")][Required]
        public string TypeService { get; set; }

    }

    public enum ServiceList
    {
        Test1,
        Test2
    }
}
