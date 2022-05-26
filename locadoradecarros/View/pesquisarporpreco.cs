using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using locadoradecarros.controller;
using locadoradecarros.Model;

namespace locadoradecarros.View
{
    public partial class pesquisarporpreco : Form
    {
        public pesquisarporpreco()
        {
            InitializeComponent();
        }

        private void buttonpespreco_Click(object sender, EventArgs e)
        {
            if (textBoxpreco.Text == "")
            {
                MessageBox.Show("Digite o preço do carro para a busca", "Atençao!!!");
                textBoxpreco.Focus();



                return;
            }



            locadora.Preco = textBoxpreco.Text;


            dataGridViewpreco.DataSource = manipulalocadora.pesquisarprecocarro();



            dataGridViewpreco.Columns[0].Visible = false;
            dataGridViewpreco.Columns[1].Visible = false;
            dataGridViewpreco.Columns[2].Visible = false;
            dataGridViewpreco.Columns[3].Visible = false;
            dataGridViewpreco.Columns[4].Visible = false;
            dataGridViewpreco.Columns[5].Visible = false;

            dataGridViewpreco.Columns[7].HeaderCell.Value = "Modelo";
            dataGridViewpreco.Columns[8].HeaderCell.Value = "Ano";
            dataGridViewpreco.Columns[9].HeaderCell.Value = "Imagem";
            dataGridViewpreco.Columns[10].HeaderCell.Value = "Preco";
            dataGridViewpreco.Columns[11].HeaderCell.Value = "Marca";
            dataGridViewpreco.Columns[12].HeaderCell.Value = "Disponivel";

        }
    }
}
