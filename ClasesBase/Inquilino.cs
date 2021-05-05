using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Inquilino
    {
        private int inqCodigo;

        public int InqCodigo
        {
            get { return inqCodigo; }
            set { inqCodigo = value; }
        }
        private string inqApellido;

        public string InqApellido
        {
            get { return inqApellido; }
            set { inqApellido = value; }
        }
        private string inqNombre;

        public string InqNombre
        {
            get { return inqNombre; }
            set { inqNombre = value; }
        }
        private string inqTelefono;

        public string InqTelefono
        {
            get { return inqTelefono; }
            set { inqTelefono = value; }
        }

        public Inquilino() { }

    }
}
