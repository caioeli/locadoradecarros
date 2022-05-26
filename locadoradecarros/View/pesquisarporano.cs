using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using locadoradecarros.Model;
using locadoradecarros.controller;

namespace locadoradecarros.View
{
    public partial class pesquisarporano : Form
    {
        public pesquisarporano()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxpesano.Text == "")
            {
                MessageBox.Show("Digite o ano para a bucsa", "Atençao!!!");
                textBoxpesano.Focus();

                return;
            }

            locadora.Ano = textBoxpesano.Text;

            dataGridView.DataSource = manipulalocadora.pesquisaranocarro();

            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].Visible = false;
            dataGridView.Columns[2].Visible = false;
            dataGridView.Columns[3].Visible = false;
            dataGridView.Columns[4].Visible = false;
            dataGridView.Columns[5].Visible = false;

            dataGridView.Columns[7].HeaderCell.Value = "Modelo";
            dataGridView.Columns[8].HeaderCell.Value = "Ano";
            dataGridView.Columns[9].HeaderCell.Value = "Imagem";
            dataGridView.Columns[10].HeaderCell.Value = "Preco";
            dataGridView.Columns[11].HeaderCell.Value = "Marca";
            dataGridView.Columns[12].HeaderCell.Value = "Disponivel";
        }

        private void pesquisarporano_Load(object sender, EventArgs e)
        {

        }


    }

}

