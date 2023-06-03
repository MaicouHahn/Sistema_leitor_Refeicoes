namespace WinFormsApp1
{
    partial class TelaLogin
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
            Entrar = new Button();
            Usuario = new Label();
            usuarioTextBox = new TextBox();
            senhaTextBox = new TextBox();
            Senha = new Label();
            SuspendLayout();
            // 
            // Entrar
            // 
            Entrar.Location = new Point(82, 141);
            Entrar.Name = "Entrar";
            Entrar.Size = new Size(75, 28);
            Entrar.TabIndex = 0;
            Entrar.Text = "Entrar";
            Entrar.UseVisualStyleBackColor = true;
            Entrar.Click += button1_Click;
            // 
            // Usuario
            // 
            Usuario.AutoSize = true;
            Usuario.Location = new Point(43, 23);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(47, 15);
            Usuario.TabIndex = 1;
            Usuario.Text = "Usuario";
            // 
            // usuarioTextBox
            // 
            usuarioTextBox.Location = new Point(43, 41);
            usuarioTextBox.Name = "usuarioTextBox";
            usuarioTextBox.Size = new Size(155, 23);
            usuarioTextBox.TabIndex = 2;
            // 
            // senhaTextBox
            // 
            senhaTextBox.Location = new Point(43, 97);
            senhaTextBox.Name = "senhaTextBox";
            senhaTextBox.PasswordChar = '*';
            senhaTextBox.Size = new Size(155, 23);
            senhaTextBox.TabIndex = 4;
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Location = new Point(43, 79);
            Senha.Name = "Senha";
            Senha.Size = new Size(39, 15);
            Senha.TabIndex = 3;
            Senha.Text = "Senha";
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 198);
            Controls.Add(senhaTextBox);
            Controls.Add(Senha);
            Controls.Add(usuarioTextBox);
            Controls.Add(Usuario);
            Controls.Add(Entrar);
            MaximumSize = new Size(269, 237);
            MinimumSize = new Size(269, 237);
            Name = "TelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Entrar;
        private Label Usuario;
        private TextBox usuarioTextBox;
        private TextBox senhaTextBox;
        private Label Senha;
    }
}