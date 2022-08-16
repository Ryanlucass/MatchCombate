using Domain.Validation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Domain.Model
{
    public sealed class Fight
    {
        public int Id { get; private set; }
        public DateTime DateHours { get;  private set; }
        public int Time { get; private set; }
        public int Rounds { get; private set; }
        public StatusLuta StatusFightEnum { get; set; }
        public string StatusFight
        {
            get { return StatusFightEnum.ToString(); }
            set
            {
                if (Enum.TryParse(value, out StatusLuta statusLuta))
                {
                    StatusFightEnum = statusLuta;
                }
                else { throw new Exception($"Conversão errada {value}"); }
            }
        }

        //relacionamentos 
        //public List<Fighter> Fighters { get; set; }
        //public Judge Judge { get; set; }

        //create a fight
        public Fight(DateTime dateHours, int time, int rounds, string statusFight)
        {
            Validation(dateHours, time, rounds);

        }

        //update a fight
        public Fight(int id,DateTime dateHours, int time, int rounds)
        {
            ValidationExeption.When(id < 0, "Informe um Id válido");
            Id = id;
            Validation(dateHours, time, rounds);
        }

        private void Validation(DateTime dateHours, int time, int rounds)
        {
            ValidationExeption.When(dateHours == DateTime.MinValue, "Informe uma Data para a luta");
            ValidationExeption.When(time <= 0, "Informe um tempo para os roudns");
            ValidationExeption.When(rounds <= 0, "Informe no mínimo 1 round");

            DateHours = dateHours;
            Time = time;
            Rounds = rounds;
        }
    }
}
