using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class NoMetal : Elemento
    {
        protected ECategoriasNoMetales subcategoria;
        protected string estadoNatural;
        protected double puntoEbullicion;
        protected double puntoFusion;


        public ECategoriasNoMetales Categoria
        {
            get { return subcategoria; }
            set { subcategoria = value; }
        }

        public NoMetal(int nAtomico, string nombre, string simbolo, int grupo, int periodo, ECategoriasNoMetales subcategoria, double masaAtomica, string estadoNatural, double puntoEbullicion, double puntoFusion):
        base(nAtomico,nombre, simbolo, grupo, periodo, masaAtomica)
        {
            this.subcategoria = subcategoria;
            this.estadoNatural = estadoNatural;
            this.puntoEbullicion = puntoEbullicion;
            this.puntoFusion = puntoFusion;
        }




    }
}
