using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hercules.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [StringLength(50), Required]
        public string Name { get; set; }

        [Display(Name = "Apellido")]
        [StringLength(50), Required]
        public string Last_Name { get; set; }

        [Index(IsUnique = true)]
        [StringLength(100), Required]
        [Display(Name = "Correo electrónico")]
        public string Email  { get; set; }

        [Index(IsUnique = true)]
        [StringLength(10), Required]
        [Display(Name = "DNI")]
        public string DNI { get; set; }

        [Display(Name = "Teléfono")]
        [StringLength(50), Required]
        public string Phone { get; set; }        
    }
}
