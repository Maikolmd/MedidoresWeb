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
    public partial class IngresoMedidor : System.Web.UI.Page
    {

        private IMedidor medidoresDAL = new MedidorDALObjeto();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.IdmedidorTxt.Text.Trim());
            string tipo = this.tipomedidorDD1.SelectedValue.Trim();
            Medidor medidor = new Medidor()
            {
                IdMedidor = id,
                Tipo = tipo

            };
            medidoresDAL.Agregar(medidor);
            this.mensajeBtn.Text = "Rescatista Fue ingresado";
            Response.Redirect("VerMedidores.aspx");
        }
    }
}