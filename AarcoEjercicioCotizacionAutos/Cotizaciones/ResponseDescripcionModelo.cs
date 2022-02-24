using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cotizaciones
{
    public class ResponseDescripcionModelo
    {
        public int iIdDescripcionModelo { get; set; }
        public int iIdModeloSubmarca { get; set; }
        public int iIdMostrar { get; set; }
        public string sDescripcion { get; set; }
    }
}