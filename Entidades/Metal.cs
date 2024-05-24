using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Metal : Elemento
    {
        protected ECategoriasMetales subcategoria;
        protected int cantidadRadioactividad;
        protected string color;

        public ECategoriasMetales Categoria
        {
            get { return subcategoria; }
            set { this.subcategoria = value; }
        }

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

        public override bool ConfirmarTodosAtributosAsignados()
        {
            if (base.ConfirmarTodosAtributosAsignados() && this.cantidadRadioactividad != -1 && this.color != "Se desconoce") 
                {return true;}
            else {return false;}
        }

        protected override void ObtenerAsignarProtonesNeutrones(double masaAtomica)
        {

            double protonesDouble = this.masaAtomica / 2 ;
            double neutronesDouble = this.masaAtomica / 2;

            this.neutrones = (int)neutronesDouble;
            this.protones = (int)protonesDouble;
        }


        //POLIMORFISMO TOSTRING

        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine(this.subcategoria.ToString());
            sb.AppendLine(this.cantidadRadioactividad.ToString());
            sb.AppendLine(this.color);

            return sb.ToString();


        }

    }
}
