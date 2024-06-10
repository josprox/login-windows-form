using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace idusers
{
    public static class DatosCompartidos
    {
        // Define una variable pública y estática para almacenar los datos compartidos
        public static Dictionary<string, object> DatosUsuario { get; set; }

    }
}
