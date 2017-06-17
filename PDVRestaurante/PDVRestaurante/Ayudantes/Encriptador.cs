using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.Ayudantes
{
    public static class Encriptador
    {
        static byte[] entropy = System.Text.Encoding.Unicode.GetBytes("ci1312ucr");

        public static string Encriptar(SecureString texto)
        {
            byte[] datosEncryptados = System.Security.Cryptography.ProtectedData.Protect(
                System.Text.Encoding.Unicode.GetBytes(ComoTextoInseguro(texto)),
                entropy,
                System.Security.Cryptography.DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(datosEncryptados);
        }

        public static SecureString Desencriptar(string texto)
        {
            try
            {
                byte[] datosDesencriptados = System.Security.Cryptography.ProtectedData.Unprotect(
                    Convert.FromBase64String(texto),
                    entropy,
                    System.Security.Cryptography.DataProtectionScope.CurrentUser);
                return ComoTextoSeguro(System.Text.Encoding.Unicode.GetString(datosDesencriptados));
            }
            catch
            {
                return new SecureString();
            }
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
