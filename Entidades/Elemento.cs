using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Entidades
{

    [XmlInclude(typeof(Metal))]
    [XmlInclude(typeof(NoMetal))]
    [XmlInclude(typeof(Gas))]
    public abstract class Elemento
    {
        //ATRIBUTOS
        protected int nAtomico;
        protected string nombre;
        protected string simbolo;
        protected int grupo;
        protected int periodo;
        protected double masaAtomica;
        protected int protones;
        protected int neutrones;
        protected static string tipoElemento;
        //ATRIBUTOS

        //PROPIEDADES

        public int NAtomico
        {
            get { return this.nAtomico; }
            set { this.nAtomico = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Simbolo
        {
            get { return this.simbolo; }
            set { this.simbolo = value; }
        }

        public int Grupo
        {
            get { return this.grupo; }
            set { this.grupo = value; }
        }

        public int Periodo
        {
            get { return this.periodo; }
            set { this.periodo = value; }
        }

        public double MasaAtomica
        {
            get { return this.masaAtomica; }
            set { this.masaAtomica = value; }
        }

        public int Protones
        {
            get { return this.protones; }
            set { this.protones = value; }
        }

        public int Neutrones
        {
            get { return this.neutrones; }
            set { this.neutrones = value; }
        }

        //PROPIEDADES

        public Elemento() { }

        public Elemento(int nAtomico, string nombre, string simbolo)
        {
            this.nAtomico = nAtomico;
            this.nombre = nombre;
            this.simbolo = simbolo;
            this.grupo = -1;
            this.periodo = -1;
            this.masaAtomica = -1;
            this.protones = -1;
            this.neutrones = -1;
        }

        public Elemento(int nAtomico, string nombre, string simbolo, int grupo, int periodo) : this(nAtomico, nombre, simbolo)
        {
            this.grupo = grupo;
            this.periodo = periodo;

        }

        public Elemento(int nAtomico, string nombre, string simbolo, int grupo, int periodo, double masaAtomica)
            : this(nAtomico, nombre, simbolo, grupo, periodo)
        {
            this.masaAtomica = masaAtomica;
            this.ObtenerAsignarProtonesNeutrones(masaAtomica);
        }

        protected abstract void ObtenerAsignarProtonesNeutrones(double masaAtomica);


        // SOBRECARGAS OPERADORES, EQUALS Y GETHASHCODE
        public static bool operator ==(Elemento e, Elemento e1)
        {
            if (ReferenceEquals(e, e1))
            {
                return true;
            }

            if (e is null || e1 is null)
            {
                return false;
            }

            return e.nAtomico == e1.nAtomico || e.nombre == e1.nombre || e.simbolo == e1.simbolo || (e.grupo != -1 && e.grupo == e1.grupo && e.periodo != -1 && e.periodo == e1.periodo);
        }

        public static bool operator !=(Elemento e, Elemento e1)
        {
            return !(e == e1);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Elemento)
            {
                return ((Elemento)obj == this);
            }
            else { return false;}
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(nAtomico, nombre, simbolo, grupo, periodo);
        }

        public override string ToString()
        {

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.AppendLine(" || Nombre: " +this.nombre);
            sb.AppendLine(" || Simbolo: " + this.simbolo);
            sb.AppendLine(" || Numero atomico: " + this.nAtomico.ToString());
            sb.AppendLine(" || Grupo: " + this.grupo.ToString());
            sb.AppendLine(" || Periodo: " + this.periodo.ToString());
            sb.AppendLine(" || Masa Atomica: " + this.masaAtomica.ToString());
            sb.AppendLine(" || Protones: " + this.protones.ToString());
            sb.AppendLine(" || Neutrones: " + this.neutrones.ToString());
            return sb.ToString();
        }

        // FIN SOBRECARGAS OPERADORES, TO, GETHASH, EQUALS




    }

 
}