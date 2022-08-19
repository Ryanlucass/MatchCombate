using Domain.Validation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Domain.Model
{
    public sealed class Combat
    {

        //id
        //apelidolutfirst
        //apelidolutsecond
        //rounds
        //status_luta

        public int Id { get; private set; }
        public string FistNickName { get; set; }
        public string SecondNickName { get; set; }
        public int Rounds { get; private set; }
        public DateTime DateHours { get; set; }
        public StatusLuta StatusFightEnum { get; set; } = default;
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

        //create a fight
        public Combat(string name01, string name02, int rounds, DateTime datehours, string statusfight)
        {
            Validation(name01, name02, rounds, datehours,  statusfight);

        }

        //update a fight
        public Combat(int id,string name01, string name02, int rounds, DateTime datehours, string statusfight)
        {
            ValidationExeption.When(id < 0, "Informe um Id válido");
            Id = id;
            Validation(name01, name02, rounds, datehours, statusfight);
        }

        private void Validation(string name01, string name02, int rounds, DateTime datehours, string statusfight)
        {
            ValidationExeption.When(datehours == DateTime.MinValue, "Informe uma Data para a luta");
            ValidationExeption.When(rounds <= 0, "Informe um tempo para os roudns");
            ValidationExeption.When(string.IsNullOrEmpty(name01), "Informe o nome do primeiro lutador");
            ValidationExeption.When(string.IsNullOrEmpty(name02), "Informe o nome do segunda lutador");
            ValidationExeption.When(string.IsNullOrEmpty(statusfight), "informe o status da luta");

            FistNickName = name01;
            SecondNickName = name02;
            DateHours = datehours;
            Rounds = rounds;
            StatusFight = statusfight;

        }
    }
}
