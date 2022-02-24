using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cotizaciones
{
    public class Root
    {
        public List<CatalogoJsonString> CatalogoJsonString { get; set; }
        public string Error { get; set; }
    }
}