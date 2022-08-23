using System;

namespace Domain.Dtos
{
    public class FighterDto
    {
        public int Id { get; private set; }
        public DateTime CreateAt { get; private set; }
        public string Name { get; private set; }
        public string NickName { get; private set; }
        public string Martialarts { get; private set; }
        public string Cpf { get; private set; }
        public int WeightClass { get; set; }

    }
}
