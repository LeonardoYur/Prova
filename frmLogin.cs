using Controller;
using Model;
using Prova.View;

namespace Prova
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnAnexar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Anexe uma imagem!";
            ofd.Filter = "*.bmp|*.png";
            ofd.FileName = "fotoperfil";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string url = ofd.FileName;
                pictureBox1.Image = Image.FromFile(url);
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Calendario Pessoal = new Calendario();
            Calendario Trabalho = new Calendario();

            Pessoal.Id = 0;
            Pessoal.NomeCalendario = "Pessoal";
            Pessoal.Cor = "Verde";
            Trabalho.Id = 0;
            Trabalho.NomeCalendario = "Trabalho";
            Trabalho.Cor = "Azul";

            Usuario usuario = new Usuario();
            usuario.Nome = txtNome.Text.Trim();
            usuario.FotoPerfil = pictureBox1.Text.Trim();
            usuario.Calendario = Pessoal;
            UsuarioController.Salvar(usuario);
            frmPrincipal f1 = new frmPrincipal();
            f1.ShowDialog();
        }
    }
}
