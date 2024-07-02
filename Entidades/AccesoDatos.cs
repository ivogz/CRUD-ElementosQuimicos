using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AccesoDatos
    {

        #region Atributos

        private static string cadena_conexion;
        private SqlConnection conexion;
        private SqlCommand? comando;
        private SqlDataReader? lector;

        #endregion

        #region Constructores

        static AccesoDatos()
        {
            AccesoDatos.cadena_conexion = Properties.Resources.miConexion;
        }

        public AccesoDatos()
        {
            // CREO UN OBJETO SQLCONECTION
            this.conexion = new SqlConnection(AccesoDatos.cadena_conexion);
        }

        #endregion

        public bool ProbarConexion()
        {
            bool rta = true;

            try
            {
                this.conexion.Open();
            }
            catch (Exception e)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        public List<Elemento> ObtenerListaBD()
        {
            List<Elemento> lista = new List<Elemento>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT nAtomico, nombre, simbolo, grupo, periodo, masaAtomica, protones, neutrones, subcategoria, tipoElemento, lugarDeObtencion, UsoPrincipal, cantidadRadioactividad, color, estadoNatural, puntoEbullicion, puntoFusion FROM Elementos";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    string tipoElemento = lector["tipoElemento"].ToString().Trim();

                    switch (tipoElemento)
                    {
                        case "G":


                            Gas gas = new Gas
                        (

                        (int)lector["nAtomico"],
                        lector["nombre"].ToString(),
                        lector["simbolo"].ToString(),
                        (int)lector["grupo"],
                        (int)lector["periodo"],
                        double.Parse(lector["masaAtomica"].ToString()),
                        lector["lugarDeObtencion"].ToString(),
                        lector["UsoPrincipal"].ToString()

                        );

                            lista.Add(gas);
                            break;

                        case "M":

                            Metal metal = new Metal
                        (

                        (int)lector["nAtomico"],
                        lector["nombre"].ToString(),
                        lector["simbolo"].ToString(),
                        (int)lector["grupo"],
                        (int)lector["periodo"],
                        //(ETamaño)Enum.Parse(typeof(ETamaño), lector["tamañoGarras"].ToString());
                        (ECategoriasMetales)Enum.Parse(typeof(ECategoriasMetales),lector["subcategoria"].ToString()),
                        double.Parse(lector["masaAtomica"].ToString()),
                        (int)lector["cantidadRadioactividad"],
                        lector["color"].ToString()



                        );
                            lista.Add(metal);
                            break;

                        case "NM":


                            NoMetal noMetal = new NoMetal
                        (

                        (int)lector["nAtomico"],
                        lector["nombre"].ToString(),
                        lector["simbolo"].ToString(),
                        (int)lector["grupo"],
                        (int)lector["periodo"],
                        double.Parse(lector["masaAtomica"].ToString()),
                        (EEstados)Enum.Parse(typeof(EEstados), lector["estadoNatural"].ToString()),
                        double.Parse(lector["puntoEbullicion"].ToString()),
                        double.Parse(lector["puntoFusion"].ToString())
                        );
                            lista.Add(noMetal);
                            break;

                    }

                }

                lector.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return lista;
        }

        public List<Elemento> CompararListas(List<Elemento> listaRecibida)
        {
            List<Elemento> lista = ObtenerListaBD();
            List<Elemento> listaSinDuplicados = new List<Elemento>();


            foreach (Elemento e in listaRecibida)
            {
                bool encontrado = false;
                foreach (Elemento e2 in lista)
                {
                    if (e2 == e)
                    {
                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado)
                {
                    listaSinDuplicados.Add(e);
                }
            }

            return listaSinDuplicados;
        }

        public void SubirLista(List<Elemento> lista)
        {

            List <Elemento> listaSinDuplicados = CompararListas(lista);


            foreach (Elemento ele in listaSinDuplicados)
            {
                AgregarElemento(ele);
            }


        }


        public bool AgregarElemento(Elemento param)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@nAtomico", param.NAtomico);
                this.comando.Parameters.AddWithValue("@nombre", param.Nombre);
                this.comando.Parameters.AddWithValue("@simbolo", param.Simbolo);
                this.comando.Parameters.AddWithValue("@grupo", param.Grupo);
                this.comando.Parameters.AddWithValue("@periodo" , param.Periodo);
                this.comando.Parameters.AddWithValue("@masaAtomica", param.MasaAtomica);
                this.comando.Parameters.AddWithValue("@protones" , param.Protones);
                this.comando.Parameters.AddWithValue("@neutrones", param.Neutrones);

                string sql;
               
                switch (param)
                {
                    case Gas gas:
                        this.comando.Parameters.AddWithValue("@subcategoria", gas.Subcategoria);
                        this.comando.Parameters.AddWithValue("@tipoElemento", "G");
                        this.comando.Parameters.AddWithValue("@lugarDeObtencion", gas.LugarDeObtencion);
                        this.comando.Parameters.AddWithValue("@UsoPrincipal", gas.UsoPrincipal);

                        sql ="INSERT INTO Elementos (nAtomico, nombre, simbolo, grupo, periodo, masaAtomica, protones, neutrones, subcategoria, tipoElemento, lugarDeObtencion, UsoPrincipal) ";
                        sql += "VALUES(@nAtomico, @nombre, @simbolo, @grupo, @periodo, @masaAtomica, @protones, @neutrones, @subcategoria, @tipoElemento, @lugarDeObtencion, @usoPrincipal)";
                        break;

                    case Metal metal:
                        this.comando.Parameters.AddWithValue("@subcategoria", metal.Subcategoria);
                        this.comando.Parameters.AddWithValue("@tipoElemento", "M");
                        this.comando.Parameters.AddWithValue("@cantidadRadioactividad", metal.CantidadRadioactividad);
                        this.comando.Parameters.AddWithValue("@color", metal.Color);

                        sql = "INSERT INTO Elementos (nAtomico, nombre, simbolo, grupo, periodo, masaAtomica, protones, neutrones, subcategoria, tipoElemento, cantidadRadioactividad, color) ";
                        sql += "VALUES(@nAtomico, @nombre, @simbolo, @grupo, @periodo, @masaAtomica, @protones, @neutrones, @subcategoria, @tipoElemento, @cantidadRadioactividad, @color)";

                        break;

                    case NoMetal noMetal:
                        this.comando.Parameters.AddWithValue("@subcategoria", noMetal.Subcategoria);
                        this.comando.Parameters.AddWithValue("@tipoElemento", "NM");
                        this.comando.Parameters.AddWithValue("@estadoNatural", noMetal.EstadoNatural);
                        this.comando.Parameters.AddWithValue("@puntoEbullicion", noMetal.PuntoEbullicion);
                        this.comando.Parameters.AddWithValue("@puntoFusion", noMetal.PuntoFusion);

                        sql = "INSERT INTO Elementos (nAtomico, nombre, simbolo, grupo, periodo, masaAtomica, protones, neutrones, subcategoria, tipoElemento, estadoNatural, puntoEbullicion, puntoFusion) ";
                        sql += "VALUES(@nAtomico, @nombre, @simbolo, @grupo, @periodo, @masaAtomica, @protones, @neutrones, @subcategoria, @tipoElemento, @estadoNatural, @puntoEbullicion, @puntoFusion)";

                        break;
                    default:
                        sql = "nada";
                        break;

                }


                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception e)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        public bool ModificarElemento(Elemento param)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@nAtomico", param.NAtomico);
                this.comando.Parameters.AddWithValue("@nombre", param.Nombre);
                this.comando.Parameters.AddWithValue("@simbolo", param.Simbolo);
                this.comando.Parameters.AddWithValue("@grupo", param.Grupo);
                this.comando.Parameters.AddWithValue("@periodo", param.Periodo);
                this.comando.Parameters.AddWithValue("@masaAtomica", param.MasaAtomica);
                this.comando.Parameters.AddWithValue("@protones", param.Protones);
                this.comando.Parameters.AddWithValue("@neutrones", param.Neutrones);

                string sql = "UPDATE Elementos ";
                sql += "SET nombre = @nombre, simbolo = @simbolo, grupo = @grupo, periodo = @periodo, masaAtomica = @masaAtomica, protones = @protones, neutrones = @neutrones, subcategoria = @subcategoria, tipoElemento = @tipoElemento, ";

                switch (param)
                {
                    case Gas gas:
                        this.comando.Parameters.AddWithValue("@subcategoria", gas.Subcategoria);
                        this.comando.Parameters.AddWithValue("@tipoElemento", "G");
                        this.comando.Parameters.AddWithValue("@lugarDeObtencion", gas.LugarDeObtencion);
                        this.comando.Parameters.AddWithValue("@UsoPrincipal", gas.UsoPrincipal);

                        sql += "lugarDeObtencion = @lugarDeObtencion, UsoPrincipal = @UsoPrincipal ";

                        break;

                    case Metal metal:
                        this.comando.Parameters.AddWithValue("@subcategoria", metal.Subcategoria);
                        this.comando.Parameters.AddWithValue("@tipoElemento", "M");
                        this.comando.Parameters.AddWithValue("@cantidadRadioactividad", metal.CantidadRadioactividad);
                        this.comando.Parameters.AddWithValue("@color", metal.Color);

                        sql += "cantidadRadioactividad = @cantidadRadioactividad, color = @color ";

                        break;

                    case NoMetal noMetal:
                        this.comando.Parameters.AddWithValue("@subcategoria", noMetal.Subcategoria);
                        this.comando.Parameters.AddWithValue("@tipoElemento", "NM");
                        this.comando.Parameters.AddWithValue("@estadoNatural", noMetal.EstadoNatural);
                        this.comando.Parameters.AddWithValue("@puntoEbullicion", noMetal.PuntoEbullicion);
                        this.comando.Parameters.AddWithValue("@puntoFusion", noMetal.PuntoFusion);

                        sql += "estadoNatural = @estadoNatural, puntoEbullicion = @puntoEbullicion, puntoFusion = @puntoFusion ";

                        break;
                    default:
                        sql = "nada ";
                        break;

                }

                sql += "WHERE nAtomico = @nAtomico";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch(Exception)
            {

                rta = false;

            }
            finally
            {

                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }


            }

            return rta;





        }

        public bool EliminarElemento(Elemento param)
        {

            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@nAtomico", param.NAtomico);

                string sql = "DELETE FROM Elementos ";
                sql += "WHERE nAtomico = @nAtomico";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }



    }
}

