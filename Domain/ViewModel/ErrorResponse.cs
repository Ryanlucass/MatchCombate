using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModel
{
    public class ErrorResponse
    {
        public string TraceId { get; private set; } = Guid.NewGuid().ToString();
        public List<ErrorDetails> Errors { get; private set; } = new List<ErrorDetails>();

        public ErrorResponse(string logref, string message) => Errors.Add(new ErrorDetails(logref, message));
    }
}
