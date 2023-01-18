using System;

namespace Domain.Exptions
{
    public class UserExecption : Exception
    {
        public UserExecption(string code, string msg) : base($"CODE: {code} MESSAGE: {msg}") { }
    }
}
