using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PruebaBBDD
{
    public partial class evolucines : Form
    {
        Conexion miConexion = new Conexion();
        public evolucines(int idActual)
        {
            InitializeComponent();
            DataTable pokemonElegido = miConexion.getPokemonsPorID(idActual);
            Nombre.Text = pokemonElegido.Rows[0]["nombre"].ToString();
            pokemon.Image = convierteBlobAImagen((byte[])pokemonElegido.Rows[0]["imagen"]);
            if (pokemonElegido.Rows[0]["posEvolucion"] != DBNull.Value)
            {
                DataTable pokemonElegido_1 = miConexion.getPokemonsPorID(idActual + 1);
                Pos.Text = pokemonElegido_1.Rows[0]["nombre"].ToString();
                pos_pokemon.Image = convierteBlobAImagen((byte[])pokemonElegido_1.Rows[0]["imagen"]);
            }

            else
            {
                Pos.Text = "";
            }

            if (pokemonElegido.Rows[0]["preEvolucion"] != DBNull.Value)
            {
                DataTable pokemonElegido_2 = miConexion.getPokemonsPorID(idActual - 1);
                Pre.Text = pokemonElegido_2.Rows[0]["nombre"].ToString();
                pre_pokemon.Image = convierteBlobAImagen((byte[])pokemonElegido_2.Rows[0]["imagen"]);
            }

            else
            {
                Pre.Text = "";
            }
        }

        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }
    }
}
