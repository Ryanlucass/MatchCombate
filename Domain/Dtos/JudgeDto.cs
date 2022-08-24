using System;

namespace Domain.Dtos
{
    public class JudgeDto
    {
        public int Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public string Phone { get; private set; }
        public string Name { get; private set; }
        public string Cpf { get; private set; }
    }
}
