using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;

namespace Domain.Security
{
    public class SingingConfigurations
    {
        public SecurityKey Key { get; set; }
        public SigningCredentials SigningCredentials  { get; set; }
        public SingingConfigurations()
        {
            Key = new RsaSecurityKey(_ = new RSACryptoServiceProvider(2048).ExportParameters(true));

            SigningCredentials = new SigningCredentials(Key, SecurityAlgorithms.RsaSha256Signature);
        }
    }
}
