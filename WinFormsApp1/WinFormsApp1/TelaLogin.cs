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
                usuarioTextBox.Text = "";
                senhaTextBox.Text = "";
            }
            else
            {

                TelaUsuarioComum telaUsuarioComum = new TelaUsuarioComum();
                telaUsuarioComum.Show();
                usuarioTextBox.Text = "";
                senhaTextBox.Text = "";
            }
        }

    }
}