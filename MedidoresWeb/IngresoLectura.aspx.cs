using MedidoresModel.DAL;
using MedidoresModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresWeb
{
    public partial class IngresoLectura : System.Web.UI.Page
    {

        private ILectura lecturaDAL = new LecturaDALObjeto();
        private IMedidor MedidorDAL = new MedidorDALObjeto();

       

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                cargarTogo();
            }
    }

        private void cargarTogo()
        {
            List<Medidor> medidores = MedidorDAL.Obtener();
            this.medidoreDD1.DataSource = medidores;
            this.medidoreDD1.DataTextField = "idMedidor";
            this.medidoreDD1.DataValueField = "idMedidor";
            this.medidoreDD1.DataBind();
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            fechaTxt.Text = Calendar1.SelectedDate.ToShortDateString();

        }

        private void validar()
        {
        }



        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            List<Medidor> medidores = MedidorDAL.Obtener();
            string idMedidor = medidoreDD1.SelectedItem.Text;
            string consumo = this.ConsumoTxt.Text.Trim();
            string hora = this.HoraTxt.Text.Trim();
            string fecha = Calendar1.SelectedDate.ToShortDateString();
            string minutos = this.MinutosTxt.Text.Trim();
            string final = fecha + " " + hora+":"+minutos+":00";
            DateTime love = Convert.ToDateTime(final);
           
            Lectura lectura = new Lectura()
            {
                ValorConsumo = Convert.ToDecimal(consumo),
                IdMedidor = Convert.ToInt32(idMedidor),
                Fecha = love
        };
            lecturaDAL.Agregar(lectura);
            this.mensajeBtn.Text = "Lectura Ingresada Fue ingresada";
        }
    }
}