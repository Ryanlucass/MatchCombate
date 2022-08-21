using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class CombatDto
    {
        public int Id { get; private set; }
        public string FistNickName { get; set; }
        public string SecondNickName { get; set; }
        public int Rounds { get; private set; }
        public DateTime DateHours { get; set; }
        public Model.StatusLuta StatusFightEnum { get; set; } = default;
        public string StatusFight
        {
            get { return StatusFightEnum.ToString(); }
            set
            {
                if (Enum.TryParse(value, out Model.StatusLuta statusLuta))
                {
                    StatusFightEnum = statusLuta;
                }
                else { throw new Exception($"Conversão errada {value}"); }
            }
        }
    }
}
