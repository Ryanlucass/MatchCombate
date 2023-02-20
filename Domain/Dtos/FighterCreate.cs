using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos
{
    public class FighterCreate
    {
        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string Name { get; set; }
        
        //if don't have a nickname, considered the name with "nick" in front
        [MinLength(2)]
        [MaxLength(20)]
        public string NickName { get; set; }
        [Required]
        [MinLength(11)]
        [MaxLength(14)]
        public string CodeId { get; set; }
        [Required]
        [Range(12.3, 270)]
        public int WeightClass { get; set; }
    }

    public class FighterResult 
    {
        public Guid Uid { get; set; }
        public string Name { get; set; }
        //if don't have a nickname, considered the name with "nick" in front
        public string NickName { get; set; }
        public string CodeId { get; set; }
        public int WeightClass { get; set; }
        public DateTime CreatedAt { get; set; }
    }
    public class FighterDtoPatch
    {
        [MinLength(2)]
        [MaxLength(30)]
        public string Name { get; set; }
        [MinLength(5)]
        [MaxLength(20)]
        public string NickName { get; set; }
        [MinLength(11)]
        [MaxLength(11)]
        public string Cpf { get; set; }
        public int WeightClass { get; set; }
        public int FightId { get; set; }
    }
}
