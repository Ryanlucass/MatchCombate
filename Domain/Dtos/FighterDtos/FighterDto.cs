﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos.FighterDtos
{
    public class FighterDto
    {
        public DateTime CreateAt { get; set; }
        [Required]
        [MinLength(5)]
        public string Name { get; set; }
        [Required]
        [MinLength(5)]
        public string NickName { get; set; }
        [Required]
        [MinLength(11)]
        public string Cpf { get; set; }
        [Required]
        public int WeightClass { get; set; }
        public int? FightId { get; set; }
    }

    public class FighterDtoGet : FighterDto
    {
        [Required]
        public int Id { get; set; }
    }
    public class FighterDtoPatch
    {
        public DateTime CreateAt { get; set; }
        [MinLength(5)]
        public string Name { get; set; }
        [MinLength(5)]
        public string NickName { get; set; }
        [MinLength(11)]
        public string Cpf { get; set; }
        public int WeightClass { get; set; }
        public int FightId { get; set; }
    }
}
