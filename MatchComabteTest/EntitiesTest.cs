using Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MatchComabteTest
{
    [TestClass]
    public class EntitiesTest
    {
        [TestMethod]
        public void ValidandoIterfaceLutador()
        {
            string apelido = "Calivem";
            string artemarcial = "Bjj";
            string nome = "Lucas Ryan";
            string cpf = "61711369306";
            int peso = 80;


            Fighter lutador = new("Lucas Ryan","Calivem","Bjj","61711369306",80);
            Assert.IsTrue(lutador.Name == nome);
            Assert.IsTrue(lutador.NickName == apelido);
            Assert.IsTrue(lutador.Martialarts == artemarcial);
            Assert.IsTrue(lutador.WeightClass == peso);
            Assert.IsTrue(lutador.Cpf == cpf);
            Assert.IsTrue(lutador.CreateAt != System.DateTime.MinValue);

        }
        [TestMethod]
        public void ValidandoIterfaceLuta()
        {
            int tempo = 5;
            DateTime dataluta = DateTime.Now;
            int rounds = 3;
            string status = "aberto";

            Fight luta = new(dataluta,tempo,rounds,status);
            Assert.IsTrue(luta.DateHours == dataluta);
            Assert.IsTrue(luta.Rounds == rounds);
            Assert.IsTrue(luta.StatusFight == status);
        }
        [TestMethod]
        public void ValidandoInterfacejuiz()
        {
            string nome = "Lucas Ryan";
            string cpf = "61711369306";
            string telefone = "85996614167";

            Judge Juiz = new(telefone,nome,cpf);
            Assert.IsTrue(Juiz.Name == nome);
            Assert.IsTrue(Juiz.Cpf == cpf);
            Assert.IsTrue(Juiz.Phone == telefone);
            Assert.IsTrue(Juiz.CreatedAt != DateTime.MinValue);
            
        }
    }
}
