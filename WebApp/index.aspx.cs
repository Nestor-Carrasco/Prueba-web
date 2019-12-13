using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp;

namespace WebApp
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ModeloWeb_entity modelo = new ModeloWeb_entity();
            var participante = from c in modelo.participantes
                               select c;

            gvParticipantes.DataSource = participantes.ToList();
            gvParticipantes.DataBind();

        }
    }
}