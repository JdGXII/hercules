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
        [StringLength(50), Required]
        public string Name { get; set; }

        [Display(Name = "Apellido del técnico")]
        [StringLength(50), Required]
        public string Last_Name { get; set; }

        [Index(IsUnique = true)]
        [Display(Name = "Correo electrónico del técnico")]
        [StringLength(50), Required]
        public string Email { get; set; }

        [Display(Name = "Teléfono del técnico")]
        [StringLength(50), Required]
        public string Phone { get; set; }
    }
}
