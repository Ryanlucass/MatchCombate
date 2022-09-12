using Domain.Validation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.Model
{
    [Table("Lutador")]
    public class Fighter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; private set; }
        [Column("criado_em")]
        public DateTime CreateAt { get; set; }
        [Column("nome")]
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Column("apelido")]
        [Required]
        [MaxLength(20)]
        [MinLength(4)]
        public string NickName { get; set;}
        [Column("cpf")]
        [Required]
        [MinLength(2)]
        [MaxLength(11)]
        public string Cpf { get; set; }
        [Column("peso")]
        [Required]
        [MaxLength(4)]
        [MinLength(2)]
        public int WeightClass { get; set; }

    }
}
