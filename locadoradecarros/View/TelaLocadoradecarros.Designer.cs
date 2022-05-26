
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLocadoradecarros));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pesquisarPorAnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarPorModeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarPorPreçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarPorPreçoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttoncadscarro = new System.Windows.Forms.Button();
            this.buttonaltecar = new System.Windows.Forms.Button();
            this.buttondeletecar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisarPorAnoToolStripMenuItem,
            this.pesquisarPorModeloToolStripMenuItem,
            this.pesquisarPorPreçoToolStripMenuItem,
            this.pesquisarPorPreçoToolStripMenuItem1,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // pesquisarPorAnoToolStripMenuItem
            // 
            this.pesquisarPorAnoToolStripMenuItem.Name = "pesquisarPorAnoToolStripMenuItem";
            this.pesquisarPorAnoToolStripMenuItem.Size = new System.Drawing.Size(141, 23);
            this.pesquisarPorAnoToolStripMenuItem.Text = "Pesquisar por Ano";
            this.pesquisarPorAnoToolStripMenuItem.Click += new System.EventHandler(this.pesquisarPorAnoToolStripMenuItem_Click);
            // 
            // pesquisarPorModeloToolStripMenuItem
            // 
            this.pesquisarPorModeloToolStripMenuItem.Name = "pesquisarPorModeloToolStripMenuItem";
            this.pesquisarPorModeloToolStripMenuItem.Size = new System.Drawing.Size(165, 23);
            this.pesquisarPorModeloToolStripMenuItem.Text = "Pesquisar por Modelo";
            this.pesquisarPorModeloToolStripMenuItem.Click += new System.EventHandler(this.pesquisarPorModeloToolStripMenuItem_Click);
            // 
            // pesquisarPorPreçoToolStripMenuItem
            // 
            this.pesquisarPorPreçoToolStripMenuItem.Name = "pesquisarPorPreçoToolStripMenuItem";
            this.pesquisarPorPreçoToolStripMenuItem.Size = new System.Drawing.Size(159, 23);
            this.pesquisarPorPreçoToolStripMenuItem.Text = "Pesquisar por Marca";
            this.pesquisarPorPreçoToolStripMenuItem.Click += new System.EventHandler(this.pesquisarPorPreçoToolStripMenuItem_Click);
            // 
            // pesquisarPorPreçoToolStripMenuItem1
            // 
            this.pesquisarPorPreçoToolStripMenuItem1.Name = "pesquisarPorPreçoToolStripMenuItem1";
            this.pesquisarPorPreçoToolStripMenuItem1.Size = new System.Drawing.Size(155, 23);
            this.pesquisarPorPreçoToolStripMenuItem1.Text = "Pesquisar por Preço";
            this.pesquisarPorPreçoToolStripMenuItem1.Click += new System.EventHandler(this.pesquisarPorPreçoToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 23);
            this.toolStripMenuItem1.Text = "                                ";
            // 
            // buttoncadscarro
            // 
            this.buttoncadscarro.BackColor = System.Drawing.Color.Red;
            this.buttoncadscarro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttoncadscarro.BackgroundImage")));
            this.buttoncadscarro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoncadscarro.Font = new System.Drawing.Font("Swis721 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttoncadscarro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttoncadscarro.Location = new System.Drawing.Point(563, 326);
            this.buttoncadscarro.Name = "buttoncadscarro";
            this.buttoncadscarro.Size = new System.Drawing.Size(130, 44);
            this.buttoncadscarro.TabIndex = 3;
            this.buttoncadscarro.Text = "Cadastrar Carro";
            this.buttoncadscarro.UseVisualStyleBackColor = false;
            this.buttoncadscarro.Click += new System.EventHandler(this.buttoncadscarro_Click);
            // 
            // buttonaltecar
            // 
            this.buttonaltecar.BackColor = System.Drawing.Color.Silver;
            this.buttonaltecar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonaltecar.BackgroundImage")));
            this.buttonaltecar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonaltecar.Font = new System.Drawing.Font("Swis721 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonaltecar.Location = new System.Drawing.Point(94, 328);
            this.buttonaltecar.Name = "buttonaltecar";
            this.buttonaltecar.Size = new System.Drawing.Size(125, 44);
            this.buttonaltecar.TabIndex = 4;
            this.buttonaltecar.Text = "Alterar Carro";
            this.buttonaltecar.UseVisualStyleBackColor = false;
            this.buttonaltecar.Click += new System.EventHandler(this.buttonaltecar_Click);
            // 
            // buttondeletecar
            // 
            this.buttondeletecar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttondeletecar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttondeletecar.BackgroundImage")));
            this.buttondeletecar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttondeletecar.Font = new System.Drawing.Font("Swis721 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttondeletecar.Location = new System.Drawing.Point(325, 326);
            this.buttondeletecar.Name = "buttondeletecar";
            this.buttondeletecar.Size = new System.Drawing.Size(133, 44);
            this.buttondeletecar.TabIndex = 5;
            this.buttondeletecar.Text = "Deletar Carro";
            this.buttondeletecar.UseVisualStyleBackColor = false;
            this.buttondeletecar.Click += new System.EventHandler(this.buttondeletecar_Click);
            // 
            // TelaLocadoradecarros
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::locadoradecarros.Properties.Resources.Logo_Locadora__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(787, 384);
            this.Controls.Add(this.buttondeletecar);
            this.Controls.Add(this.buttonaltecar);
            this.Controls.Add(this.buttoncadscarro);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button buttoncadscarro;
        private System.Windows.Forms.Button buttonaltecar;
        private System.Windows.Forms.Button buttondeletecar;
    }
}