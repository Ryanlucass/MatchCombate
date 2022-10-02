using System;

namespace Domain.Dtos
{
    public class FightDto
    {
        public int? Id { get; set; }
        public DateTime Date { get; set; }
        public string Locale { get; set; }
        public string Box { get; set; }
    }
}
