using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class AccesoDatos
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

        private List<Elemento> ObtenerListaBD()
        {
            List<Elemento> lista = new List<Elemento>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT nAtomico, nombre, simbolo, grupo, periodo, masaAtomica, protones, neutrones, subcategoria, tipoElemento, lugarDeObtencion, usoPrincipal, cantidadRadioactividad, color, estadoNatural, puntoEbullicion, puntoFusion FROM dato WHERE tipoElemento = G";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    string tipoElemento = lector["tipoElemento"].ToString();

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
                        lector["usoPrincipal"].ToString()

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
                        (ECategoriasMetales)(int)lector["subcategoria"],
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
                        (EEstados)(int)lector["estadoNatural"],
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

        





    }
}

