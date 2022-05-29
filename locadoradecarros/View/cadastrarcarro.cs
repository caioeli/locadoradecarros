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
using locadoradecarros.controller;
using locadoradecarros.Model;

namespace locadoradecarros.View
{
    public partial class cadastrarcarro : Form
    {
        public cadastrarcarro()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonfazercadastrar_Click(object sender, EventArgs e)
        {
            if(textBoxmodelo.Text == "" || textBoxmarca.Text == "" || textBoxdis.Text == "" || textBoxpreco.Text == "" || tbanoaltdel.Text == "") 
            {
                MessageBox.Show("Digite todos os dados", "Atenção!!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            locadora.Ano = tbanoaltdel.Text;
            locadora.Modelo = textBoxmodelo.Text;
            locadora.Marca = textBoxmarca.Text;
            locadora.Preco = textBoxpreco.Text;
            locadora.Disponivel = textBoxdis.Text;

            MemoryStream memoriaimagem = new MemoryStream();
            pictureBoximgcarro.Image.Save(memoriaimagem, pictureBoximgcarro.Image.RawFormat);
            locadora.Imagem = memoriaimagem.ToArray();

            manipulalocadora manipulalocadora = new manipulalocadora();
            manipulalocadora.cadastrolocadora();

            if(locadora.Retorno == "Sim")
            {
                limpartela();
                return;
            }
            else
            {
                fecharcadastro();
                return;
            }
        }

        private void buttonimage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "escolha o seu logo (*.jpg; *.jpeg; *.png;)" + "| *.jpg; *.jpeg; *.png;";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoximgcarro.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void cadastrarcarro_Load(object sender, EventArgs e)
        {

        }

        public void limpartela()
        {
            foreach(Control ctl in this.Controls)
                if(ctl is TextBox)
                {
                    ctl.Text = string.Empty;
                }
 
        }

        public void fecharcadastro()
        {
            this.Close();
        }
    }
}
