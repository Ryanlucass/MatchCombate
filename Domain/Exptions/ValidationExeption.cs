using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validation
{
    public class ValidationExeption :Exception
    {
        public ValidationExeption(string error) : base(error)
        {}

        public static void When(bool hasError, string msg)
        {
            if (hasError) { throw new ValidationExeption(msg);}
        }
    }
}
