namespace WinFormsApp1
{
    partial class TelaUsuarioADM
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
            tabControl1 = new TabControl();
            Listagem = new TabPage();
            contadordeTickets = new TextBox();
            label15 = new Label();
            label14 = new Label();
            dataGridView1 = new DataGridView();
            Nome_ = new DataGridViewTextBoxColumn();
            Sobrenome_ = new DataGridViewTextBoxColumn();
            Serie_ = new DataGridViewTextBoxColumn();
            Matricula_ = new DataGridViewTextBoxColumn();
            Email_ = new DataGridViewTextBoxColumn();
            Telefone_ = new DataGridViewTextBoxColumn();
            DataCadastro_ = new DataGridViewTextBoxColumn();
            Listar = new Button();
            Cadastro = new TabPage();
            panel1 = new Panel();
            button5 = new Button();
            AnoLetivo = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            sobrenomeCadastroTextBox = new TextBox();
            button1 = new Button();
            Nome = new Label();
            label5 = new Label();
            nomeCadastroTextBox = new TextBox();
            label4 = new Label();
            emailCadastroTextBox = new TextBox();
            label3 = new Label();
            telefoneCadastroTextBox = new TextBox();
            label2 = new Label();
            matriculaCadastroTextBox = new TextBox();
            tokenCadastroTextBox = new TextBox();
            Editar_Cadastro = new TabPage();
            panel2 = new Panel();
            button7 = new Button();
            groupBox1 = new GroupBox();
            button4 = new Button();
            CarregarInfo = new Button();
            label12 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            editarCadastroSobrenomeTextBox = new TextBox();
            button2 = new Button();
            label7 = new Label();
            label8 = new Label();
            editarCadastroNomeTextBox = new TextBox();
            label9 = new Label();
            editarEmailTextBox = new TextBox();
            label10 = new Label();
            editarTelefoneTextBox = new TextBox();
            label13 = new Label();
            editarMatriculaTextBox = new TextBox();
            editarTokenTextBox = new TextBox();
            Excluir_Cadastro = new TabPage();
            button8 = new Button();
            excluirMatriculaTextBox = new TextBox();
            label16 = new Label();
            button9 = new Button();
            button6 = new Button();
            excluirTokenTextBox = new TextBox();
            label11 = new Label();
            button3 = new Button();
            tabPage1 = new TabPage();
            senhaTextBox = new TextBox();
            Senha = new Label();
            usuarioTextBox = new TextBox();
            Usuario = new Label();
            Entrar = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tabControl1.SuspendLayout();
            Listagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Cadastro.SuspendLayout();
            panel1.SuspendLayout();
            Editar_Cadastro.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            Excluir_Cadastro.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Listagem);
            tabControl1.Controls.Add(Cadastro);
            tabControl1.Controls.Add(Editar_Cadastro);
            tabControl1.Controls.Add(Excluir_Cadastro);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(359, 337);
            tabControl1.TabIndex = 0;
            // 
            // Listagem
            // 
            Listagem.Controls.Add(contadordeTickets);
            Listagem.Controls.Add(label15);
            Listagem.Controls.Add(label14);
            Listagem.Controls.Add(dataGridView1);
            Listagem.Controls.Add(Listar);
            Listagem.Location = new Point(4, 24);
            Listagem.Name = "Listagem";
            Listagem.Padding = new Padding(3);
            Listagem.Size = new Size(351, 309);
            Listagem.TabIndex = 0;
            Listagem.Text = "Listagem";
            Listagem.UseVisualStyleBackColor = true;
            // 
            // contadordeTickets
            // 
            contadordeTickets.Location = new Point(97, 278);
            contadordeTickets.Name = "contadordeTickets";
            contadordeTickets.ReadOnly = true;
            contadordeTickets.Size = new Size(100, 23);
            contadordeTickets.TabIndex = 4;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(97, 281);
            label15.Name = "label15";
            label15.Size = new Size(0, 15);
            label15.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 281);
            label14.Name = "label14";
            label14.Size = new Size(88, 15);
            label14.TabIndex = 2;
            label14.Text = "Total de tickets:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nome_, Sobrenome_, Serie_, Matricula_, Email_, Telefone_, DataCadastro_ });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(350, 272);
            dataGridView1.TabIndex = 1;
            // 
            // Nome_
            // 
            Nome_.HeaderText = "Nome";
            Nome_.Name = "Nome_";
            Nome_.ReadOnly = true;
            // 
            // Sobrenome_
            // 
            Sobrenome_.HeaderText = "Sobrenome";
            Sobrenome_.Name = "Sobrenome_";
            Sobrenome_.ReadOnly = true;
            // 
            // Serie_
            // 
            Serie_.HeaderText = "Serie";
            Serie_.Name = "Serie_";
            Serie_.ReadOnly = true;
            // 
            // Matricula_
            // 
            Matricula_.HeaderText = "Matricula";
            Matricula_.Name = "Matricula_";
            Matricula_.ReadOnly = true;
            // 
            // Email_
            // 
            Email_.HeaderText = "Email";
            Email_.Name = "Email_";
            Email_.ReadOnly = true;
            // 
            // Telefone_
            // 
            Telefone_.HeaderText = "Telefone";
            Telefone_.Name = "Telefone_";
            Telefone_.ReadOnly = true;
            // 
            // DataCadastro_
            // 
            DataCadastro_.HeaderText = "Data de Cadastro";
            DataCadastro_.Name = "DataCadastro_";
            DataCadastro_.ReadOnly = true;
            // 
            // Listar
            // 
            Listar.Location = new Point(245, 277);
            Listar.Name = "Listar";
            Listar.Size = new Size(100, 23);
            Listar.TabIndex = 0;
            Listar.Text = "Listar Cadastros";
            Listar.UseVisualStyleBackColor = true;
            Listar.Click += button4_Click_1;
            // 
            // Cadastro
            // 
            Cadastro.Controls.Add(panel1);
            Cadastro.Location = new Point(4, 24);
            Cadastro.Name = "Cadastro";
            Cadastro.Padding = new Padding(3);
            Cadastro.Size = new Size(351, 309);
            Cadastro.TabIndex = 1;
            Cadastro.Text = "Cadastro";
            Cadastro.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(button5);
            panel1.Controls.Add(AnoLetivo);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(sobrenomeCadastroTextBox);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Nome);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(nomeCadastroTextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(emailCadastroTextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(telefoneCadastroTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(matriculaCadastroTextBox);
            panel1.Controls.Add(tokenCadastroTextBox);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 317);
            panel1.TabIndex = 1;
            // 
            // button5
            // 
            button5.Location = new Point(143, 252);
            button5.Name = "button5";
            button5.Size = new Size(93, 23);
            button5.TabIndex = 15;
            button5.Text = "Inserir Token";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // AnoLetivo
            // 
            AnoLetivo.AutoSize = true;
            AnoLetivo.Location = new Point(46, 218);
            AnoLetivo.Name = "AnoLetivo";
            AnoLetivo.Size = new Size(64, 15);
            AnoLetivo.TabIndex = 14;
            AnoLetivo.Text = "Ano Letivo";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1º Ano", "2º Ano", "3º Ano" });
            comboBox1.Location = new Point(142, 219);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(94, 23);
            comboBox1.TabIndex = 13;
            comboBox1.Text = "Selecione";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 73);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 12;
            label1.Text = "Sobrenome";
            // 
            // sobrenomeCadastroTextBox
            // 
            sobrenomeCadastroTextBox.Location = new Point(142, 73);
            sobrenomeCadastroTextBox.Name = "sobrenomeCadastroTextBox";
            sobrenomeCadastroTextBox.Size = new Size(175, 23);
            sobrenomeCadastroTextBox.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(242, 218);
            button1.Name = "button1";
            button1.Size = new Size(75, 24);
            button1.TabIndex = 10;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(46, 41);
            Nome.Name = "Nome";
            Nome.Size = new Size(40, 15);
            Nome.TabIndex = 5;
            Nome.Text = "Nome";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 189);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 9;
            label5.Text = "Token";
            // 
            // nomeCadastroTextBox
            // 
            nomeCadastroTextBox.Location = new Point(142, 41);
            nomeCadastroTextBox.Name = "nomeCadastroTextBox";
            nomeCadastroTextBox.Size = new Size(175, 23);
            nomeCadastroTextBox.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 160);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 8;
            label4.Text = "Matricula";
            // 
            // emailCadastroTextBox
            // 
            emailCadastroTextBox.Location = new Point(142, 131);
            emailCadastroTextBox.Name = "emailCadastroTextBox";
            emailCadastroTextBox.Size = new Size(175, 23);
            emailCadastroTextBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 131);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 7;
            label3.Text = "E-mail";
            // 
            // telefoneCadastroTextBox
            // 
            telefoneCadastroTextBox.Location = new Point(142, 102);
            telefoneCadastroTextBox.Name = "telefoneCadastroTextBox";
            telefoneCadastroTextBox.Size = new Size(175, 23);
            telefoneCadastroTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 102);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 6;
            label2.Text = "Telefone";
            // 
            // matriculaCadastroTextBox
            // 
            matriculaCadastroTextBox.Location = new Point(142, 160);
            matriculaCadastroTextBox.Name = "matriculaCadastroTextBox";
            matriculaCadastroTextBox.Size = new Size(175, 23);
            matriculaCadastroTextBox.TabIndex = 3;
            // 
            // tokenCadastroTextBox
            // 
            tokenCadastroTextBox.Location = new Point(142, 189);
            tokenCadastroTextBox.Name = "tokenCadastroTextBox";
            tokenCadastroTextBox.ReadOnly = true;
            tokenCadastroTextBox.Size = new Size(175, 23);
            tokenCadastroTextBox.TabIndex = 4;
            // 
            // Editar_Cadastro
            // 
            Editar_Cadastro.Controls.Add(panel2);
            Editar_Cadastro.Location = new Point(4, 24);
            Editar_Cadastro.Name = "Editar_Cadastro";
            Editar_Cadastro.Padding = new Padding(3);
            Editar_Cadastro.Size = new Size(351, 309);
            Editar_Cadastro.TabIndex = 2;
            Editar_Cadastro.Text = "Editar Cadastro";
            Editar_Cadastro.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(button7);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(editarCadastroSobrenomeTextBox);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(editarCadastroNomeTextBox);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(editarEmailTextBox);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(editarTelefoneTextBox);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(editarMatriculaTextBox);
            panel2.Controls.Add(editarTokenTextBox);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(355, 317);
            panel2.TabIndex = 2;
            // 
            // button7
            // 
            button7.Location = new Point(242, 190);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 19;
            button7.Text = "ED Token";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(CarregarInfo);
            groupBox1.Location = new Point(46, 248);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(271, 43);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar por";
            // 
            // button4
            // 
            button4.Location = new Point(141, 14);
            button4.Name = "button4";
            button4.Size = new Size(103, 23);
            button4.TabIndex = 17;
            button4.Text = "Matricula";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_2;
            // 
            // CarregarInfo
            // 
            CarregarInfo.Location = new Point(28, 14);
            CarregarInfo.Name = "CarregarInfo";
            CarregarInfo.Size = new Size(94, 23);
            CarregarInfo.TabIndex = 13;
            CarregarInfo.Text = "Token";
            CarregarInfo.UseVisualStyleBackColor = true;
            CarregarInfo.Click += button4_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(46, 218);
            label12.Name = "label12";
            label12.Size = new Size(64, 15);
            label12.TabIndex = 16;
            label12.Text = "Ano Letivo";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1º Ano", "2º Ano", "3º Ano" });
            comboBox2.Location = new Point(142, 219);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(94, 23);
            comboBox2.TabIndex = 15;
            comboBox2.Text = "Selecione";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 73);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 12;
            label6.Text = "Sobrenome";
            // 
            // editarCadastroSobrenomeTextBox
            // 
            editarCadastroSobrenomeTextBox.Location = new Point(142, 73);
            editarCadastroSobrenomeTextBox.Name = "editarCadastroSobrenomeTextBox";
            editarCadastroSobrenomeTextBox.Size = new Size(175, 23);
            editarCadastroSobrenomeTextBox.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(242, 219);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 41);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 5;
            label7.Text = "Nome";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 189);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 9;
            label8.Text = "Token";
            // 
            // editarCadastroNomeTextBox
            // 
            editarCadastroNomeTextBox.Location = new Point(142, 41);
            editarCadastroNomeTextBox.Name = "editarCadastroNomeTextBox";
            editarCadastroNomeTextBox.Size = new Size(175, 23);
            editarCadastroNomeTextBox.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(46, 160);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 8;
            label9.Text = "Matricula";
            // 
            // editarEmailTextBox
            // 
            editarEmailTextBox.Location = new Point(142, 131);
            editarEmailTextBox.Name = "editarEmailTextBox";
            editarEmailTextBox.Size = new Size(175, 23);
            editarEmailTextBox.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(46, 131);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 7;
            label10.Text = "E-mail";
            // 
            // editarTelefoneTextBox
            // 
            editarTelefoneTextBox.Location = new Point(142, 102);
            editarTelefoneTextBox.Name = "editarTelefoneTextBox";
            editarTelefoneTextBox.Size = new Size(175, 23);
            editarTelefoneTextBox.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(46, 102);
            label13.Name = "label13";
            label13.Size = new Size(51, 15);
            label13.TabIndex = 6;
            label13.Text = "Telefone";
            // 
            // editarMatriculaTextBox
            // 
            editarMatriculaTextBox.Location = new Point(142, 160);
            editarMatriculaTextBox.Name = "editarMatriculaTextBox";
            editarMatriculaTextBox.Size = new Size(175, 23);
            editarMatriculaTextBox.TabIndex = 3;
            // 
            // editarTokenTextBox
            // 
            editarTokenTextBox.Location = new Point(142, 189);
            editarTokenTextBox.Name = "editarTokenTextBox";
            editarTokenTextBox.ReadOnly = true;
            editarTokenTextBox.Size = new Size(94, 23);
            editarTokenTextBox.TabIndex = 4;
            // 
            // Excluir_Cadastro
            // 
            Excluir_Cadastro.Controls.Add(button8);
            Excluir_Cadastro.Controls.Add(excluirMatriculaTextBox);
            Excluir_Cadastro.Controls.Add(label16);
            Excluir_Cadastro.Controls.Add(button9);
            Excluir_Cadastro.Controls.Add(button6);
            Excluir_Cadastro.Controls.Add(excluirTokenTextBox);
            Excluir_Cadastro.Controls.Add(label11);
            Excluir_Cadastro.Controls.Add(button3);
            Excluir_Cadastro.Location = new Point(4, 24);
            Excluir_Cadastro.Name = "Excluir_Cadastro";
            Excluir_Cadastro.Padding = new Padding(3);
            Excluir_Cadastro.Size = new Size(351, 309);
            Excluir_Cadastro.TabIndex = 3;
            Excluir_Cadastro.Text = "Excluir Cadastro";
            Excluir_Cadastro.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(138, 207);
            button8.Name = "button8";
            button8.Size = new Size(97, 23);
            button8.TabIndex = 35;
            button8.Text = "Procurar Matricula";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // excluirMatriculaTextBox
            // 
            excluirMatriculaTextBox.Location = new Point(140, 163);
            excluirMatriculaTextBox.Name = "excluirMatriculaTextBox";
            excluirMatriculaTextBox.Size = new Size(176, 23);
            excluirMatriculaTextBox.TabIndex = 34;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(50, 163);
            label16.Name = "label16";
            label16.Size = new Size(57, 15);
            label16.TabIndex = 33;
            label16.Text = "Matricula";
            // 
            // button9
            // 
            button9.Location = new Point(241, 207);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 32;
            button9.Text = "Excluir";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button6
            // 
            button6.Location = new Point(138, 134);
            button6.Name = "button6";
            button6.Size = new Size(97, 23);
            button6.TabIndex = 31;
            button6.Text = "Procurar Token";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // excluirTokenTextBox
            // 
            excluirTokenTextBox.Location = new Point(140, 90);
            excluirTokenTextBox.Name = "excluirTokenTextBox";
            excluirTokenTextBox.ReadOnly = true;
            excluirTokenTextBox.Size = new Size(176, 23);
            excluirTokenTextBox.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(50, 90);
            label11.Name = "label11";
            label11.Size = new Size(38, 15);
            label11.TabIndex = 28;
            label11.Text = "Token";
            // 
            // button3
            // 
            button3.Location = new Point(241, 134);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 0;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(senhaTextBox);
            tabPage1.Controls.Add(Senha);
            tabPage1.Controls.Add(usuarioTextBox);
            tabPage1.Controls.Add(Usuario);
            tabPage1.Controls.Add(Entrar);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(351, 309);
            tabPage1.TabIndex = 4;
            tabPage1.Text = "Limpar BD dia";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // senhaTextBox
            // 
            senhaTextBox.Location = new Point(94, 140);
            senhaTextBox.Name = "senhaTextBox";
            senhaTextBox.PasswordChar = '*';
            senhaTextBox.Size = new Size(155, 23);
            senhaTextBox.TabIndex = 9;
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Location = new Point(94, 122);
            Senha.Name = "Senha";
            Senha.Size = new Size(39, 15);
            Senha.TabIndex = 8;
            Senha.Text = "Senha";
            // 
            // usuarioTextBox
            // 
            usuarioTextBox.Location = new Point(94, 84);
            usuarioTextBox.Name = "usuarioTextBox";
            usuarioTextBox.Size = new Size(155, 23);
            usuarioTextBox.TabIndex = 7;
            // 
            // Usuario
            // 
            Usuario.AutoSize = true;
            Usuario.Location = new Point(94, 66);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(47, 15);
            Usuario.TabIndex = 6;
            Usuario.Text = "Usuario";
            // 
            // Entrar
            // 
            Entrar.Location = new Point(133, 184);
            Entrar.Name = "Entrar";
            Entrar.Size = new Size(75, 28);
            Entrar.TabIndex = 5;
            Entrar.Text = "Apagar";
            Entrar.UseVisualStyleBackColor = true;
            Entrar.Click += Entrar_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.28465F));
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 13;
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // TelaUsuarioADM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 361);
            Controls.Add(tabControl1);
            Name = "TelaUsuarioADM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaUsuarioADM";
            tabControl1.ResumeLayout(false);
            Listagem.ResumeLayout(false);
            Listagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Cadastro.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Editar_Cadastro.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            Excluir_Cadastro.ResumeLayout(false);
            Excluir_Cadastro.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Listagem;
        private TabPage Cadastro;
        private TabPage Editar_Cadastro;
        private TabPage Excluir_Cadastro;
        private TextBox excluirTokenTextBox;
        private Label label11;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Button button1;
        private Label Nome;
        private Label label5;
        private TextBox nomeCadastroTextBox;
        private Label label4;
        private TextBox emailCadastroTextBox;
        private Label label3;
        private TextBox telefoneCadastroTextBox;
        private Label label2;
        private TextBox matriculaCadastroTextBox;
        private TextBox tokenCadastroTextBox;
        private Label label1;
        private TextBox sobrenomeCadastroTextBox;
        private Panel panel2;
        private Label label6;
        private TextBox editarCadastroSobrenomeTextBox;
        private Button button2;
        private Label label7;
        private Label label8;
        private TextBox editarCadastroNomeTextBox;
        private Label label9;
        private TextBox editarEmailTextBox;
        private Label label10;
        private TextBox editarTelefoneTextBox;
        private Label label13;
        private TextBox editarMatriculaTextBox;
        private TextBox editarTokenTextBox;
        private Button CarregarInfo;
        private Button Listar;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Label AnoLetivo;
        private Label label12;
        private ComboBox comboBox2;
        private DataGridViewTextBoxColumn Nome_;
        private DataGridViewTextBoxColumn Sobrenome_;
        private DataGridViewTextBoxColumn Serie_;
        private DataGridViewTextBoxColumn Matricula_;
        private DataGridViewTextBoxColumn Email_;
        private DataGridViewTextBoxColumn Telefone_;
        private DataGridViewTextBoxColumn DataCadastro_;
        private Button button5;
        private Button button6;
        private Label label14;
        private TextBox contadordeTickets;
        private Label label15;
        private TabPage tabPage1;
        private TextBox senhaTextBox;
        private Label Senha;
        private TextBox usuarioTextBox;
        private Label Usuario;
        private Button Entrar;
        private GroupBox groupBox1;
        private Button button4;
        private Button button7;
        private Button button8;
        private TextBox excluirMatriculaTextBox;
        private Label label16;
        private Button button9;
    }
}