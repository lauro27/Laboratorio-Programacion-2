using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Clase11.entidades
{
    static class Serializadora
    {
        public static bool Serializar(IXML x)
        {
            try
            {
                x.Guardar("test.xml");
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public static bool Deserializar(IXML x, out object o)
        {
            try
            {
                x.Leer("test.xml", out o);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
