namespace Domain.Dtos.FighterDtos
{
    public class FighterDtoCreate
    {
        public string Name { get; set; }
        public string NickName { get; set; }
        public string Cpf { get; set; }
        public int WeightClass { get; set; }
        public int? FightId { get; set; }
    }
}
