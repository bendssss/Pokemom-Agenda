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
    public partial class FmCadastroPokemon : Form
    {
        public FmCadastroPokemon()
        {
            InitializeComponent();
        }
        // criação da funçã (limpar) com retorno nome.
        private void  fnLimpar()
        {
            txtNome.Clear();
            cbTipo.SelectedIndex = 1;
            numNivel.Value = 1;

            txtNome.Focus();
          
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomePokemon = txtNome.Text;
            string tipoPokemon = cbTipo.Text;
            int  nivelPokemon = (int) numNivel.Value;

            MessageBox.Show($"O Pokemon {nomePokemon} do tipo {tipoPokemon}" +
                $"foi cadastrado com o nivel {nivelPokemon}");

            fnLimpar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            fnLimpar();

        }
    }
}
