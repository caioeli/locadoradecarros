
namespace locadoradecarros.View
{
    partial class pesquisarporpreco
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
            this.dataGridViewpreco = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonpespreco = new System.Windows.Forms.Button();
            this.textBoxpreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpreco)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewpreco
            // 
            this.dataGridViewpreco.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewpreco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewpreco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewpreco.Location = new System.Drawing.Point(5, 120);
            this.dataGridViewpreco.Name = "dataGridViewpreco";
            this.dataGridViewpreco.RowTemplate.Height = 25;
            this.dataGridViewpreco.Size = new System.Drawing.Size(707, 315);
            this.dataGridViewpreco.TabIndex = 10;
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
            this.Column3.Width = 120;
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
            // buttonpespreco
            // 
            this.buttonpespreco.BackColor = System.Drawing.Color.Silver;
            this.buttonpespreco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonpespreco.Font = new System.Drawing.Font("Swis721 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonpespreco.Location = new System.Drawing.Point(570, 36);
            this.buttonpespreco.Name = "buttonpespreco";
            this.buttonpespreco.Size = new System.Drawing.Size(129, 54);
            this.buttonpespreco.TabIndex = 13;
            this.buttonpespreco.Text = "PESQUISAR";
            this.buttonpespreco.UseVisualStyleBackColor = false;
            this.buttonpespreco.Click += new System.EventHandler(this.buttonpespreco_Click);
            // 
            // textBoxpreco
            // 
            this.textBoxpreco.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxpreco.Location = new System.Drawing.Point(122, 78);
            this.textBoxpreco.Name = "textBoxpreco";
            this.textBoxpreco.Size = new System.Drawing.Size(168, 27);
            this.textBoxpreco.TabIndex = 12;
            this.textBoxpreco.Text = "R$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Swis721 BlkCn BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "Digite o preço do carro :";
            // 
            // pesquisarporpreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::locadoradecarros.Properties.Resources.MicrosoftTeams_image;
            this.ClientSize = new System.Drawing.Size(721, 447);
            this.Controls.Add(this.buttonpespreco);
            this.Controls.Add(this.textBoxpreco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewpreco);
            this.Name = "pesquisarporpreco";
            this.Text = "pesquisarporpreco";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpreco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxpesano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewpreco;
        private System.Windows.Forms.Button buttonpespreco;
        private System.Windows.Forms.TextBox textBoxpreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}