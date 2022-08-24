using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// Classe para passagem de erro
    /// </summary>
    public class ErrorValidator
    {
        public string Field { get; set; }
        public string  Message { get; set; }
    }
}
