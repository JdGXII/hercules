using Hercules.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hercules.Models
{
    public class Caso
    {
        [Key]
        [Display(Name = "Número de caso")]
        public int Id { get; set; }

        public User Usuario { get; set; }

        public Tecnico Tecnico { get; set; }

        public GeoLocation GeoLocation { get; set; }

        public ICollection<Foto> UrlFotos { get; set; }

        public eTipoDeProblemas Problema { get; set; }
    }
}
