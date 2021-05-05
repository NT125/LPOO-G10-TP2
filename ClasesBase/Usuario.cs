using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {

        private int usuId;

        public int UsuId
        {
            get { return usuId; }
            set { usuId = value; }
        }
        private string usuNombreUsuario;

        public string UsuNombreUsuario
        {
            get { return usuNombreUsuario; }
            set { usuNombreUsuario = value; }
        }
        private string usuContrasenia;

        public string UsuContrasenia
        {
            get { return usuContrasenia; }
            set { usuContrasenia = value; }
        }
        private string usuApellidoNombre;

        public string UsuApellidoNombre
        {
            get { return usuApellidoNombre; }
            set { usuApellidoNombre = value; }
        }
        private int rolCodigo;
   
        public int RolCodigo
        {
            get { return rolCodigo; }
            set { rolCodigo = value; }
        }


        public Usuario(string userName, string passowrd)
        {
            UsuNombreUsuario = userName;
            UsuContrasenia = passowrd;
        }

        public Usuario()
        { }

       

    }
}
