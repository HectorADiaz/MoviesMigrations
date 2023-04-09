using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMovies.Domain
{
    public class Country  
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? IdCountry { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(3)]
        public string Code { get; set; }
        public string Codex { get; set; }

        public Country()
        {
            IdCountry = null;
            CreationDate = DateTime.UtcNow;
            IsActive = true;
        }
    }
}
