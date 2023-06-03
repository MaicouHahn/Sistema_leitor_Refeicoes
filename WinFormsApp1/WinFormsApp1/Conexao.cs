using System.Text;
using MySqlConnector;
using System.IO.Ports;
using System.Management;
namespace WinFormsApp1
{
    internal class Conexao
    {
        private const string dadosDaConexao = "server=localhost;database=testetoken;user=root;password= ;";
        private MySqlConnection conexaoSql = new MySqlConnection(dadosDaConexao);
        public bool BuscarAdministrador(Administrador adm)
        {
            Administrador administrador = null;
            try
            {
                conexaoSql.Open();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM administradores where usuario=@usuario && senha=@senha", conexaoSql);
                comando.Parameters.AddWithValue("@usuario", adm.usuario);
                comando.Parameters.AddWithValue("@senha", adm.senha);
                MySqlDataReader leitor = comando.ExecuteReader();

                if (leitor.Read())
                {
                    string usuario = leitor.GetString("usuario");
                    string senha = leitor.GetString("senha");
                    administrador = new Administrador(usuario, senha);

                }

                if (adm.Equals(administrador))
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                Alerta alerta = new Alerta("Usuario ou senha Incorretos!");
                Console.WriteLine(ex.Message);
                alerta.Show();
            }
            finally
            {
                conexaoSql.Close();
            }
            return false;
        }
        public List<Cadastro> BuscarTodosCadastros()
        {
            List<Cadastro> cadastros = new List<Cadastro>();
            try
            {
                conexaoSql.Open();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM cadastro", conexaoSql);
                MySqlDataReader leitor = comando.ExecuteReader();
                while (leitor.Read())
                {
                    string matricula = leitor.GetString("matricula");
                    string nome = leitor.GetString("nome");
                    string sobrenome = leitor.GetString("sobrenome");
                    string telefone = leitor.GetString("telefone");
                    string email = leitor.GetString("email");
                    string token = leitor.GetString("token");
                    DateTime data = leitor.GetDateTime("datacadastro");
                    string serie = leitor.GetString("serie");

                    Cadastro cadastro = new Cadastro(nome, sobrenome, telefone, matricula, email, token, data, serie);
                    cadastros.Add(cadastro);
                }


            }
            catch (Exception ex)
            {
                Alerta alerta = new Alerta("Não foi retornado nenhum cadastro!");
                Console.WriteLine(ex.Message);
                alerta.Show();

            }
            finally
            {
                conexaoSql.Close();
            }
            return cadastros;
        }
        public void insert(Cadastro cadastro)
        {
            try
            {

                conexaoSql.Open();
                MySqlCommand comando = new MySqlCommand("INSERT INTO cadastro (matricula,nome,sobrenome,telefone,email,token,datacadastro,serie) VALUES (@matricula,@nome,@sobrenome,@telefone,@email,@token,@datacadastro,@serie)", conexaoSql);

                comando.Parameters.AddWithValue("@matricula", cadastro.matricula);
                comando.Parameters.AddWithValue("@nome", cadastro.nome);
                comando.Parameters.AddWithValue("@sobrenome", cadastro.sobrenome);
                comando.Parameters.AddWithValue("@telefone", cadastro.telefone);
                comando.Parameters.AddWithValue("@email", cadastro.email);
                comando.Parameters.AddWithValue("@token", cadastro.token);
                comando.Parameters.AddWithValue("@datacadastro", cadastro.data);
                comando.Parameters.AddWithValue("@serie", cadastro.serie);

                comando.ExecuteNonQuery();

                Alerta alerta = new Alerta("Cadastro Efetuado");
                alerta.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexaoSql.Close();
            }

        }
        public void ExcluirPorToken(string token)
        {
            try
            {
                if (buscarPorToken(token) != null)
                {
                    conexaoSql.Open();
                    MySqlCommand comando = new MySqlCommand("DELETE FROM cadastro where token=@token", conexaoSql);
                    comando.Parameters.AddWithValue("@token", token);
                    comando.ExecuteNonQuery();
                    Alerta alerta = new Alerta("Cadastro Deletado!");
                    alerta.Show();
                }

            }
            catch (Exception ex)
            {
                Alerta alerta = new Alerta("Erro ao deletar!");
                Console.WriteLine(ex.Message);
                alerta.Show();
            }
            finally { conexaoSql.Close(); }
        }
        public void ExcluirPorMatricula(string matricula)
        {
            try
            {
                if (buscarPorMatricula(matricula) != null)
                {
                    conexaoSql.Open();
                    MySqlCommand comando = new MySqlCommand("DELETE FROM cadastro where matricula=@matricula", conexaoSql);
                    comando.Parameters.AddWithValue("@matricula", matricula);
                    comando.ExecuteNonQuery();
                    Alerta alerta = new Alerta("Cadastro Deletado!");
                    alerta.Show();
                }

            }
            catch (Exception ex)
            {
                Alerta alerta = new Alerta("Erro ao deletar!");
                Console.WriteLine(ex.Message);
                alerta.Show();
            }
            finally { conexaoSql.Close(); }
        }
        public Cadastro buscarPorToken(string token)
        {
            Cadastro cadastro = null;
            try
            {
                conexaoSql.Open();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM cadastro WHERE token = @token", conexaoSql);
                comando.Parameters.AddWithValue("@token", token);
                MySqlDataReader leitor = comando.ExecuteReader();

                if (leitor.Read())
                {
                    string matricula = leitor.GetString("matricula");
                    string nome = leitor.GetString("nome");
                    string sobrenome = leitor.GetString("sobrenome");
                    string telefone = leitor.GetString("telefone");
                    string email = leitor.GetString("email");
                    DateTime data = leitor.GetDateTime("datacadastro");
                    string serie = leitor.GetString("serie");

                    cadastro = new Cadastro(nome, sobrenome, telefone, matricula, email, token, data, serie);

                }
                else
                {
                    Alerta alerta = new Alerta("Não foi encontrado nenhum cadastro com esse token!");
                    alerta.Show();
                }
            }
            catch (Exception ex)
            {
                Alerta alerta = new Alerta("Erro ao executar comando: " + ex.Message);
                alerta.Show();
            }
            finally
            {
                conexaoSql.Close();
            }

            return cadastro;

        }
        public Cadastro buscarPorMatricula(string matricula)
        {
            Cadastro cadastro = null;
            try
            {
                conexaoSql.Open();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM cadastro WHERE matricula = @matricula", conexaoSql);
                comando.Parameters.AddWithValue("@matricula", matricula);
                MySqlDataReader leitor = comando.ExecuteReader();

                if (leitor.Read())
                {

                    string nome = leitor.GetString("nome");
                    string sobrenome = leitor.GetString("sobrenome");
                    string telefone = leitor.GetString("telefone");
                    string email = leitor.GetString("email");
                    string token = leitor.GetString("token");
                    DateTime data = leitor.GetDateTime("datacadastro");
                    string serie = leitor.GetString("serie");

                    cadastro = new Cadastro(nome, sobrenome, telefone, matricula, email, token, data, serie);
                }
                else
                {
                    
                    Alerta alerta = new Alerta("Não foi encontrado nenhum cadastro com essa matricula!");
                    alerta.Show();
                }
            }
            catch (Exception ex)
            {
                Alerta alerta = new Alerta("Erro ao executar comando");
                Console.WriteLine(ex.Message);
                alerta.Show();
            }
            finally
            {
                conexaoSql.Close();
            }

            return cadastro;
        }
        public void updateCadastroPorToken(Cadastro cadastro)
        {
            try
            {
                conexaoSql.Open();
                MySqlCommand comando = new MySqlCommand("UPDATE cadastro SET nome = @nome, sobrenome = @sobrenome, telefone = @telefone,matricula=@matricula,email = @email WHERE token = @token", conexaoSql);

                comando.Parameters.AddWithValue("@token", cadastro.token);
                comando.Parameters.AddWithValue("@nome", cadastro.nome);
                comando.Parameters.AddWithValue("@sobrenome", cadastro.sobrenome);
                comando.Parameters.AddWithValue("@telefone", cadastro.telefone);
                comando.Parameters.AddWithValue("@email", cadastro.email);
                comando.Parameters.AddWithValue("@matricula", cadastro.matricula);
                comando.ExecuteNonQuery();
                Alerta alerta = new Alerta("Cadastro alterado!");
                alerta.Show();

            }
            catch (Exception ex)
            {
                Alerta alerta = new Alerta("Erro ao Atualizar!");
                Console.WriteLine(ex.Message);
                alerta.Show();
            }
            finally
            {
                conexaoSql.Close();
            }

        }
        public void updateCadastroPorMatricula(Cadastro cadastro)
        {
            try
            {
                conexaoSql.Open();
                MySqlCommand comando = new MySqlCommand("UPDATE cadastro SET nome = @nome, sobrenome = @sobrenome, telefone = @telefone, email = @email, token = @token where matricula=@matricula", conexaoSql);

                comando.Parameters.AddWithValue("@token", cadastro.token);
                comando.Parameters.AddWithValue("@matricula", cadastro.matricula);
                comando.Parameters.AddWithValue("@nome", cadastro.nome);
                comando.Parameters.AddWithValue("@sobrenome", cadastro.sobrenome);
                comando.Parameters.AddWithValue("@telefone", cadastro.telefone);
                comando.Parameters.AddWithValue("@email", cadastro.email);

                comando.ExecuteNonQuery();
                Alerta alerta = new Alerta("Cadastro alterado!");
                alerta.Show();

            }
            catch (Exception ex)
            {
                Alerta alerta = new Alerta("Erro ao Atualizar!");
                Console.WriteLine(ex.Message);
                alerta.Show();
            }
            finally
            {
                conexaoSql.Close();
            }

        }
        public string EncontrarPortaArduino()//metodo para buscar a porta do arduino no computador de forma automatica vai nos dispositivos e impressoras e procura pela porta que possui o nome arduino
        {
            string portaArduino = string.Empty;

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption LIKE '%(COM%'");

            foreach (ManagementObject port in searcher.Get())
            {
                string caption = port["Caption"].ToString();
                if (caption.Contains("Arduino"))
                {
                    string[] split = caption.Split('(');
                    portaArduino = split[1].Replace(")", "");
                    break;
                }
            }

            return portaArduino;
        }
        public string lerPortaSerial()
        {
            string data = "";
            string portaDoArduino = EncontrarPortaArduino();
            using (SerialPort port = new SerialPort(portaDoArduino, 9600))//Porta com que esta conectada o arduino
            {
                port.Encoding = Encoding.ASCII;
                port.NewLine = "\n"; // Define o caractere de nova linha que indica o fim de uma leitura

                try
                {
                    port.Open();


                    while (data == string.Empty)
                    {
                        data = port.ReadLine();
                    }
                    data = data.Replace(" ", "");//para garantir que não tenha espaço entre os digitos do token
                    data = data.TrimEnd('\r');//para retirar um \r que vem ao fim da string lida pelo arduino

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao abrir a porta serial: " + ex.Message);
                }
            }

            return data;
        }
        public void insertBancoPedidosDoDia(Cadastro cadastro)
        {
            try
            {
                conexaoSql.Open();
                MySqlCommand comando = new MySqlCommand("insert into pedidosdodia(matricula,tickets)values(@matricula,@tickets);", conexaoSql);

                comando.Parameters.AddWithValue("@matricula", cadastro.matricula);
                comando.Parameters.AddWithValue("@tickets", cadastro.tickets);
                comando.Parameters.AddWithValue("@serie", cadastro.serie);

                comando.ExecuteNonQuery();

                Alerta alerta = new Alerta("Cadastro Efetuado");
                alerta.Show();

                Thread.Sleep(2000);
                alerta.Close();

            }
            catch (Exception ex)
            {
                Alerta alerta = new Alerta("Houve um Erro ao cadastrar seu Token!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conexaoSql.Close();
            }
        }
        public List<CadastroPedidosDoDia> buscarBancoPedidosDoDia()
        {
            List<CadastroPedidosDoDia> cadastrosdodia = new List<CadastroPedidosDoDia>();
            try
            {
                conexaoSql.Open();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM pedidosdodia", conexaoSql);
                MySqlDataReader leitor = comando.ExecuteReader();
                while (leitor.Read())
                {
                    string matricula = leitor.GetString("matricula");
                    int tickets = leitor.GetInt32("tickets");
                    DateTime data = leitor.GetDateTime("datadodia");
                    CadastroPedidosDoDia cadastro = new CadastroPedidosDoDia(matricula, tickets, data);
                    cadastrosdodia.Add(cadastro);
                }
            }
            catch (Exception ex)
            {
                Alerta alerta = new Alerta("Não foi retornado nenhum cadastro!");
                Console.WriteLine(ex.Message);
                alerta.Show();

            }
            finally
            {
                conexaoSql.Close();
            }
            return cadastrosdodia;
        }
        public List<string> buscarBancoPedidosDoDia_Contato()
        {
            List<string> series = new List<string>();
            try
            {
                conexaoSql.Open();
                MySqlCommand comando = new MySqlCommand("select cadastro.serie from pedidosdodia INNER JOIN cadastro on pedidosdodia.matricula=cadastro.matricula;", conexaoSql);
                MySqlDataReader leitor = comando.ExecuteReader();
                while (leitor.Read())
                {
                    string le = leitor.GetString("serie");
                    series.Add(le);
                }
            }
            catch (Exception ex)
            {
                Alerta alerta = new Alerta("Não foi retornado nenhum cadastro!");
                Console.WriteLine(ex.Message);
                alerta.Show();

            }
            finally
            {
                conexaoSql.Close();
            }
            return series;

        }
        public void resetarBancoPedidosDiarios()
        {
            try
            {
                conexaoSql.Open();
                MySqlCommand comando = new MySqlCommand("DELETE FROM pedidosdodia", conexaoSql);
                comando.ExecuteNonQuery();
                Alerta alerta = new Alerta("Banco de dados Resetado!");
                alerta.Show();
            }
            catch (Exception ex)
            {
                Alerta alerta = new Alerta("Erro ao resetar!");
                Console.WriteLine(ex.Message);
                alerta.Show();
            }
            finally { conexaoSql.Close(); }
        }
    }
}
