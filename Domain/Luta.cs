using System;

namespace Domain
{
    public class Luta {
        public int Id { get; set; }
        public DateTime CriadoEm { get; set; }
        public int TempoLuta { get; set; }
        public int Rounds { get; set; }
        public StatusLuta StatusLutaEnum { get; set; }
        public string StatusLuta
        {
            get { return StatusLutaEnum.ToString(); }
            set {
                    if (Enum.TryParse(value, out StatusLuta statusLuta))
                    {
                        StatusLutaEnum = statusLuta;
                    }
                    else { throw new Exception($"Conversão errada {value}");}
                }
        }
    }
}
