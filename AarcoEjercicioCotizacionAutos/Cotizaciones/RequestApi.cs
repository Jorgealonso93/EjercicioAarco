﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cotizaciones
{
    public class RequestApi
    {
        public string NombreCatalogo { get; set; }
        public string Filtro { get; set; }
        public int IdAplication { get; set; }
    }
}