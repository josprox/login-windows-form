using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idusers
{
    public partial class Salario
    {
        private static Dictionary<string, object> arg = new Dictionary<string, object>();

        public Salario()
        {
            arg = new Dictionary<string, object>();
        }

        public void AgregarValores(int id, string nombre, string contra, double sueldoBruto, double salarioPorHora=0, double horasExtras=0, double comisiones = 0)
        {
            arg["id"] = id;
            arg["nombre"] = nombre;
            arg["contra"] = contra;
            arg["sueldo"] = sueldoBruto;
            arg["salario_x_hora"] = salarioPorHora;
            arg["horas_extras"] = horasExtras;
            arg["comisiones"] = comisiones;
        }

        public Dictionary<string, object> ObtenerValores()
        {
            return arg;
        }
    }
}
