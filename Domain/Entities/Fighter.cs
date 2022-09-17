using Domain.Validation;
using Newtonsoft.Json;
using System;
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
        [Column("Id")]
        public int Id { get; set; }
        [Column("Criado_em")]
        public DateTime? CreateAt { get; set; }
        [Column("Nome")]
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Column("Apelido")]
        [Required]
        [MaxLength(20)]
        [MinLength(4)]
        public string NickName { get; set;}
        [Column("Cpf")]
        [Required]
        [MinLength(2)]
        [MaxLength(11)]
        public string Cpf { get; set; }
        [Column("Peso")]
        [Required]
        [MaxLength(4)]
        [MinLength(2)]
        public int WeightClass { get; set; }
        [Column("LutaId")]
        public int? FightId { get; set; }
        
        //Relacionamento
        public Fight Fight { get; set; }

    }
}
