using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NoMetal : Elemento
    {
        protected ECategoriasNoMetales subcategoria;
        protected EEstados estadoNatural;
        protected double puntoEbullicion;
        protected double puntoFusion;


        public ECategoriasNoMetales Subcategoria
        {
            get { return this.subcategoria; }
            set { this.subcategoria = value; }
        }
        public EEstados EstadoNatural
        {
            get { return this.estadoNatural; }
            set { this.estadoNatural = value; }
        }
        public double PuntoEbullicion
        {
            get { return this.puntoEbullicion; }
            set { this.puntoEbullicion = value; }
        }
        public double PuntoFusion
        {
            get { return this.puntoFusion; }
            set { this.puntoFusion = value; }
        }

        static NoMetal() { NoMetal.tipoElemento = "NM"; }

        public NoMetal() { }

        public NoMetal(int nAtomico, string nombre, string simbolo) : base(nAtomico, nombre, simbolo)
        {
            this.subcategoria = ECategoriasNoMetales.NoMetalReactivo;
            this.estadoNatural = EEstados.Desconocido;
            this.puntoEbullicion = -1;
            this.puntoEbullicion = -1;
        }

        public NoMetal(int nAtomico, string nombre, string simbolo, int grupo, int periodo)
            : this(nAtomico, nombre, simbolo)
        {
            base.grupo = grupo;
            base.periodo = periodo;

        }

        public NoMetal(int nAtomico, string nombre, string simbolo, int grupo, int periodo, double masaAtomica, EEstados estadoNatural, double puntoEbullicion, double puntoFusion):
        base(nAtomico,nombre, simbolo, grupo, periodo, masaAtomica)
        {
            this.subcategoria = ECategoriasNoMetales.NoMetalReactivo;
            this.estadoNatural = estadoNatural;
            this.puntoEbullicion = puntoEbullicion;
            this.puntoFusion = puntoFusion;
        }

        protected override void ObtenerAsignarProtonesNeutrones(double masaAtomica)
        {

            double protonesDouble = this.masaAtomica * 0.6;
            double neutronesDouble = this.masaAtomica * 0.4;

            this.neutrones = (int)neutronesDouble;
            this.protones = (int)protonesDouble;

        }

        //POLIMORFISMO TOSTRING

        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine(" || Subcategoria: " + this.subcategoria.ToString());
            sb.AppendLine(" || Estado natural: " + this.estadoNatural.ToString());
            sb.AppendLine(" || Punto de ebullicion: " + this.puntoEbullicion.ToString());
            sb.AppendLine(" || Punto de fusion: " + this.puntoFusion.ToString());

            return sb.ToString();


        }


    }
}
