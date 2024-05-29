using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private string apellido;
        private string nombre;
        private int legajo;
        private string correo;
        private string clave;
        private string perfil;

        public Usuario()
        {

        }


        [JsonPropertyName("apellido")]
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }


        [JsonPropertyName("nombre")]
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }


        [JsonPropertyName("legajo")]
        public int Legajo
        {
            get
            {
                return this.legajo;
            }
            set
            {
                this.legajo = value;
            }
        }


        [JsonPropertyName("correo")]
        public string Correo
        {
            get
            {
                return this.correo;
            }
            set
            {
                this.correo = value;
            }
        }


        [JsonPropertyName("clave")]
        public string Clave
        {
            get
            {
                return this.clave;
            }
            set
            {
                this.clave = value;
            }
        }


        [JsonPropertyName("perfil")]
        public string Perfil
        {
            get
            {
                return this.perfil;
            }
            set
            {
                this.perfil = value;
            }
        }

        public string MostrarInfo()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append($"Apellido: {this.apellido} || ");
            sb.Append($"Nombre: {this.nombre} || ");
            sb.Append($"Legajo: {this.legajo.ToString()} || ");
            sb.Append($"Correo: {this.correo} || ");
            sb.Append($"Clave: {this.clave} || ");
            sb.Append($"Perfil: {this.perfil} || ");

            return sb.ToString();
        }
    }
}

