using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cotizaciones
{
    public class Ubicacion
    {
        public int iIdUbicacion { get; set; }
        public string CodigoPostal { get; set; }
        public int iUbicacionCodigoPostal { get; set; }
        public string TipoUbicacion { get; set; }
        public int iClaveUbicacionCepomex { get; set; }
        public string Ciudad { get; set; }
        public string sUbicacion { get; set; }
    }
}