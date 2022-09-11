using Domain.Validation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Fighter
    {
        [Key]
        public int Id { get; private set; }
        public DateTime CreateAt { get; private set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; private set; }
        [Required]
        [MaxLength(20)]
        [MinLength(4)]
        public string NickName { get; private set;}
        [Required]
        [MinLength(2)]
        [MaxLength(11)]
        public string Cpf { get; private set; }
        [Required]
        public int WeightClass { get; set; }

    }
}
