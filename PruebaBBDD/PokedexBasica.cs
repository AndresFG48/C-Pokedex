using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaBBDD
{
    public partial class PokedexBasica : Form
    {
        Conexion miConexion = new Conexion();
        int idActual = 1; //Valor inicial de id de getPokemonsPorID.
        public PokedexBasica()
        {
            InitializeComponent();
            asignaPokemon();
        }

        //Boton disminuir.
        private void button1_Click(object sender, EventArgs e)
        {
            idActual--;
            if (idActual <1)
            {
                idActual = 151; //Con este metodo creamos un carrusel.
            }
            asignaPokemon();
        }

        //Boton aumentar.
        private void button2_Click(object sender, EventArgs e)
        {
            idActual++;
            if (idActual > 151)
            {
                idActual = 1; //Con este metodo creamos un carrusel .
            }
            asignaPokemon();
        }

        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }

        private void asignaPokemon()
        {
            //Con este metodo dibujamos el nombre y la imagen del pokemon
            DataTable pokemonElegido = miConexion.getPokemonsPorID(idActual);
            nombrePokemon.Text = pokemonElegido.Rows[0]["nombre"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])pokemonElegido.Rows[0]["imagen"]);
        }
    }
}
