using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mlm.common
{
    public class Util
    {
        //agregamos un atributo privado para que se respete el singleton:
        //static: está en todas las instancias en el mismo lugar de memoria.
        private static volatile Util _instance;

        //creamos un constructor privado, porque por defecto siempre viene público y no
        //lo queremos así:

        private Util()
        {
            
        }

        public int Test()
        {
            return 1;
        }

        //getter y setter es una propiedad.
        public static Util Instance {
            get
            {
                if(_instance == null)
                {
                    /*QUE ES LOCK?:
                     * bloquea lo que está adentro. ES UN MUTEX!!!
                    */
                    lock (typeof(Util))
                    {
                        //esto está por un caso excepcional por si dos hilos entran al if.
                        //osea lo preguntamos por seguridad.
                        if (_instance == null)
                        {
                            _instance = new Util();
                        }
                    };
                    
                }
                return _instance;
                
            }
        }
    }
}
