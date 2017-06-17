using PDVRestaurante.BaseDatos;
using PDVRestaurante.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.Autenticacion
{
    public static class Autenticacion
    {
        public static Usuario Autenticar(string nombre, SecureString contrasena)
        {
            var usuario = UsuarioDB.ObtenerUsuario(nombre.ToLower());
            if (usuario != null)
            {
                var salt = Convert.FromBase64String(usuario.Salt);
                var contrasenaEncriptada = Ayudantes.Encriptador.Encriptar(contrasena, salt);
                if (contrasenaEncriptada != usuario.Constrasena)
                {
                    usuario = null;
                }
            }
            return usuario;
        }
    }
}
