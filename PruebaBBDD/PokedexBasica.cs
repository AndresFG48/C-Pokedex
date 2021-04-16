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

            //Con esto dibujamos el peso y la altura.
            label5.Text = pokemonElegido.Rows[0]["peso"].ToString();
            label6.Text = pokemonElegido.Rows[0]["altura"].ToString();

            //Con esto dibujamos los movimientos.
            label1.Text = pokemonElegido.Rows[0]["movimiento1"].ToString();
            label2.Text = pokemonElegido.Rows[0]["movimiento2"].ToString();
            label3.Text = pokemonElegido.Rows[0]["movimiento3"].ToString();
            label4.Text = pokemonElegido.Rows[0]["movimiento4"].ToString();

            //Con esto la descripcion.
            descripcion.Text = pokemonElegido.Rows[0]["descripcion"].ToString();

            //Con esto dibujamos el tipo1 de pokemon.
            switch (pokemonElegido.Rows[0]["tipo1"].ToString())
            {
                case "Acero": pictureBox2.Image = Properties.Resources.Tipo_acero; break;
                case "Agua": pictureBox2.Image = Properties.Resources.Tipo_agua; break;
                case "Bicho": pictureBox2.Image = Properties.Resources.Tipo_bicho; break;
                case "Dragon": pictureBox2.Image = Properties.Resources.Tipo_drag_3Fn; break;
                case "Electrico": pictureBox2.Image = Properties.Resources.Tipo_el_3Fctrico; break;
                case "Fantasma": pictureBox2.Image = Properties.Resources.Tipo_fantasma; break;
                case "Fuego": pictureBox2.Image = Properties.Resources.Tipo_fuego; break;
                case "Hada": pictureBox2.Image = Properties.Resources.Tipo_hada; break;
                case "Hielo": pictureBox2.Image = Properties.Resources.Tipo_hielo; break;
                case "Lucha": pictureBox2.Image = Properties.Resources.Tipo_lucha; break;
                case "Normal": pictureBox2.Image = Properties.Resources.Tipo_normal; break;
                case "Planta": pictureBox2.Image = Properties.Resources.Tipo_planta; break;
                case "Psiquico": pictureBox2.Image = Properties.Resources.Tipo_ps_3Fquico; break;
                case "Roca": pictureBox2.Image = Properties.Resources.Tipo_roca; break;
                case "Siniestro": pictureBox2.Image = Properties.Resources.Tipo_siniestro; break;
                case "Tierra": pictureBox2.Image = Properties.Resources.Tipo_tierra; break;
                case "Veneno": pictureBox2.Image = Properties.Resources.Tipo_veneno; break;
                case "Volador": pictureBox2.Image = Properties.Resources.Tipo_volador; break;
                default: pictureBox2.Image = Properties.Resources.Tipo__3F_3F_3F; break;
            }

            //Con esto dibujamos el tipo2 de pokemon.
            switch (pokemonElegido.Rows[0]["tipo2"].ToString())
            {
                case "Acero": pictureBox3.Image = Properties.Resources.Tipo_acero; break;
                case "Agua": pictureBox3.Image = Properties.Resources.Tipo_agua; break;
                case "Bicho": pictureBox3.Image = Properties.Resources.Tipo_bicho; break;
                case "Dragon": pictureBox3.Image = Properties.Resources.Tipo_drag_3Fn; break;
                case "Electrico": pictureBox3.Image = Properties.Resources.Tipo_el_3Fctrico; break;
                case "Fantasma": pictureBox3.Image = Properties.Resources.Tipo_fantasma; break;
                case "Fuego": pictureBox3.Image = Properties.Resources.Tipo_fuego; break;
                case "Hada": pictureBox3.Image = Properties.Resources.Tipo_hada; break;
                case "Hielo": pictureBox3.Image = Properties.Resources.Tipo_hielo; break;
                case "Lucha": pictureBox3.Image = Properties.Resources.Tipo_lucha; break;
                case "Normal": pictureBox3.Image = Properties.Resources.Tipo_normal; break;
                case "Planta": pictureBox3.Image = Properties.Resources.Tipo_planta; break;
                case "Psiquico": pictureBox3.Image = Properties.Resources.Tipo_ps_3Fquico; break;
                case "Roca": pictureBox3.Image = Properties.Resources.Tipo_roca; break;
                case "Siniestro": pictureBox3.Image = Properties.Resources.Tipo_siniestro; break;
                case "Tierra": pictureBox3.Image = Properties.Resources.Tipo_tierra; break;
                case "Veneno": pictureBox3.Image = Properties.Resources.Tipo_veneno; break;
                case "Volador": pictureBox3.Image = Properties.Resources.Tipo_volador; break;
                default: pictureBox3.Image = Properties.Resources.Tipo__3F_3F_3F; break;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            evolucines ventana = new evolucines(idActual);
            ventana.Show();
        }
    }
}
