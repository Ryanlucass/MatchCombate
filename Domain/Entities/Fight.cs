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
        [Column("Id")]
        public int Id { get; set; }
        [Required]
        [Column("Data")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(50)]
        [Column("Local")]
        public string Locale { get; set; }
        [StringLength(23)]
        [Column("Octogono")]
        public string Box { get; set; }
        //Relacionamento
        public List<Fighter> Fighters { get; set; }
    }
}


