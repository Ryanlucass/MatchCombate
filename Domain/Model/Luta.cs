using Newtonsoft.Json;
using System;

namespace Domain.Model
{
    public class Luta
    {
        public int Id { get; set; }
        public DateTime HorarioInicial { get; set; }
        public int Tempo { get; set; }
        public int Rounds { get; set; }
        public StatusLuta StatusLutaEnum { get; set; }
        public string StatusLuta
        {
            get { return StatusLutaEnum.ToString(); }
            set
            {
                if (Enum.TryParse(value, out StatusLuta statusLuta))
                {
                    StatusLutaEnum = statusLuta;
                }
                else { throw new Exception($"Conversão errada {value}"); }
            }
        }
    }
}
