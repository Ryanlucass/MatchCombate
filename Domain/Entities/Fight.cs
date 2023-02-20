using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model
{
    [Table("Lutas")]
    public class Fight
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Uid { get; set; }
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
        [Required]
        [StringLength(50)]
        public string Locale { get; set; }
        [StringLength(23)]
        public string Box { get; set; }

    }
}


