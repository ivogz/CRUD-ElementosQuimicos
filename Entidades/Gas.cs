using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Gas : Elemento
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
