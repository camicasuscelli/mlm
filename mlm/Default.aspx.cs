using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//hay que agregar la clase:
using mlm.common;
using mlm.bussiness;
using mlm.common.Interfaces;

namespace mlm
{
    public partial class _Default : Page
    {
        //uno de los primeros códigos que se ejecutan cuando se abre la pag
        protected void Page_Load(object sender, EventArgs e)
        {
            //int variable = Util.Instance.Test();
           //try { 
            String nombre = NegocioFactory.Instance.crearNegocio("ahre").getName();
            Response.Write(nombre);
            Response.End();
           // }catch(Exception)
           /* {
                Response.Write("Lo contrario");
                Response.End();
            }*/
        }
    }
}