namespace WinFormsApp1
{
    partial class Alerta
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private String msg;

        public Alerta(String mensagem)
        {
            InitializeComponent();
            msg = mensagem;
            avisoLabel.Text = msg;

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
            avisoLabel.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            avisoLabel.Location = new Point(29, 36);
            avisoLabel.Margin = new Padding(2, 0, 2, 0);
            avisoLabel.Name = "avisoLabel";
            avisoLabel.Size = new Size(0, 46);
            avisoLabel.TabIndex = 0;
            // 
            // Alerta
            // 
            AutoScaleDimensions = new SizeF(5F, 11F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(144, 118);
            Controls.Add(avisoLabel);
            Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(2);
            Name = "Alerta";
            Text = "Alerta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label avisoLabel;
    }
}