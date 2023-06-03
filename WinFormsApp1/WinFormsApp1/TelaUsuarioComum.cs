namespace WinFormsApp1
{
    public partial class TelaUsuarioComum : Form
    {
        Conexao conexao = new Conexao();
        Cadastro cadastro = null;
        CadastroPedidosDoDia cadastroPedidosDoDia = null;

        public TelaUsuarioComum()
        {
            InitializeComponent();

        }
        private void Listar_Click(object sender, EventArgs e)
        {
            try
            {
                Alerta alerta = new Alerta("Passe o Token na leitora ");
                alerta.Show();
                string leitura = conexao.lerPortaSerial();
                alerta.Hide();
                if (leitura != null)//Leu no serial?
                {
                    cadastro = conexao.buscarPorToken(leitura);

                    conexao.insertBancoPedidosDoDia(cadastro);

                }

                atualizarCamposDaJanelaPadrão();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                atualizarCamposDaJanelaPadrão();
                Alerta alerta = new Alerta("Atualizado!");
                alerta.Show();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void atualizarCamposDaJanelaPadrão()
        {


            int totalDeTickets = 0;
            dataGridView1.Rows.Clear();

            List<CadastroPedidosDoDia> cadastrosDoDia = conexao.buscarBancoPedidosDoDia();
            foreach (CadastroPedidosDoDia cadastroDoDia in cadastrosDoDia)
            {

                dataGridView1.Rows.Add(cadastroDoDia.matricula, cadastroDoDia.tickets, cadastroDoDia.data.ToString("dd/MM/yyyy"));
                totalDeTickets += cadastroDoDia.tickets;
            }

            contadordeTickets.Text = totalDeTickets.ToString();

            int contador1 = 0;
            int contador23 = 0;
            int qtdeAlunos = 0;
            List<string> alunos = conexao.buscarBancoPedidosDoDia_Contato();
            foreach (string aluno in alunos)
            {
                if (aluno.Equals("1º Ano"))
                {
                    contador1++;
                    qtdeAlunos++;
                }
                else
                {
                    contador1++;
                    contador23++;
                    qtdeAlunos++;
                }
            }
            cafesdaManha.Text = contador1.ToString();
            almocoECafeTarde.Text = contador23.ToString();
            totalDeAlunos.Text = qtdeAlunos.ToString();

        }
    }
}
