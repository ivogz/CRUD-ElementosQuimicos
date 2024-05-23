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

        public List<Elemento> OrdenarPor(AtributosElemento atributo, List<Elemento> lista, bool ascendente )
        {

            Comparison<Elemento> comparison;

            switch (atributo)
            {
                case AtributosElemento.NumeroAtomico:
                    comparison = (x, y) => x.NAtomico.CompareTo(y.NAtomico);
                    break;
                case AtributosElemento.Nombre:
                    comparison = (x, y) => x.Nombre.CompareTo(y.Nombre);
                    break;
                case AtributosElemento.Simbolo:
                    comparison = (x, y) => x.Simbolo.CompareTo(y.Simbolo);
                    break;
                case AtributosElemento.Grupo:
                    comparison = (x, y) => x.Grupo.CompareTo(y.Grupo);
                    break;
                case AtributosElemento.Periodo:
                    comparison = (x, y) => x.Periodo.CompareTo(y.Periodo);
                    break;
                case AtributosElemento.MasaAtomica:
                    comparison = (x, y) => x.MasaAtomica.CompareTo(y.MasaAtomica);
                    break;
                case AtributosElemento.Protones:
                    comparison = (x, y) => x.Protones.CompareTo(y.Protones);
                    break;
                case AtributosElemento.Neutrones:
                    comparison = (x, y) => x.Neutrones.CompareTo(y.Neutrones);
                    break;
                default: throw new ArgumentException("Atributo para ordenar no valido");
            }

            lista.Sort(comparison);

            if (!ascendente)
            {
                lista.Reverse();
            }
            
            return lista;
        }



        //SOBRECARGAS

        public override string ToString()
        {

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine(this.Nombre);
            sb.AppendLine(this.Ubicacion);
            sb.AppendLine(this.Tamaño.ToString());
            sb.AppendLine(this.CantMaxElementos.ToString());
            sb.AppendLine();

            foreach (Elemento e in this.Elementos)
            {
                sb.AppendLine(e.ToString());
            }

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
        // FIN SOBRECARGAS
    }
}
