using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Metal : Elemento, IcambiarInformacion
    {
        protected ECategoriasMetales subcategoria;
        protected int cantidadRadioactividad;
        protected string color;

        public ECategoriasMetales Subcategoria
        {
            get { return this.subcategoria; }
            set { this.subcategoria = value; }
        }

        public int CantidadRadioactividad
        {
            get { return this.cantidadRadioactividad; }
            set { this.cantidadRadioactividad = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }


        static Metal() { Metal.tipoElemento = "M"; }

        public Metal() { }

        public Metal(int nAtomico, string nombre, string simbolo, ECategoriasMetales subcategoria) : base(nAtomico, nombre, simbolo)
        {
            this.subcategoria=subcategoria;
            this.cantidadRadioactividad = -1;
            this.color = "Se desconoce";
        }

        public Metal(int nAtomico, string nombre, string simbolo, int grupo, int periodo, ECategoriasMetales subcategoria) 
            : this(nAtomico, nombre, simbolo, subcategoria)
        {
            base.grupo = grupo;
            base.periodo = periodo;

        }

        public Metal(int nAtomico, string nombre, string simbolo, int grupo, int periodo, ECategoriasMetales subcategoria, double masaAtomica, int cantidadRadioactividad, string color) :
        base(nAtomico, nombre, simbolo, grupo, periodo, masaAtomica)
        {
            this.subcategoria = subcategoria;
            this.cantidadRadioactividad = cantidadRadioactividad;
            this.color = color;
        }

        protected override void ObtenerAsignarProtonesNeutrones(double masaAtomica)
        {

            double protonesDouble = this.masaAtomica / 2 ;
            double neutronesDouble = this.masaAtomica / 2;

            this.neutrones = (int)neutronesDouble;
            this.protones = (int)protonesDouble;
        }

        #region interface
        public override string MostrarDescripcion()
        {

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(base.MostrarDescripcion());
            sb.AppendLine(" || Subcategoria: " + this.subcategoria.ToString());
            sb.AppendLine(" || Cantidad de radioactividad: " + this.cantidadRadioactividad.ToString());
            sb.AppendLine(" || Color: " + this.color);

            return sb.ToString();

        }

        public override string MostrarTipo()
        {
            return $"Elemento {this.nombre} es: Metal";
        }

        #endregion



        //POLIMORFISMO TOSTRING

        

    }
}
