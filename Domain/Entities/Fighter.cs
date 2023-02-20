using Domain.Entities;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model
{
    public class Fighter
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Uid { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string NickName { get; set;}
        [MinLength(11)]
        [MaxLength(14)]
        public string CodeId { get; set; }
        [Required]
        public int WeightClass { get; set; }
    }
}
