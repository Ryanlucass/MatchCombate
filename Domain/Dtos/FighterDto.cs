using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos
{
    public class FighterDto
    {
        public FighterDto(){UserId = Guid.Empty;}

        [Required]
        [MinLength(2)]
        [MaxLength(30, ErrorMessage = "O nome deve ter no máximo 30 caracteres")]
        public string Name { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Insira um apelido de no mínimo 2 caracteres")]
        [MaxLength(20, ErrorMessage = "O apelido deve ter no máximo 20 caracteres")]
        public string NickName { get; set; }
        [Required]
        [MinLength(11, ErrorMessage = "Insira um cpf válido")]
        [MaxLength(11, ErrorMessage = "Insira um cpf válido")]
        public string Cpf { get; set; }
        [Required]
        [Range(12.3, 270, ErrorMessage = "Insira um peso válido")]
        public int WeightClass { get; set; }
        public int? FightId { get; set; }
        [Required]

        public Guid UserId { get; set; } 
    }

    public class FighterDtoGet : FighterDto
    {
        [Required]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
    public class FighterDtoPatch
    {
        [MinLength(2, ErrorMessage = "Insira um nome maior que 2 caracteres")]
        [MaxLength(30)]
        public string Name { get; set; }
        [MinLength(5, ErrorMessage = "Insirua um apelido de no mínimo 2 caracteres")]
        [MaxLength(20)]
        public string NickName { get; set; }
        [MinLength(11)]
        [MaxLength(11)]
        public string Cpf { get; set; }
        public int WeightClass { get; set; }
        public int FightId { get; set; }
    }
}
