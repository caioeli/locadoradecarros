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
using System.IO;

namespace locadoradecarros.View
{
    public partial class alteraredeletar : Form
    {
        public alteraredeletar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbbuscarcodcar.Text == "")
            {
                MessageBox.Show("Digite um número válido!");
                return;
            }

            var reposta = MessageBox.Show("Deseja excluir o carro " + tbbuscarcodcar.Text + "?", "Atençao!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if(reposta == DialogResult.Yes)
            {
                locadora.Idcarro = Convert.ToInt32(tbbuscarcodcar.Text);

                manipulalocadora Manipulalocadora = new manipulalocadora();
                Manipulalocadora.deletarcarro();
            }

            tbmodelaltdel.Text = String.Empty;
            tbmarcaaltdel.Text = String.Empty;
            tcprealtdel.Text = String.Empty;
            tbdisaltdel.Text = String.Empty;
            txanoaltdel.Text = String.Empty;
            pbialtdel.Image = null;
        }

        private void btnbnuscarcodcar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbbuscarcodcar.Text == "") 
                { 
                    MessageBox.Show("Digite um Código Válido.");
                    return;

                }
                else
                {
                    locadora.Idcarro = Convert.ToInt32(tbbuscarcodcar.Text);
                }

                manipulalocadora manipula = new manipulalocadora();
                manipula.pesquisarlocadora();

                txanoaltdel.Text = locadora.Idcarro.ToString();
                tbmodelaltdel.Text = locadora.Modelo.ToString();
                tbmarcaaltdel.Text = locadora.Marca.ToString();
                tbdisaltdel.Text = locadora.Disponivel.ToString();
                tcprealtdel.Text = locadora.Preco.ToString();
                MemoryStream ns = new MemoryStream((byte[])locadora.Imagem);
                pbialtdel.Image = Image.FromStream(ns);

            }
            catch
            {
                MessageBox.Show("Digite o código novamente");
                return;
            }
        }

        private void tcprealtdel_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnalterarcarro_Click(object sender, EventArgs e)
        {
            if(tbbuscarcodcar.Text == "")
            {
                tbmodelaltdel.Text = String.Empty;
                tbmarcaaltdel.Text = String.Empty;
                tcprealtdel.Text = String.Empty;
                tbdisaltdel.Text = String.Empty;
                txanoaltdel.Text = String.Empty;
                pbialtdel.Image = null;

                return;
            }

            var reposta = MessageBox.Show("Deseja alterar o codigo" + tbbuscarcodcar.Text + "?", "Atençao",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(reposta == DialogResult.Yes)
            {
                locadora.Idcarro = Convert.ToInt32(tbbuscarcodcar.Text);
                locadora.Modelo = tbmodelaltdel.Text;
                locadora.Marca = tbmarcaaltdel.Text;
                locadora.Ano = txanoaltdel.Text;
                locadora.Preco = tcprealtdel.Text;
                locadora.Disponivel = tbdisaltdel.Text;

                MemoryStream memoriaimg = new MemoryStream();
                pbialtdel.Image.Save(memoriaimg, pbialtdel.Image.RawFormat);
                locadora.Imagem = memoriaimg.ToArray();

                manipulalocadora Manipulalocadora = new manipulalocadora();
                Manipulalocadora.alterarlocadora();
            }
        }
    }
}
