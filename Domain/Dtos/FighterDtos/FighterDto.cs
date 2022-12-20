using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos.FighterDtos
{
    public class FighterDto
    {
        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string NickName { get; set; }
        [Required]
        [MinLength(11)]
        [MaxLength(11)]
        public string Cpf { get; set; }
        [Required]
        [Range(12.3, 270, ErrorMessage = "Insira um peso válido")]
        public int WeightClass { get; set; }
        public int? FightId { get; set; }
    }

    public class FighterDtoGet : FighterDto
    {
        [Required]
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
    public class FighterDtoPatch
    {
        [MinLength(2, ErrorMessage ="Insira um nome maior que 2 caracteres")]
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
