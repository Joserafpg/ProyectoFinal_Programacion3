using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Seguridad
    {
        public static string ObtenerHash(string texto)
        {
            using (var sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(texto));
                var sb = new StringBuilder();

                foreach (byte b in bytes)
                    sb.Append(b.ToString("X2"));

                return sb.ToString();
            }
        }
    }
}
