using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Departamento
    {
        private int deptoCodigo;
        public int DeptoCodigo
        {
            get { return deptoCodigo; }
            set { deptoCodigo = value; }
        }

        private string edifNombre;
        public string EdifNombre
        {
            get { return edifNombre; }
            set { edifNombre = value; }
        }

        private string dptoTipo;
        public string DptoTipo
        {
            get { return dptoTipo; }
            set { dptoTipo = value; }
        }


        private int dptoNumero;
        public int DptoNumero
        {
            get { return dptoNumero; }
            set { dptoNumero = value; }
        }


        private int dptoPiso;
        public int DptoPiso
        {
            get { return dptoPiso; }
            set { dptoPiso = value; }
        }


        private int dptoAmbientes;
        public int DptoAmbientes
        {
            get { return dptoAmbientes; }
            set { dptoAmbientes = value; }
        }


        private int dptoDormitorios;
        public int DptoDormitorios
        {
            get { return dptoDormitorios; }
            set { dptoDormitorios = value; }
        }

        
        private int dptoBanios;
        public int DptoBanios
        {
            get { return dptoBanios; }
            set { dptoBanios = value; }
        }

        private float dptoPrecio;

        public float DptoPrecio
        {
            get { return dptoPrecio; }
            set { dptoPrecio = value; }
        }

        private string dptoDisposicion;
        public string DptoDisposicion
        {
            get { return dptoDisposicion; }
            set { dptoDisposicion = value; }
        }

        public Departamento() { }

    }
}
