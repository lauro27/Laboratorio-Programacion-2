using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11.entidades
{
    interface IXML
    {
        bool Guardar(string s);

        bool Leer(string s, out object o);
    }
}
