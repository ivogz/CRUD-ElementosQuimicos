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

        public Elemento(int nAtomico, string nombre, string simbolo, int grupo, int periodo, double masaAtomica)
        {
            this.nAtomico = nAtomico;
            this.nombre = nombre;
            this.simbolo = simbolo;
            this.grupo = grupo;
            this.periodo = periodo;
            this.masaAtomica = masaAtomica;
        }



    }
}