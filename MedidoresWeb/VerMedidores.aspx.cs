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
    public partial class VerMedidores : System.Web.UI.Page
    {
        private IMedidor medidorDAL = new MedidorDALObjeto();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGrilla();
            }
        }

        private void cargarGrilla()
        {
            List<Medidor> medidores = medidorDAL.Obtener();
            this.grillaRescates.DataSource = medidores;
            this.grillaRescates.DataBind();
        }

        protected void filtroDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.filtroDdl.SelectedValue != null)
            {
                string estado = this.filtroDdl.SelectedItem.Value;
                List<Medidor> filtrada = medidorDAL.filtrar(estado);
                cargarGrilla(filtrada);
            }
            else
            {
                cargarGrilla();
            }
        }


        private void cargarGrilla(List<Medidor> filtrada)
        {
            this.grillaRescates.DataSource = filtrada;
            this.grillaRescates.DataBind();
        }


        protected void grillaRescates_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }
    }

    }
