namespace WinFormsApp1
{
    public partial class TelaLogin : Form
    {
        Conexao conexao = new Conexao();
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usuarioTextBox.Text == null || senhaTextBox.Text == null)
            {
                Alerta alerta = new Alerta("Digite um Login e Senha validos!");
                alerta.Show();
            }
            if (conexao.BuscarAdministrador(new Administrador(usuarioTextBox.Text, senhaTextBox.Text)))
            {
                TelaUsuarioADM telaUsuarioADM = new TelaUsuarioADM();
                telaUsuarioADM.Show();
            }
            else
            {

                TelaUsuarioComum telaUsuarioComum = new TelaUsuarioComum();
                telaUsuarioComum.Show();
            }
        }

        private void Usuario_Click(object sender, EventArgs e)
        {

        }

        private void usuarioTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void senhaTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void Senha_Click(object sender, EventArgs e)
        {
        }
    }
}