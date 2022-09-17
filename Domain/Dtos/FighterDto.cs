using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos
{
    public class FighterDto
    {
        public int? Id { get; set; }
        public int? LutaId { get; set; }
        public string Name { get;  set; }
        public string NickName { get;  set; }
        public string Cpf { get;  set; }
        public int WeightClass { get; set; }
        public DateTime Date { get; set; }
    }
}
