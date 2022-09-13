using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos
{
    public class FighterDto
    {
        public int? Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get;  set; }
        [Required]
        [MaxLength(30)]
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
