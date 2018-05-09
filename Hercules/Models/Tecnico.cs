using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hercules.Models
{
    public class Tecnico
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nombre del técnico")]
        public string Name { get; set; }

        [Display(Name = "Apellido del técnico")]
        public string Last_Name { get; set; }

        [Index(IsUnique = true)]
        [Display(Name = "Correo electrónico del técnico")]
        public string Email { get; set; }

        [Display(Name = "Teléfono del técnico")]
        public string Phone { get; set; }
    }
}
