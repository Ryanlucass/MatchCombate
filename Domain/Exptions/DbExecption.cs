using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exptions
{
    public class DbExecption : Exception
    {
        public DbExecption(string code, string msg) : base($"CODE{code}, {msg}"){}
    }
}
