using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.Ayudantes
{
    public static class Encriptador
    {
        public static string Encriptar(SecureString texto, byte[] salt = null)
        {
            if (salt == null)
            {
                salt = CrearSalt();
            }
            var textoInseguro = ComoTextoInseguro(texto);
            byte[] datosEncryptados = KeyDerivation.Pbkdf2(password: textoInseguro,salt: salt,prf: KeyDerivationPrf.HMACSHA1,iterationCount: 10000,numBytesRequested: 256 / 8);
            return Convert.ToBase64String(datosEncryptados);
        }

        public static byte[] CrearSalt()
        {
            var salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }

        public static SecureString ComoTextoSeguro(string input)
        {
            SecureString secure = new SecureString();
            foreach (char c in input)
            {
                secure.AppendChar(c);
            }
            secure.MakeReadOnly();
            return secure;
        }

        public static string ComoTextoInseguro(SecureString input)
        {
            string returnValue = string.Empty;
            IntPtr ptr = System.Runtime.InteropServices.Marshal.SecureStringToBSTR(input);
            try
            {
                returnValue = System.Runtime.InteropServices.Marshal.PtrToStringBSTR(ptr);
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ZeroFreeBSTR(ptr);
            }
            return returnValue;
        }
    }
}
