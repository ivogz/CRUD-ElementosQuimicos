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
        protected EEstados estadoNatural;
        protected double puntoEbullicion;
        protected double puntoFusion;


        public ECategoriasNoMetales Categoria
        {
            get { return subcategoria; }
            set { subcategoria = value; }
        }
        public EEstados EstadoNatural
        {
            get { return estadoNatural; }
            set { estadoNatural = value; }
        }

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




    }
}
