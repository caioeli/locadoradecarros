
namespace locadoradecarros.View
{
    partial class pesquisarpormodelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pesquisarpormodelo));
            this.dataGridViewmodelo = new System.Windows.Forms.DataGridView();
            this.buttonpesmodelo = new System.Windows.Forms.Button();
            this.textBoxmodelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmodelo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewmodelo
            // 
            this.dataGridViewmodelo.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewmodelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmodelo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewmodelo.Location = new System.Drawing.Point(12, 123);
            this.dataGridViewmodelo.Name = "dataGridViewmodelo";
            this.dataGridViewmodelo.RowTemplate.Height = 25;
            this.dataGridViewmodelo.Size = new System.Drawing.Size(711, 315);
            this.dataGridViewmodelo.TabIndex = 10;
            // 
            // buttonpesmodelo
            // 
            this.buttonpesmodelo.BackColor = System.Drawing.Color.Silver;
            this.buttonpesmodelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonpesmodelo.Font = new System.Drawing.Font("Swis721 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonpesmodelo.Location = new System.Drawing.Point(593, 36);
            this.buttonpesmodelo.Name = "buttonpesmodelo";
            this.buttonpesmodelo.Size = new System.Drawing.Size(129, 54);
            this.buttonpesmodelo.TabIndex = 13;
            this.buttonpesmodelo.Text = "PESQUISAR";
            this.buttonpesmodelo.UseVisualStyleBackColor = false;
            this.buttonpesmodelo.Click += new System.EventHandler(this.buttonpesmodelo_Click);
            // 
            // textBoxmodelo
            // 
            this.textBoxmodelo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxmodelo.Location = new System.Drawing.Point(84, 63);
            this.textBoxmodelo.Name = "textBoxmodelo";
            this.textBoxmodelo.Size = new System.Drawing.Size(238, 27);
            this.textBoxmodelo.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Swis721 BlkCn BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "Digite o modelo do carro :";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MODELO";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ANO";
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "IMAGEM";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PREÇO";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "MARCA";
            this.Column5.Name = "Column5";
            this.Column5.Width = 110;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "DISPONIBILIDADE";
            this.Column6.Name = "Column6";
            this.Column6.Width = 120;
            // 
            // pesquisarpormodelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::locadoradecarros.Properties.Resources.MicrosoftTeams_image;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.buttonpesmodelo);
            this.Controls.Add(this.textBoxmodelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewmodelo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pesquisarpormodelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pesquisarpormodelo";
            this.Load += new System.EventHandler(this.pesquisarpormodelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmodelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridViewmodelo;
        private System.Windows.Forms.Button buttonpesmodelo;
        private System.Windows.Forms.TextBox textBoxpesano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxmodelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}