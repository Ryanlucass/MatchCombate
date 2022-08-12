using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Lutador
    {
        public int Id { get; set; }
        //[JsonProperty("criado_em")]
        public DateTime Criadoem { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        //[JsonProperty("arte_marcial")]
        public string ArteMarcial { get; set; } = null;
        public string Cpf { get; set; }
        public int Categoria { get; set; }
        //[JsonProperty("grau_artemarcial")]
        public int? GrauArtemarcial { get; set; }
    }
}
