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
    public partial class pesquisarpormarca : Form
    {
        public pesquisarpormarca()
        {
            InitializeComponent();
        }

        private void buttonpesmarca_Click(object sender, EventArgs e)
        {
            if (textBoxmarca.Text == "")
            {
                MessageBox.Show("Digite a marca do carro para a bucsa", "Atençao!!!");
                textBoxmarca.Focus();



                return;
            }



            locadora.Marca = textBoxmarca.Text;



            dataGridViewmarca.DataSource = manipulalocadora.pesquisarmarcacarro();



            dataGridViewmarca.Columns[0].Visible = false;
            dataGridViewmarca.Columns[1].Visible = false;
            dataGridViewmarca.Columns[2].Visible = false;
            dataGridViewmarca.Columns[3].Visible = false;
            dataGridViewmarca.Columns[4].Visible = false;
            dataGridViewmarca.Columns[5].Visible = false;

            dataGridViewmarca.Columns[7].HeaderCell.Value = "Modelo";
            dataGridViewmarca.Columns[8].HeaderCell.Value = "Ano";
            dataGridViewmarca.Columns[9].HeaderCell.Value = "Imagem";
            dataGridViewmarca.Columns[10].HeaderCell.Value = "Preco";
            dataGridViewmarca.Columns[11].HeaderCell.Value = "Marca";
            dataGridViewmarca.Columns[12].HeaderCell.Value = "Disponivel";
        }
    }
}
