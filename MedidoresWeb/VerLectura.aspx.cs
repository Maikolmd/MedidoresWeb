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

    public partial class VerLectura : System.Web.UI.Page
    {
        public int love;
        private static List<Lectura> yunita = new List<Lectura>();
        private IMedidor medidorDAL = new MedidorDALObjeto();
        private ILectura lecturaDAL = new LecturaDALObjeto();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGrilla();
                cargarMedidor();
            }
        }



        private void cargarMedidor()
        {
            List<Medidor> medidores = medidorDAL.Obtener();
            this.medidoreDD1.DataSource = medidores;
            this.medidoreDD1.DataTextField = "idMedidor";
            this.medidoreDD1.DataValueField = "idMedidor";
            this.medidoreDD1.DataBind();
            love = Convert.ToInt32(this.medidoreDD1.SelectedItem.Text);
        }



        private void cargarGrilla()
        {
            List<Lectura> lecturas = lecturaDAL.Obtener();
        }

        private void cargarGrilla(List<Lectura> filtrada)
        {
            love = Convert.ToInt32(this.medidoreDD1.SelectedItem.Text);
            List<Lectura> lecturas = lecturaDAL.filtrar(love);
        }

        protected void grillaRescates_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            love = Convert.ToInt32(this.medidoreDD1.SelectedItem.Text);
            yunita = lecturaDAL.filtrar(love);
            Chart1_Load(sender, e);
        }
        protected void Chart1_Load(object sender, EventArgs e)
        {
            yunita = lecturaDAL.filtrar(love);
            foreach (Lectura lecturas in yunita)
            {
                int love = Convert.ToInt32(lecturas.ValorConsumo);
                string fecha = Convert.ToString(lecturas.Fecha);
                Chart1.Series["Series1"].LegendText = "Visitas 2017";
                Dictionary<string, int> dic = new Dictionary<string, int>();
                dic.Add(fecha, love);

                foreach (KeyValuePair<string, int> d in dic)
                {
                    Chart1.Series["Series1"].Points.AddXY(d.Key, d.Value);
                }
            }
        }
    }
    }