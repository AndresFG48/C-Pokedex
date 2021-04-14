using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; //La libreria de MySql.
using System.Data; //La libreria del DataTable.

namespace PruebaBBDD
{
    class Conexion
    {
        public MySqlConnection conexion; //Variable que se encarga de la conexion con el servidor MySql.

        public Conexion  ()
        { //El constructor de la clase.
            conexion = new MySqlConnection("Server=127.0.0.1; Database=listapokemons; Uid=root; Pwd=; Port=3306");
        }

        public DataTable getPokemons()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM pokemon", conexion);
                MySqlDataReader resutaldo =  consulta.ExecuteReader(); //Guarda el resultado de la consulta.
                DataTable pokemons = new DataTable(); //Formato que espera el datagridview.
                pokemons.Load(resutaldo); //Convierte MySqlDataReader en DataTable.
                conexion.Close();
                return pokemons;
            }

            catch (MySqlException e)
            {
                throw e;
            }

        }

        public DataTable getPokemonsPorID(int _id) //Este guion delante se refiere a que es el parametro que nos han pasado.
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM pokemon WHERE id ='" + _id + "'", conexion);
                MySqlDataReader resutaldo = consulta.ExecuteReader(); //Guarda el resultado de la consulta.
                DataTable pokemons = new DataTable(); //Formato que espera el datagridview.
                pokemons.Load(resutaldo); //Convierte MySqlDataReader en DataTable.
                conexion.Close();
                return pokemons;
            }

            catch (MySqlException e)
            {
                throw e;
            }

        }
    }
}
