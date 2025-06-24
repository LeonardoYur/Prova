namespace Prova.View
{
    partial class frmPrincipal
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
            openFileDialog1 = new OpenFileDialog();
            lblNome = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            NomeAtividade = new DataGridViewTextBoxColumn();
            DescAtividade = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(59, 23);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Usuario0";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 40);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NomeAtividade, DescAtividade, Data });
            dataGridView1.Location = new Point(12, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 280);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // NomeAtividade
            // 
            NomeAtividade.HeaderText = "Atividade";
            NomeAtividade.Name = "NomeAtividade";
            // 
            // DescAtividade
            // 
            DescAtividade.HeaderText = "Descrição";
            DescAtividade.Name = "DescAtividade";
            // 
            // Data
            // 
            Data.HeaderText = "Data";
            Data.Name = "Data";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(lblNome);
            Name = "frmPrincipal";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Label lblNome;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NomeAtividade;
        private DataGridViewTextBoxColumn DescAtividade;
        private DataGridViewTextBoxColumn Data;
    }
}