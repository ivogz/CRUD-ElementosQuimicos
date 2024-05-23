using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Laboratorio
    {
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public ETamaños Tamaño { get; set; }
        public int CantMaxElementos { get; set; }
        public List<Elemento> Elementos { get; set; }

        public Laboratorio(string nombre, string ubicacion, ETamaños tamaño)
        {
            this.Nombre = nombre;
            this.Ubicacion = ubicacion;
            this.Tamaño = tamaño;
            this.CantMaxElementos = CalcularCantidadElementosPorTamaño(tamaño);

            this.Elementos = new List<Elemento>();

        }

        protected int CalcularCantidadElementosPorTamaño(ETamaños tamaño) 
        {
            switch (tamaño) 
            {
                case ETamaños.Chico:
                    return 2;
                case ETamaños.Mediano:
                    return 10;
                case ETamaños.Grande:
                    return 25;
                case ETamaños.Enorme:
                    return 100;
                default: return 0;

            }
        }

        //SOBRECARGAS

        public override string ToString()
        {

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine(this.Nombre);
            sb.AppendLine(this.Ubicacion);
            sb.AppendLine(this.Tamaño.ToString());
            sb.AppendLine(this.CantMaxElementos.ToString());
            return sb.ToString();
        }

        public static bool operator ==(Elemento e, Laboratorio l)
        {
            foreach (Elemento elemento in l.Elementos)
            {
                if (elemento == e) { return true; }
            }

            return false;
        }

        public static bool operator !=(Elemento e, Laboratorio l)
        {
            return !(e == l);
        }

        public static Laboratorio operator +(Laboratorio l, Elemento e)
        {
            if (e != l)
            {
                l.Elementos.Add(e);
            }

            return l;
        }

        public static Laboratorio operator -(Laboratorio l, Elemento e)
        {
            if (e == l) 
            {
                l.Elementos.Remove(e);            
            }
            return l;
        }

    }
}
