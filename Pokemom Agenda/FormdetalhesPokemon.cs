using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemom_Agenda
{
    public partial class FormDetalhesPokemon : Form
    {
        public Pokemon pokemonRecebido {  get; set; }
        public FormDetalhesPokemon()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbTipo_Click(object sender, EventArgs e)
        {

        }

        private void lbnome_Click(object sender, EventArgs e)
        {

        }

        private void FormDetalhesPokemon_Load(object sender, EventArgs e)
        {
            lbNome.Text = pokemonRecebido.Nome;
            lbTipo.Text = pokemonRecebido.Tipo;
            lbNivel.Text = pokemonRecebido.Nivel.ToString();

          pbImagemPokedex.SizeMode = PictureBoxSizeMode.StretchImage;

          pbImagemPokedex.Load(pokemonRecebido.fnLinkImg()); 
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        public string fnLinkImg()
        {
            // Trata o nome para o formato da URL (letras minúsculas, troca espaços por hífens e remove apóstrofos)

             string nomeTratado = Nome.Replace(" ", "-").Replace("'", "").ToLower(); 

             return $"https://img.pokemondb.net/artwork/{nomeTratado}.jpg";
        }

        public void fnTreinar()
        {
             Nivel++;

             Vida = Nivel * 70; 
             Dano = Nivel * 15; 
        }

    }
}
