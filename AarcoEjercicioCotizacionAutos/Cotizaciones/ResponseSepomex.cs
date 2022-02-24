using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cotizaciones
{
    public partial class ResponseSepomex
    {
        [JsonProperty("CatalogoJsonString")]
        public CatalogoJsonString[] CatalogoJsonString { get; set; }

        [JsonProperty("Error")]
        public string Error { get; set; }
    }
    public partial class CatalogoJsonStrings
    {
        [JsonProperty("Municipio")]
        public Municipio Municipio { get; set; }

        [JsonProperty("Ubicacion")]
        public Ubicacion[] Ubicacion { get; set; }
    }
    public partial class Municipios
    {
        [JsonProperty("iIdMunicipio")]
        public long IIdMunicipio { get; set; }

        [JsonProperty("Estado")]
        public Estado Estado { get; set; }

        [JsonProperty("iMunicipioEstado")]
        public long IMunicipioEstado { get; set; }

        [JsonProperty("iClaveMunicipioCepomex")]
        public long IClaveMunicipioCepomex { get; set; }

        [JsonProperty("sMunicipio")]
        public string SMunicipio { get; set; }
    }

    public partial class Estados
    {
        [JsonProperty("iIdEstado")]
        public long IIdEstado { get; set; }

        [JsonProperty("Pais")]
        public object Pais { get; set; }

        [JsonProperty("iEstadoPais")]
        public long IEstadoPais { get; set; }

        [JsonProperty("iClaveEstadoCepomex")]
        public long IClaveEstadoCepomex { get; set; }

        [JsonProperty("sEstado")]
        public string SEstado { get; set; }
    }

    public partial class Ubicacions
    {
        [JsonProperty("iIdUbicacion")]
        public long IIdUbicacion { get; set; }

        [JsonProperty("CodigoPostal")]
        public object CodigoPostal { get; set; }

        [JsonProperty("iUbicacionCodigoPostal")]
        public long IUbicacionCodigoPostal { get; set; }

        [JsonProperty("TipoUbicacion")]
        public object TipoUbicacion { get; set; }

        [JsonProperty("iClaveUbicacionCepomex")]
        public long IClaveUbicacionCepomex { get; set; }

        [JsonProperty("Ciudad")]
        public object Ciudad { get; set; }

        [JsonProperty("sUbicacion")]
        public string SUbicacion { get; set; }
    }
}