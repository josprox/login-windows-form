using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace idusers.Modelo
{
    public partial class Conexion_php : Form
    {
        public async Task<string> EnviarPeticionPost(string url, string nombreUsuario, string correo, string contrasena)
        {
            using (var httpClient = new HttpClient())
            {
                // Crea el contenido de la petición
                var datos = new
                {
                    usuario = nombreUsuario,
                    email = correo,
                    password = contrasena
                };

                var contenido = new StringContent(
                    Newtonsoft.Json.JsonConvert.SerializeObject(datos),
                    Encoding.UTF8,
                    "application/json"
                );

                // Envía la petición POST
                var respuesta = await httpClient.PostAsync(url, contenido);

                // Lee y retorna la respuesta
                return await respuesta.Content.ReadAsStringAsync();
            }
        }


    }
}
