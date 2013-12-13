using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;

namespace Website.CustomAttributes
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCUIT();

                lblMensaje.Text = "Todo bien";
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        private void ValidarCUIT()
        {
            var p = new Persona { CUIT = txtCUIT.Text };
            p.Validar();
        }
    }
}