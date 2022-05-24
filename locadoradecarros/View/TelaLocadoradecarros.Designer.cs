
namespace locadoradecarros.View
{
    partial class TelaLocadoradecarros
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pesquisarPorAnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarPorModeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarPorPreçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarPorPreçoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisarPorAnoToolStripMenuItem,
            this.pesquisarPorModeloToolStripMenuItem,
            this.pesquisarPorPreçoToolStripMenuItem,
            this.pesquisarPorPreçoToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // pesquisarPorAnoToolStripMenuItem
            // 
            this.pesquisarPorAnoToolStripMenuItem.Name = "pesquisarPorAnoToolStripMenuItem";
            this.pesquisarPorAnoToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.pesquisarPorAnoToolStripMenuItem.Text = "Pesquisar por Ano";
            this.pesquisarPorAnoToolStripMenuItem.Click += new System.EventHandler(this.pesquisarPorAnoToolStripMenuItem_Click);
            // 
            // pesquisarPorModeloToolStripMenuItem
            // 
            this.pesquisarPorModeloToolStripMenuItem.Name = "pesquisarPorModeloToolStripMenuItem";
            this.pesquisarPorModeloToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.pesquisarPorModeloToolStripMenuItem.Text = "Pesquisar por Modelo";
            this.pesquisarPorModeloToolStripMenuItem.Click += new System.EventHandler(this.pesquisarPorModeloToolStripMenuItem_Click);
            // 
            // pesquisarPorPreçoToolStripMenuItem
            // 
            this.pesquisarPorPreçoToolStripMenuItem.Name = "pesquisarPorPreçoToolStripMenuItem";
            this.pesquisarPorPreçoToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.pesquisarPorPreçoToolStripMenuItem.Text = "Pesquisar por Marca";
            // 
            // pesquisarPorPreçoToolStripMenuItem1
            // 
            this.pesquisarPorPreçoToolStripMenuItem1.Name = "pesquisarPorPreçoToolStripMenuItem1";
            this.pesquisarPorPreçoToolStripMenuItem1.Size = new System.Drawing.Size(123, 20);
            this.pesquisarPorPreçoToolStripMenuItem1.Text = "Pesquisar por Preço";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(115, 20);
            this.toolStripMenuItem1.Text = "                                ";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(207, 20);
            this.toolStripMenuItem2.Text = " Cadastrar carro                                   ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cadastrar Carro";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "Alterar Carro";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(242, 334);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 45);
            this.button3.TabIndex = 5;
            this.button3.Text = "Deletar Carro";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // TelaLocadoradecarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(618, 391);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaLocadoradecarros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOCADORA";
            this.Load += new System.EventHandler(this.TelaLocadoradecarros_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pesquisarPorAnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarPorModeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarPorPreçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarPorPreçoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}