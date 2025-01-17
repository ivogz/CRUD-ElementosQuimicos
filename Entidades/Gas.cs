﻿using System;
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

        public string LugarDeObtencion
        {
            get { return this.lugarDeObtencion; }
            set { this.lugarDeObtencion = value; }
        }

        public string UsoPrincipal
        {
            get { return this.usoPrincipal; }
            set { this.usoPrincipal = value; }
        }

        public ECategoriasGases Subcategoria
        {
            get { return this.subcategoria; }
            set { this.subcategoria = value; }
        }

        public Gas() { }

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

        protected override void ObtenerAsignarProtonesNeutrones(double masaAtomica)
        {

            double protonesDouble = this.masaAtomica * 0.7;
            double neutronesDouble = this.masaAtomica * 0.3;

            this.neutrones = (int)neutronesDouble;
            this.protones = (int)protonesDouble;

        }


        //POLIMORFISMO TOSTRING

        public override string ToString()
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine("Subcategoria: " + this.subcategoria.ToString());
            sb.AppendLine("Lugar de obtencion: "+this.lugarDeObtencion);
            sb.AppendLine("Uso principal: "+this.usoPrincipal);

            return sb.ToString();


        }

    }
}
