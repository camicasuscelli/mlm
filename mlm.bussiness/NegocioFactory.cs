using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mlm.common.Interfaces;
using System.Reflection;

namespace mlm.bussiness
{
    public class NegocioFactory
    {
        //es una clase singleton asique copiamos el código.

        //agregamos un atributo privado para que se respete el singleton:
        //static: está en todas las instancias en el mismo lugar de memoria.
        private static volatile NegocioFactory _instance;

        //creamos un constructor privado, porque por defecto siempre viene público y no
        //lo queremos así:

        private NegocioFactory()
        {

        }

        /*public int Test()
        {
            return 1;
        }*/

            //FABRICO UN ELEMENTO DEPENDE
        public INegocio crearNegocio(String name)
        {
            switch (name)
            {
                case "negocio1":
                    return new Negocio();
                    //break;
                case "holis ahre":
                    return new Negocio2();
                   // break;
                default:
                    //saraza va el nombre del assembly. saraza 2 tiene el assembly y clase.
                    object obj = Assembly.Load(new AssemblyName("mlm.bussiness2")).CreateInstance("mlm.bussiness2.Negocio3");
                    return (INegocio)obj;
                    
            }
            
        }

        //getter y setter es una propiedad.
        public static NegocioFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    /*QUE ES LOCK?:
                     * bloquea lo que está adentro. ES UN MUTEX!!!
                    */
                    lock (typeof(NegocioFactory))
                    {
                        //esto está por un caso excepcional por si dos hilos entran al if.
                        //osea lo preguntamos por seguridad.
                        if (_instance == null)
                        {
                            _instance = new NegocioFactory();
                        }
                    };

                }
                return _instance;

            }
        }
    }
}
