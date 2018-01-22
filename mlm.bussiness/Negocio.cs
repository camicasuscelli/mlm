using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mlm.common.Interfaces;

namespace mlm.bussiness
{
    //
    public class Negocio : INegocio
    {
        public string getName()
        {
            return "negocio1";
            //throw new NotImplementedException();
        }
    }
}
