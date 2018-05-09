using System.ComponentModel.DataAnnotations;

namespace Hercules.Models
{
    public class Foto
    {
        [Key]        
        public int Id { get; set; }

        public string Url { get; set; }

    }
}