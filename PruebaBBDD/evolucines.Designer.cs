
namespace PruebaBBDD
{
    partial class evolucines
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pre = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Pos = new System.Windows.Forms.Label();
            this.pos_pokemon = new System.Windows.Forms.PictureBox();
            this.pokemon = new System.Windows.Forms.PictureBox();
            this.pre_pokemon = new System.Windows.Forms.PictureBox();
            this.nombrePokemon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pos_pokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pre_pokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // Pre
            // 
            this.Pre.Location = new System.Drawing.Point(35, 335);
            this.Pre.Name = "Pre";
            this.Pre.Size = new System.Drawing.Size(159, 44);
            this.Pre.TabIndex = 4;
            this.Pre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(316, 335);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(159, 44);
            this.Nombre.TabIndex = 5;
            this.Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pos
            // 
            this.Pos.Location = new System.Drawing.Point(601, 335);
            this.Pos.Name = "Pos";
            this.Pos.Size = new System.Drawing.Size(159, 44);
            this.Pos.TabIndex = 6;
            this.Pos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pos_pokemon
            // 
            this.pos_pokemon.Location = new System.Drawing.Point(604, 97);
            this.pos_pokemon.Name = "pos_pokemon";
            this.pos_pokemon.Size = new System.Drawing.Size(159, 174);
            this.pos_pokemon.TabIndex = 3;
            this.pos_pokemon.TabStop = false;
            // 
            // pokemon
            // 
            this.pokemon.Location = new System.Drawing.Point(316, 97);
            this.pokemon.Name = "pokemon";
            this.pokemon.Size = new System.Drawing.Size(159, 174);
            this.pokemon.TabIndex = 2;
            this.pokemon.TabStop = false;
            // 
            // pre_pokemon
            // 
            this.pre_pokemon.Location = new System.Drawing.Point(38, 97);
            this.pre_pokemon.Name = "pre_pokemon";
            this.pre_pokemon.Size = new System.Drawing.Size(159, 174);
            this.pre_pokemon.TabIndex = 1;
            this.pre_pokemon.TabStop = false;
            // 
            // nombrePokemon
            // 
            this.nombrePokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePokemon.Location = new System.Drawing.Point(12, 9);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(776, 73);
            this.nombrePokemon.TabIndex = 7;
            this.nombrePokemon.Text = "EVOLUCIONES";
            this.nombrePokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // evolucines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nombrePokemon);
            this.Controls.Add(this.Pos);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Pre);
            this.Controls.Add(this.pos_pokemon);
            this.Controls.Add(this.pokemon);
            this.Controls.Add(this.pre_pokemon);
            this.Name = "evolucines";
            this.Text = "evolucines";
            ((System.ComponentModel.ISupportInitialize)(this.pos_pokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pre_pokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pre_pokemon;
        private System.Windows.Forms.PictureBox pokemon;
        private System.Windows.Forms.PictureBox pos_pokemon;
        private System.Windows.Forms.Label Pre;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Pos;
        private System.Windows.Forms.Label nombrePokemon;
    }
}