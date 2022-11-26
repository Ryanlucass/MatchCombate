using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Domain.Dtos
{
    public class FightDto
    {
        [Required(ErrorMessageResourceName = "MinDateTime")]
        public DateTime Date { get; set; }
        [Required(ErrorMessageResourceName = "StringLenght")]
        [MinLength(5)]
        public string Locale { get; set; }
        [Required(ErrorMessageResourceName = "StringLenght")]
        [MinLength(5)]
        public string Box { get; set; }
    }
    public class FightDtoGet : FightDto
    {
        [Required]
        public int Id { get; set; }
    }
    public class FightDtoPut
    {
        public DateTime Date { get; set; }
        public string Box { get; set; } 
        public string Locale { get; set; }
    }

}
