using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Cotizaciones
{
    public partial class CotizacionAuto : System.Web.UI.Page
    {
        private static List<Marca> marcasL = new List<Marca>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargaMarca();
            }
            
        }
        public void CargaMarca()
        {
            RequestApi request = new RequestApi() {
                NombreCatalogo = "Marca",
                Filtro = "1",
                IdAplication = 2
            };
            marcasL = JsonConvert.DeserializeObject<List<Marca>>(PostItem(JsonConvert.SerializeObject(request)));//PostItem(JsonConvert.SerializeObject(request));
            ddlMarca.DataSource = marcasL;
            ddlMarca.DataValueField = "iIdMarca";
            ddlMarca.DataTextField = "sMarca";
            ddlMarca.DataBind();
        }
        private string PostItem(string data)
        {
            string listMarca="";

            var url = $"https://apitestcotizamatico.azurewebsites.net/api/catalogos";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(data);
                streamWriter.Flush();
                streamWriter.Close();
            }
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        //if (strReader == null)
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            ResponseApi responseApi = JsonConvert.DeserializeObject<ResponseApi>(responseBody);
                            listMarca = responseApi.CatalogoJsonString;
                            //Console.WriteLine(responseBody);
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
            }
            return listMarca;
        }

        protected void ddlMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemMarca= ddlMarca.SelectedItem.Value;
            RequestApi request = new RequestApi()
            {
                NombreCatalogo = "Submarca",
                Filtro = itemMarca,
                IdAplication = 2
            };

            List<ResponseSubMarca> submarcas = JsonConvert.DeserializeObject<List<ResponseSubMarca>>(PostItem(JsonConvert.SerializeObject(request)));
            ddlSubMarca.Items.Clear();
            ddlSubMarca.DataSource = submarcas;
            ddlSubMarca.DataValueField = "iIdSubMarca";
            ddlSubMarca.DataTextField = "sSubMarca";
            ddlSubMarca.DataBind();
        }

        protected void ddlSubMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemSubmarca = ddlSubMarca.SelectedItem.Value;
            RequestApi request = new RequestApi()
            {
                NombreCatalogo = "Modelo",
                Filtro = itemSubmarca,
                IdAplication = 2
            };

            List<ResponseModelo> modelos = JsonConvert.DeserializeObject<List<ResponseModelo>>(PostItem(JsonConvert.SerializeObject(request)));
            ddlModelo.Items.Clear();
            ddlModelo.DataSource = modelos;
            ddlModelo.DataValueField = "iIdModelo";
            ddlModelo.DataTextField = "sModelo";
            ddlModelo.DataBind();
        }

        protected void ddlModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemModelo = ddlModelo.SelectedItem.Value;
            RequestApi request = new RequestApi()
            {
                NombreCatalogo = "DescripcionModelo",
                Filtro = itemModelo,
                IdAplication = 2
            };

            List<ResponseDescripcionModelo> descripciones = JsonConvert.DeserializeObject<List<ResponseDescripcionModelo>>(PostItem(JsonConvert.SerializeObject(request)));
            ddlDescripcion.Items.Clear();
            ddlDescripcion.DataSource = descripciones;
            ddlDescripcion.DataValueField = "iIdDescripcionModelo";
            ddlDescripcion.DataTextField = "sDescripcion";
            ddlDescripcion.DataBind();
        }

        protected void btnCotizar_Click(object sender, EventArgs e)
        {
            var codigoP = txtCP.Text;

            RequestApi request = new RequestApi()
            {
                NombreCatalogo = "Sepomex",
                Filtro = codigoP,
                IdAplication = 2
            };

            //List<ResponseSepomex> responseSepomex = JsonConvert.DeserializeObject<List<ResponseSepomex>>(PostItem(JsonConvert.SerializeObject(request)));
            
            
        }

        //protected void txtCP_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    var codigoP = txtCP.Text;
        //    if((int)e.KeyChar == (int)Keys.Enter)
        //    {
        //        RequestApi request = new RequestApi()
        //        {
        //            NombreCatalogo = "Sepomex",
        //            Filtro = codigoP,
        //            IdAplication = 2
        //        };

        //        ResponseSepomex responseSepomex = JsonConvert.DeserializeObject<ResponseSepomex>(PostItem(JsonConvert.SerializeObject(request)));
        //        txtEstado.Text = responseSepomex.Estado.sEstado.ToString();
        //        txtMunicipio.Text = responseSepomex.Municipio.sMunicipio.ToString();
        //        txtColonia.Text = responseSepomex.Ubicacion.sUbicacion.ToString();
        //    }
        //}

        //protected void txtCP_TextChanged(object sender, EventArgs e)
        //{

        //}


    }
}