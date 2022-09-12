using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos
{
    public class FighterDto
    {
        [Required]
        [MaxLength(30)]
        public string Name { get;  set; }
        [Required]
        [MaxLength(20)]
        [MinLength(4)]
        public string NickName { get;  set; }
        [Required]
        [MinLength(2)]
        [MaxLength(11)]
        public string Cpf { get;  set; }
        [Required]
        public int WeightClass { get; set; }

    }
}
