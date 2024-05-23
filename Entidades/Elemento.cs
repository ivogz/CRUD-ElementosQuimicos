using System.Runtime.CompilerServices;

namespace Entidades
{
    public abstract class Elemento
    {
        protected int nAtomico;
        protected string nombre;
        protected string simbolo;
        protected int grupo;
        protected int periodo;
        protected double masaAtomica;
        protected int protones;
        protected int neutrones;



        public Elemento(int nAtomico, string nombre, string simbolo)
        {
            this.nAtomico = nAtomico;
            this.nombre = nombre;
            //operador ternario; condicion ? (si es true pasa esto) : (si es false pasa esto)
            //this.simbolo = !string.IsNullOrEmpty(nombre) ? nombre[0].ToString() : string.Empty;
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

        public virtual string IndicarUbicacion()
        {
            return ($"El elemento se ubica en grupo: {this.grupo} período: {this.periodo}");
        }

        public virtual bool ConfirmarTodosAtributosAsignados()
        {
            if (this.grupo != -1 && this.periodo != -1 && this.masaAtomica != -1) { return true; }
            else { return false; }
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

            sb.AppendLine(this.nAtomico.ToString());
            sb.AppendLine(this.nombre);
            sb.AppendLine(this.simbolo);
            sb.AppendLine(this.grupo.ToString());
            sb.AppendLine(this.periodo.ToString());
            sb.AppendLine(this.masaAtomica.ToString());
            return sb.ToString();
        }

        // FIN SOBRECARGAS OPERADORES, TO, GETHASH, EQUALS




    }

 
}