using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gas : Elemento
    {

        protected ECategoriasGases subcategoria;
        protected string lugarDeObtencion;
        protected string usoPrincipal;

        public ECategoriasGases Categoria
        {
            get { return subcategoria; }
            set { subcategoria = value; }
        }

        public Gas(int nAtomico, string nombre, string simbolo) : base(nAtomico, nombre, simbolo)
        {
            this.subcategoria = ECategoriasGases.GasNoble;
            this.lugarDeObtencion = "Se desconoce";
            this.usoPrincipal = "Se desconoce";
        }

        public Gas(int nAtomico, string nombre, string simbolo, int grupo, int periodo):this(nAtomico, nombre, simbolo)
        {
            base.grupo = grupo;
            base.periodo = periodo;

        }

        public Gas(int nAtomico, string nombre, string simbolo, int grupo, int periodo, double masaAtomica, string lugarDeObtencion, string usoPrincipal) :
        base(nAtomico, nombre, simbolo, grupo, periodo, masaAtomica)
        {
            this.subcategoria = ECategoriasGases.GasNoble;
            this.lugarDeObtencion = lugarDeObtencion;
            this.usoPrincipal = usoPrincipal;
        }

        public override bool ConfirmarTodosAtributosAsignados()
        {
            if (base.ConfirmarTodosAtributosAsignados() && this.lugarDeObtencion != "Se desconoce" && this.usoPrincipal != "Se desconoce") 
                { return true; }
            else { return false; }
        }

        protected override void ObtenerAsignarProtonesNeutrones(double masaAtomica)
        {
            double protonesDouble;
            double neutronesDouble;

            protonesDouble = this.masaAtomica * 0.7;
            neutronesDouble = this.masaAtomica * 0.3;

            this.neutrones = (int)neutronesDouble;
            this.protones = (int)protonesDouble;

        }


        //POLIMORFISMO TOSTRING

        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine(this.subcategoria.ToString());
            sb.AppendLine(this.lugarDeObtencion);
            sb.AppendLine(this.usoPrincipal);

            return sb.ToString();


        }

    }
}
