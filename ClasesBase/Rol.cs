using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Rol
    {
        private int rolCodigo;

        public int RolCodigo
        {
            get { return rolCodigo; }
            set { rolCodigo = value; }
        }
        private string rolDescripcion;

        public string RolDescripcion
        {
            get { return rolDescripcion; }
            set { rolDescripcion = value; }
        }
    }
}
