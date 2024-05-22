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

        public Gas(int nAtomico, string nombre, string simbolo, int grupo, int periodo, ECategoriasGases subcategoria, double masaAtomica, string lugarDeObtencion, string usoPrincipal) :
        base(nAtomico, nombre, simbolo, grupo, periodo, masaAtomica)
        {
            this.subcategoria = subcategoria;
            this.lugarDeObtencion = lugarDeObtencion;
            this.usoPrincipal = usoPrincipal;
        }



    }
}
