using Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Usuario")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        //CNPJ ou CPF
        [Required]
        [Column("Codigo")]
        [MinLength(11)]
        [MaxLength(11)]
        public string CodeId { get; set; }
        [Required]
        [MinLength(12)]
        [MaxLength(256)]
        public string Email { get; set; }
        //Nome próprio ou empresa
        [Required]
        [Column("Nome")]
        public string Name { get; set; }
        [Required]
        [MinLength(11)]
        [MaxLength(11)]
        [Column("Telefone")]
        public string Phone { get; set; }
        //Relacionamentos
        public List<Fighter> Fighters { get; set; }
    }
}
