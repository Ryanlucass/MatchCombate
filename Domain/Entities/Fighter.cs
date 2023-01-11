using Domain.Entities;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Model
{
    [Table("Lutador")]
    public class Fighter
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("Criado_em")]
        public DateTime? CreateAt { get; set; } = DateTime.Now;
        [Column("Nome")]
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Column("Apelido")]
        [Required]
        [MaxLength(30)]
        [MinLength(3)]
        public string NickName { get; set;}
        [Column("Cpf")]
        [MinLength(11)]
        [MaxLength(11)]
        public string Cpf { get; set; }
        [Column("Peso")]
        [Required]
        public int WeightClass { get; set; }
        //Relacionamento
        [Column("LutaId")]
        public int? FightId { get; set; }
        [Column("UsuarioId")]
        public Guid UserId { get; set; }
        public Fight Fight { get; set; }
        public User User { get; set; }

    }
}
