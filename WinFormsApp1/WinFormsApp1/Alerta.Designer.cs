namespace WinFormsApp1
{
    partial class Alerta
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private String msg;

        public Alerta(string mensagem)
        {
            InitializeComponent();
            msg = mensagem;
            avisoLabel.Text = msg;
            this.Show();

        }
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
            avisoLabel = new Label();
            SuspendLayout();
            // 
            // avisoLabel
            // 
            avisoLabel.AutoSize = true;
            avisoLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            avisoLabel.Location = new Point(0, 0);
            avisoLabel.Margin = new Padding(2, 0, 2, 0);
            avisoLabel.Name = "avisoLabel";
            avisoLabel.Size = new Size(0, 45);
            avisoLabel.TabIndex = 0;
            avisoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Alerta
            // 
            AutoScaleDimensions = new SizeF(5F, 11F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(144, 118);
            Controls.Add(avisoLabel);
            Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(2);
            Name = "Alerta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alerta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label avisoLabel;
    }
}