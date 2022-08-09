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
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string ArteMarcial { get; set; }
        public string Cpf { get; set; }
        public string UrlFoto { get; set; }
        public int? GrauArteMarcial { get; set; }
    }
}
