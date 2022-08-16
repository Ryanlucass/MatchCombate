using Domain.Validation;
using System;
using System.Text.RegularExpressions;

namespace Domain.Model
{
    public class Judge
    {
        public int Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public String Phone { get; private set; }
        public string Name { get; private set; }
        public string Cpf { get; private set; }
        //relacionamentos
        //public Fight Fight { get; set; }

        //Create a Judge
        public Judge(string phone, string name, string cpf)
        {
            Validation(phone,name, cpf);
        }

        //Update a Judge
        public Judge(int id, string phone, string name, string cpf)
        {
            ValidationExeption.When(id < 0, "Informe um Id válido");
            Id = id;
            Validation(phone, name, cpf);
        }

        private void Validation(string phone, string name, string cpf)
        {
            ValidationExeption.When(string.IsNullOrEmpty(phone), "É necessário informar um Telefone ");
            ValidationExeption.When(string.IsNullOrEmpty(name), "É necessário informar um Nome");
            ValidationExeption.When(Regex.IsMatch(cpf, @"^\d{ 3}\d{ 3}\d{ 3}\d{2}$"), "Cpf informado não é válido");

            Name = name;
            Phone = phone;
            Cpf = cpf;
            CreatedAt = DateTime.Now;
        }

    }
}
