using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos
{
    public class LutadorDto
    {
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string ArteMarcial { get; set; }
        public string Cpf { get; set; }
        public int Categoria { get; set; }
    }
}
