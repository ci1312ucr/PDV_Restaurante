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
                var contrasenaDesencriptada = Ayudantes.Encriptador.Desencriptar(usuario.Constrasena);
                if (Ayudantes.Encriptador.ComoTextoInseguro(contrasenaDesencriptada) != Ayudantes.Encriptador.ComoTextoInseguro(contrasena))
                {
                    usuario = null;
                }
            }
            return usuario;
        }
    }
}
