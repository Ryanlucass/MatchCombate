using Domain.Validation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Fighter
    {
        public int Id { get; private set; }
        public DateTime CreateAt { get; private set; }
        public string Name { get; private set; }
        public string NickName { get; private set;}
        public string Martialarts { get; private set; }
        public string Cpf { get; private set; }
        public int WeightClass { get; set; }
        //relacionamentos
        //public List<Fight> Fights { get; set; }

        //Create a fighter
        public Fighter(string name, string nickname, string martialarts, string cpf, int weightclass)
        {
            Validation(name, nickname, martialarts, cpf, weightclass);
        }

        //Update a Figther
        public Fighter(int id,string name, string nickname, string martialarts, string cpf, int weightclass)
        {
            ValidationExeption.When(id < 0, "Informe um Id válido");
            Id = id;
            Validation(name, nickname, martialarts, cpf, weightclass);
        }

        private void Validation(string name, string nickname, string martialarts, string cpf, int weightclass)
        {

            ValidationExeption.When(string.IsNullOrEmpty(name),"Informe um nome para o lutador");
            ValidationExeption.When(string.IsNullOrEmpty(nickname),"Informe um apelido ou abreviação para o lutador");
            ValidationExeption.When(string.IsNullOrEmpty(martialarts), "Informe uma Arte Marcial");
            ValidationExeption.When(Regex.IsMatch(cpf, @"^\d{ 3}\d{ 3}\d{ 3}\d{2}$"), "Cpf informado não é válido");
            ValidationExeption.When(weightclass >= 0, "Informe o peso do atelta para informamos sua categoria");

            Name = name;
            NickName = nickname;
            Martialarts = martialarts;  
            WeightClass = weightclass;
            Cpf = cpf;
        }
    }
}
