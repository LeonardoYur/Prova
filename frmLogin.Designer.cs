namespace Prova
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            txtNome = new TextBox();
            lblNome = new Label();
            btnSalvar = new Button();
            btnAnexar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "img";
            openFileDialog1.Filter = "*.bmp|*.png";
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Location = new Point(27, 76);
            txtNome.MinimumSize = new Size(50, 10);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(309, 23);
            txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(27, 58);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(27, 176);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAnexar
            // 
            btnAnexar.Location = new Point(27, 125);
            btnAnexar.Name = "btnAnexar";
            btnAnexar.Size = new Size(129, 23);
            btnAnexar.TabIndex = 4;
            btnAnexar.Text = "Anexar foto de perfil";
            btnAnexar.UseVisualStyleBackColor = true;
            btnAnexar.Click += btnAnexar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(258, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 74);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(pictureBox1);
            Controls.Add(btnAnexar);
            Controls.Add(btnSalvar);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            MinimumSize = new Size(500, 500);
            Name = "frmLogin";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private TextBox txtNome;
        private Label lblNome;
        private Button btnSalvar;
        private Button btnAnexar;
        private PictureBox pictureBox1;
    }
}
