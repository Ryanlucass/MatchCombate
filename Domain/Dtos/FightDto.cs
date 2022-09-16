using System;

namespace Domain.Dtos
{
    public class FightDto
    {
        public int? Id { get; set; }
        public DateTime Data { get; set; }
        public string Local { get; set; }
        public string Octogono { get; set; }
    }
}
