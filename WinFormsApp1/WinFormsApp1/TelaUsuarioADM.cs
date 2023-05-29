using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class TelaUsuarioADM : Form
    {
        Conexao conexao = new Conexao();
        Cadastro cadastro = null;
        public TelaUsuarioADM()
        {
            InitializeComponent();

        }

        private void button1_Click_1(object sender, EventArgs e)//Botão Cadastrar
        {
            Cadastro cadastro = null;
            try
            {

                cadastro = new Cadastro(nomeCadastroTextBox.Text,
                                                 sobrenomeCadastroTextBox.Text,
                                                 telefoneCadastroTextBox.Text,
                                                 matriculaCadastroTextBox.Text,
                                                 emailCadastroTextBox.Text,
                                                 tokenCadastroTextBox.Text,
                                                 DateTime.Now,
                                                 comboBox1.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                Alerta alerta = new Alerta("Houve um erro ao cadastrar!");
                alerta.Show();
            }
            conexao.insert(cadastro);
            limparCampos();

        }

        private void button3_Click(object sender, EventArgs e)//Botão Excluir
        {
            try
            {
                conexao.Excluir(excluirTokenTextBox.Text);
            }
            catch (Exception ex)
            {
                Alerta alerta = new Alerta("Houve um Erro Ao excluir!" + ex.Message);
                alerta.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)//botão Carregar Info
        {
            try
            {

                Alerta alerta = new Alerta("Passe o Token na leitora ");
                alerta.Show();
                string leitura = conexao.lerPortaSerial();
                if (leitura != null)
                {
                    editarTokenTextBox.Text = leitura;
                    alerta.Hide();
                    cadastro = conexao.buscarPorToken(editarTokenTextBox.Text);
                    if (cadastro != null)
                    {
                        editarTokenTextBox.Text = cadastro.token;
                        editarCadastroNomeTextBox.Text = cadastro.nome;
                        editarCadastroSobrenomeTextBox.Text = cadastro.sobrenome;
                        editarEmailTextBox.Text = cadastro.email;
                        editarTelefoneTextBox.Text = cadastro.telefone;
                        editarMatriculaTextBox.Text = cadastro.matricula;
                        comboBox2.Text = cadastro.serie;

                    }
                }

            }
            catch (Exception ex)
            {
                Alerta Alerta = new Alerta("Erro, Token não encontrado!" + ex.Message);
                Alerta.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)//Botão Editar
        {
            try
            {
                cadastro.nome = editarCadastroNomeTextBox.Text;
                cadastro.sobrenome = editarCadastroSobrenomeTextBox.Text;
                cadastro.email = editarEmailTextBox.Text;
                cadastro.matricula = editarMatriculaTextBox.Text;
                cadastro.telefone = editarTelefoneTextBox.Text;
                cadastro.token = editarTokenTextBox.Text;

                if (conexao != null)
                {
                    conexao.updateCadastro(cadastro);
                    limparCampos();
                }


            }
            catch (Exception ex)
            {
                Alerta alerta = new Alerta("Houve um erro ao atualizar!");
                Console.WriteLine(ex.Message);
                alerta.Show();
            }
        }
        public void limparCampos()//Só um metodo para limpar os campos de digitação
        {
            editarCadastroNomeTextBox.Text = "";
            editarCadastroSobrenomeTextBox.Text = "";
            editarEmailTextBox.Text = "";
            editarMatriculaTextBox.Text = "";
            editarTelefoneTextBox.Text = "";
            editarTokenTextBox.Text = "";
            comboBox2.Text = "Selecionar";

            nomeCadastroTextBox.Text = "";
            sobrenomeCadastroTextBox.Text = "";
            telefoneCadastroTextBox.Text = "";
            emailCadastroTextBox.Text = "";
            matriculaCadastroTextBox.Text = "";
            tokenCadastroTextBox.Text = "";
            comboBox1.Text = "Selecionar";

            excluirTokenTextBox.Text = "";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int ticketsTotais = 0;
            dataGridView1.Rows.Clear();
            List<Cadastro> cadastros = conexao.BuscarTodosCadastros();
            foreach (Cadastro cadastro in cadastros)
            {
                dataGridView1.Rows.Add(cadastro.nome, cadastro.sobrenome, cadastro.serie, cadastro.matricula, cadastro.email, cadastro.telefone, cadastro.data.ToString("dd/MM/yyyy"));
                ticketsTotais += cadastro.tickets;
            }
            contadordeTickets.Text = ticketsTotais.ToString();

        }



        private void button5_Click(object sender, EventArgs e)
        {
            Alerta alerta = new Alerta("Passe o Token na leitora ");
            alerta.Show();
            string leitura = conexao.lerPortaSerial();
            if (leitura != null)
            {
                if (conexao.buscarPorToken(leitura) != null)
                {
                    alerta.Hide();
                    Alerta alerta2 = new Alerta("Token ja cadastrado!");
                    alerta2.Show();
                }
                else
                {
                    tokenCadastroTextBox.Text = leitura;
                    alerta.Hide();
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Alerta alerta = new Alerta("Passe o Token na leitora ");
            alerta.Show();
            string leitura = conexao.lerPortaSerial();
            if (leitura != null)
            {
                if (conexao.buscarPorToken(leitura) != null)
                {
                    alerta.Hide();
                    excluirTokenTextBox.Text = leitura;
                }
            }
        }
        private void Entrar_Click(object sender, EventArgs e)
        {
            if (usuarioTextBox.Text == null || senhaTextBox.Text == null)
            {
                Alerta alerta = new Alerta("Login ou Senha invalidos!");
                alerta.Show();
                Thread.Sleep(1000);
            }
            if (conexao.BuscarAdministrador(new Administrador(usuarioTextBox.Text, senhaTextBox.Text)))
            {
                conexao.resetarBancoPedidosDiarios();
            }
            
        }
    }
}
