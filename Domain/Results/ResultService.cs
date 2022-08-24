using FluentValidation.Results;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Results
{
    /// <summary>
    /// Classe de return das requisições
    /// </summary>
    public class ResultService
    {
        public bool IsSucess { get; set; }
        public string Message { get; set; }
        public ICollection<ErrorValidator> Erros { get; set; }

        public static ResultService RequestError(string message, ValidationResult validation)
        {
            return new ResultService()
            {
                IsSucess = false,
                Message = message,
                Erros = validation.Errors.Select(x => new ErrorValidator { Field = x.PropertyName, Message = x.ErrorMessage }).ToList()

            };
        }

        public static ResultService<T> RequestError<T>(string message, ValidationResult validation)
        {
            return new ResultService<T>()
            {
                IsSucess = false,
                Message = message,
                Erros = validation.Errors.Select(x => new ErrorValidator { Field = x.PropertyName, Message = x.ErrorMessage }).ToList()
            };
        }

        public static ResultService Fail(string message) => new ResultService { IsSucess = false, Message = message };
        public static ResultService<T> Fail<T>(string message) => new ResultService<T> { IsSucess = false, Message = message};

        public static ResultService Ok(string message) => new ResultService { IsSucess = true, Message = message };
        public static ResultService Ok<T>(T data) => new ResultService<T> { IsSucess = true, Data = data};

    }
    public class ResultService<T> : ResultService
    {
        public T Data { get; set; }
    }
}
