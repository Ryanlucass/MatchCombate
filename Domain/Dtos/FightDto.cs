using Domain.Dtos.FighterDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos
{
    public class FightDto
    {
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "Digite uma localidade válida para a luta")]
        public string Locale { get; set; }
        [Required]
        [MinLength(1,ErrorMessage = "Insira um valor válido para o box dos lutadores")]
        public string Box { get; set; }

    }
    public class FightDtoGet : FightDto
    {
        [Required]
        public int Id { get; set; }
        public IEnumerable<FighterDtoGet> Fights { get; set; }
    }
    public class FightDtoPatch
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        [MinLength(5, ErrorMessage = "Digite uma localidade válida para a luta")]
        public string Box { get; set; }
        [MinLength(2, ErrorMessage = "Digite o nome de um box ou espaço para luta válido")]
        public string Locale { get; set; }
    }

}
