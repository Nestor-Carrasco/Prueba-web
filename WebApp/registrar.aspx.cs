using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class registroParticipante : System.Web.UI.Page
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
            var Universidades = from r in modelo.Universidades
                                select r;
            cboUniversidades.DataSource = Universidades.ToList();
            cboUniversidades.DataTextField = "des_Universidades";
            cboUniversidades.DataValueField = "cod_Universidades";
            cboUniversidades.DataBind();
            cboUniversidades.Items.Insert(0, "Escoja Universidades");
        }

        protected void cboUniversidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboUniversidades.SelectedIndex > 0)
                {
                    ModeloWeb_entity modelo = new ModeloWeb_entity();
                    int codUniversidades = int.Parse(cboUniversidades.SelectedValue.ToString());
                    var Seminarios = from p in modelo.Seminario
                                     where p.cod_Universidades == codUniversidades
                                     select p;
                    cboSeminario.DataSource = Seminarios.ToList();
                    cboSeminario.DataTextField = "des_Seminario";
                    cboSeminario.DataValueField = "cod_Seminario";
                    cboSeminario.DataBind();
                    cboSeminario.Items.Insert(0, "Escoja Seminario");
                }
                else
                {
                    cboSeminario.Items.Clear();
                    cboCiudad.Items.Clear();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        protected void cboSeminario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboSeminario.SelectedIndex > 0)
                {
                    ModeloWeb_entity modelo = new ModeloWeb_entity();
                    int codSeminario = int.Parse(cboSeminario.SelectedValue.ToString());
                    var ciudades = from c in modelo.ciudad
                                   where c.cod_Seminario == codSeminario
                                   select c;
                    cboCiudad.DataSource = ciudades.ToList();
                    cboCiudad.DataTextField = "des_ciudad";
                    cboCiudad.DataValueField = "cod_ciudad";
                    cboCiudad.DataBind();
                    cboCiudad.Items.Insert(0, "Escoja ciudad");
                }
                else
                {
                    cboCiudad.Items.Clear();
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}