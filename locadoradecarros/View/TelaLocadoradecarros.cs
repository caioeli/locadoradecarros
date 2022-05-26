using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace locadoradecarros.View
{
    public partial class TelaLocadoradecarros : Form
    {
        public TelaLocadoradecarros()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TelaLocadoradecarros_Load(object sender, EventArgs e)
        {

        }

        private void pesquisarPorModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pesquisarpormodelo pesquisarpormodelo = new pesquisarpormodelo();
            pesquisarpormodelo.ShowDialog();
        }

        private void pesquisarPorAnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pesquisarporano Pesquisarporano = new pesquisarporano();
            Pesquisarporano.ShowDialog();

        }

        private void buttoncadscarro_Click(object sender, EventArgs e)
        {
            cadastrarcarro cadastrarcarro = new cadastrarcarro();
            cadastrarcarro.ShowDialog();
        }

        private void pesquisarPorPreçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pesquisarpormarca pesquisarpormarca = new pesquisarpormarca();
            pesquisarpormarca.ShowDialog();
        }

        private void pesquisarPorPreçoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pesquisarporpreco pesquisarporpreco = new pesquisarporpreco();
            pesquisarporpreco.ShowDialog();
        }

        private void buttondeletecar_Click(object sender, EventArgs e)
        {
            Deletarcarro deletarcarro = new Deletarcarro();
            deletarcarro.ShowDialog();
        }

        private void buttonaltecar_Click(object sender, EventArgs e)
        {
            Alterarcarro alterarcarro = new Alterarcarro();
            alterarcarro.ShowDialog();
        }
    }
}
