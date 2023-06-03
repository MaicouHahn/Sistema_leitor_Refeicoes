namespace WinFormsApp1
{
    partial class TelaUsuarioComum
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
            contadordeTickets = new TextBox();
            label14 = new Label();
            dataGridView1 = new DataGridView();
            Matricula_ = new DataGridViewTextBoxColumn();
            Tickets_ = new DataGridViewTextBoxColumn();
            DataCadastro_ = new DataGridViewTextBoxColumn();
            Listar = new Button();
            tabControl1 = new TabControl();
            Listagem = new TabPage();
            button1 = new Button();
            almocoECafeTarde = new TextBox();
            label3 = new Label();
            cafesdaManha = new TextBox();
            label2 = new Label();
            totalDeAlunos = new TextBox();
            label1 = new Label();
            label15 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            Listagem.SuspendLayout();
            SuspendLayout();
            // 
            // contadordeTickets
            // 
            contadordeTickets.Location = new Point(199, 284);
            contadordeTickets.Name = "contadordeTickets";
            contadordeTickets.ReadOnly = true;
            contadordeTickets.Size = new Size(100, 23);
            contadordeTickets.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(9, 284);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Matricula_, Tickets_, DataCadastro_ });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(348, 272);
            dataGridView1.TabIndex = 1;
            // 
            // Matricula_
            // 
            Matricula_.HeaderText = "Matricula";
            Matricula_.Name = "Matricula_";
            Matricula_.ReadOnly = true;
            // 
            // Tickets_
            // 
            Tickets_.HeaderText = "Tickets";
            Tickets_.Name = "Tickets_";
            Tickets_.ReadOnly = true;
            // 
            // DataCadastro_
            // 
            DataCadastro_.HeaderText = "Data de Cadastro";
            DataCadastro_.Name = "DataCadastro_";
            DataCadastro_.ReadOnly = true;
            // 
            // Listar
            // 
            Listar.Location = new Point(228, 424);
            Listar.Name = "Listar";
            Listar.Size = new Size(100, 23);
            Listar.TabIndex = 0;
            Listar.Text = "Registrar Ticket";
            Listar.UseVisualStyleBackColor = true;
            Listar.Click += Listar_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Listagem);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(347, 481);
            tabControl1.TabIndex = 1;
            // 
            // Listagem
            // 
            Listagem.Controls.Add(button1);
            Listagem.Controls.Add(almocoECafeTarde);
            Listagem.Controls.Add(label3);
            Listagem.Controls.Add(cafesdaManha);
            Listagem.Controls.Add(label2);
            Listagem.Controls.Add(totalDeAlunos);
            Listagem.Controls.Add(label1);
            Listagem.Controls.Add(contadordeTickets);
            Listagem.Controls.Add(label15);
            Listagem.Controls.Add(label14);
            Listagem.Controls.Add(dataGridView1);
            Listagem.Controls.Add(Listar);
            Listagem.Location = new Point(4, 24);
            Listagem.Name = "Listagem";
            Listagem.Padding = new Padding(3);
            Listagem.Size = new Size(339, 453);
            Listagem.TabIndex = 0;
            Listagem.Text = "Listagem";
            Listagem.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(9, 424);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // almocoECafeTarde
            // 
            almocoECafeTarde.Location = new Point(199, 371);
            almocoECafeTarde.Name = "almocoECafeTarde";
            almocoECafeTarde.ReadOnly = true;
            almocoECafeTarde.Size = new Size(100, 23);
            almocoECafeTarde.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 371);
            label3.Name = "label3";
            label3.Size = new Size(142, 15);
            label3.TabIndex = 9;
            label3.Text = "Almoços e Cafés da Tarde";
            // 
            // cafesdaManha
            // 
            cafesdaManha.Location = new Point(199, 342);
            cafesdaManha.Name = "cafesdaManha";
            cafesdaManha.ReadOnly = true;
            cafesdaManha.Size = new Size(100, 23);
            cafesdaManha.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 342);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 7;
            label2.Text = "Cafés da Manhã";
            // 
            // totalDeAlunos
            // 
            totalDeAlunos.Location = new Point(199, 313);
            totalDeAlunos.Name = "totalDeAlunos";
            totalDeAlunos.ReadOnly = true;
            totalDeAlunos.Size = new Size(100, 23);
            totalDeAlunos.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 313);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 5;
            label1.Text = "Total de Alunos:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(100, 284);
            label15.Name = "label15";
            label15.Size = new Size(0, 15);
            label15.TabIndex = 3;
            // 
            // TelaUsuarioComum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 505);
            Controls.Add(tabControl1);
            MaximumSize = new Size(384, 544);
            MinimumSize = new Size(384, 544);
            Name = "TelaUsuarioComum";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaUsuarioComum";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            Listagem.ResumeLayout(false);
            Listagem.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox contadordeTickets;
        private Label label14;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Matricula_;
        private DataGridViewTextBoxColumn Tickets_;
        private DataGridViewTextBoxColumn DataCadastro_;
        private Button Listar;
        private TabControl tabControl1;
        private TabPage Listagem;
        private Label label15;
        private TextBox almocoECafeTarde;
        private Label label3;
        private TextBox cafesdaManha;
        private Label label2;
        private TextBox totalDeAlunos;
        private Label label1;
        private Button button1;
    }
}