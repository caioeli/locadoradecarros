
namespace locadoradecarros.View
{
    partial class pesquisarpormarca
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
            this.buttonpesmarca = new System.Windows.Forms.Button();
            this.textBoxmarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewmarca = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmarca)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonpesmarca
            // 
            this.buttonpesmarca.BackColor = System.Drawing.Color.Silver;
            this.buttonpesmarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonpesmarca.Font = new System.Drawing.Font("Swis721 BlkCn BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonpesmarca.Location = new System.Drawing.Point(640, 60);
            this.buttonpesmarca.Name = "buttonpesmarca";
            this.buttonpesmarca.Size = new System.Drawing.Size(129, 54);
            this.buttonpesmarca.TabIndex = 13;
            this.buttonpesmarca.Text = "PESQUISAR";
            this.buttonpesmarca.UseVisualStyleBackColor = false;
            this.buttonpesmarca.Click += new System.EventHandler(this.buttonpesmarca_Click);
            // 
            // textBoxmarca
            // 
            this.textBoxmarca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxmarca.Location = new System.Drawing.Point(113, 72);
            this.textBoxmarca.Name = "textBoxmarca";
            this.textBoxmarca.Size = new System.Drawing.Size(174, 29);
            this.textBoxmarca.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Swis721 BlkCn BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "Digite a marca do carro : ";
            // 
            // dataGridViewmarca
            // 
            this.dataGridViewmarca.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewmarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmarca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewmarca.Location = new System.Drawing.Point(12, 146);
            this.dataGridViewmarca.Name = "dataGridViewmarca";
            this.dataGridViewmarca.RowTemplate.Height = 25;
            this.dataGridViewmarca.Size = new System.Drawing.Size(762, 315);
            this.dataGridViewmarca.TabIndex = 14;
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
            this.Column3.Width = 180;
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
            // pesquisarpormarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::locadoradecarros.Properties.Resources.MicrosoftTeams_image;
            this.ClientSize = new System.Drawing.Size(781, 473);
            this.Controls.Add(this.dataGridViewmarca);
            this.Controls.Add(this.buttonpesmarca);
            this.Controls.Add(this.textBoxmarca);
            this.Controls.Add(this.label2);
            this.Name = "pesquisarpormarca";
            this.Text = "pesquisarpormarca";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxpesano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonpesmarca;
        private System.Windows.Forms.TextBox textBoxmarca;
        private System.Windows.Forms.DataGridView dataGridViewmarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}