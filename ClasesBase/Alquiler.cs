using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Alquiler
    {
        private int alqCodigo;

        public int AlqCodigo
        {
            get { return alqCodigo; }
            set { alqCodigo = value; }
        }
        private DateTime alqFecha;

        public DateTime AlqFecha
        {
            get { return alqFecha; }
            set { alqFecha = value; }
        }
        private int dptoCodigo;

        public int DptoCodigo
        {
            get { return dptoCodigo; }
            set { dptoCodigo = value; }
        }
        private int inqCodigo;

        public int InqCodigo
        {
            get { return inqCodigo; }
            set { inqCodigo = value; }
        }
        private int alqFechaDesde;

        public int AlqFechaDesde
        {
            get { return alqFechaDesde; }
            set { alqFechaDesde = value; }
        }
        private int alqFechaHasta;

        public int AlqFechaHasta
        {
            get { return alqFechaHasta; }
            set { alqFechaHasta = value; }
        }
        private double alqPrecio;

        public double AlqPrecio
        {
            get { return alqPrecio; }
            set { alqPrecio = value; }
        }

    }
}
