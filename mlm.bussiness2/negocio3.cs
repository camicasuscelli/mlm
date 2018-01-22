using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mlm.common.Interfaces;

namespace mlm.bussiness2
{
    public class Negocio3 : INegocio
    {
        public string getName()
        {
            return this.ToString();
        }
    }
}
