using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp;   

namespace WebApp
{

    public partial class actualizar_participante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarUniversidades();
            }
        }
        private void LlenarUniversidades()
        {
            ModeloWeb_entity modelo = new ModeloWeb_entity();
            var universidades = from r in modelo.universidad
                                select r;
            cboUniversidad.DataSource = universidades.ToList();
            cboUniversidad.DataTextField = "des_universidad";
            cboUniversidad.DataValueField = "cod_universidad";
            cboUniversidad.DataBind();
            cboUniversidad.Items.Insert(0, "Escoja universidad");
        }

        protected void cbouniversidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbouniversidad.SelectedIndex > 0)
                {
                    ModeloWeb_entity modelo = new ModeloWeb_entity();
                    int coduniversidad = int.Parse(cbouniversidad.SelectedValue.ToString());
                    var Carreras = from p in modelo.Carrera
                                   where p.cod_universidad == coduniversidad
                                   select p;
                    cboCarrera.DataSource = Carreras.ToList();
                    cboCarrera.DataTextField = "des_Carrera";
                    cboCarrera.DataValueField = "cod_Carrera";
                    cboCarrera.DataBind();
                    cboCarrera.Items.Insert(0, "Escoja Carrera");
                }
                else
                {
                    cboCarrera.Items.Clear();
                    cboSeminario.Items.Clear();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        protected void cboCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboCarrera.SelectedIndex > 0)
                {
                    ModeloWeb_entity modelo = new ModeloWeb_entity();
                    int codCarrera = int.Parse(cboCarrera.SelectedValue.ToString());
                    var Seminarioes = from c in modelo.Seminario
                                      where c.cod_Carrera == codCarrera
                                      select c;
                    cboSeminario.DataSource = Seminarioes.ToList();
                    cboSeminario.DataTextField = "des_Seminario";
                    cboSeminario.DataValueField = "cod_Seminario";
                    cboSeminario.DataBind();
                    cboSeminario.Items.Insert(0, "Escoja Seminario");
                }
                else
                {
                    cboSeminario.Items.Clear();
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}