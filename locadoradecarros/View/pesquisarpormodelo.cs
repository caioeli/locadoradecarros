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
    public partial class pesquisarpormodelo : Form
    {
        public pesquisarpormodelo()
        {
            InitializeComponent();
        }

        private void pesquisarpormodelo_Load(object sender, EventArgs e)
        {

        }

        private void buttonpesmodelo_Click(object sender, EventArgs e)
        {
            if (textBoxmodelo.Text == "")
            {
                MessageBox.Show("Digite o modelo do carro para a bucsa", "Atençao!!!");
                textBoxmodelo.Focus();



                return;
            }



            locadora.Modelo = textBoxmodelo.Text;



            dataGridViewmodelo.DataSource = manipulalocadora.pesquisarmodelo();



            dataGridViewmodelo.Columns[0].Visible = false;
            dataGridViewmodelo.Columns[1].Visible = false;
            dataGridViewmodelo.Columns[2].Visible = false;
            dataGridViewmodelo.Columns[3].Visible = false;
            dataGridViewmodelo.Columns[4].Visible = false;
            dataGridViewmodelo.Columns[5].Visible = false;



            dataGridViewmodelo.Columns[7].HeaderCell.Value = "Modelo";
            dataGridViewmodelo.Columns[8].HeaderCell.Value = "Ano";
            dataGridViewmodelo.Columns[9].HeaderCell.Value = "Imagem";
            dataGridViewmodelo.Columns[10].HeaderCell.Value = "Preco";
            dataGridViewmodelo.Columns[11].HeaderCell.Value = "Marca";
            dataGridViewmodelo.Columns[12].HeaderCell.Value = "Disponivel";
        }
    }
}
