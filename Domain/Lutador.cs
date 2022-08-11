using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Lutador
    {
        public int Id { get; set; }
        public DateTime Criadoem { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Cpf { get; set; }
        public int Categoria { get; set; }
        public int? GrauArteMarcial { get; set; }
        public string UrlFoto { get; set; } = null;
        public string ArteMarcial { get; set; } = null;
    }
}
