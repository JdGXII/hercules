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
        public string Name { get; set; }

        [Display(Name = "Apellido")]
        public string Last_Name { get; set; }

        [Index(IsUnique = true)]
        [Display(Name = "Correo electrónico")]
        public string Email  { get; set; }

        [Index(IsUnique = true)]
        [Display(Name = "DNI")]
        public string DNI { get; set; }

        [Display(Name = "Teléfono")]
        public string Phone { get; set; }        
    }
}
