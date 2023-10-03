namespace Tip23_ConsolayForm
{
    partial class Form1
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
            txtDato = new TextBox();
            lblMensaje = new Label();
            btnAConsola = new Button();
            btnPide = new Button();
            SuspendLayout();
            // 
            // txtDato
            // 
            txtDato.Location = new Point(20, 24);
            txtDato.Name = "txtDato";
            txtDato.Size = new Size(100, 23);
            txtDato.TabIndex = 0;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(23, 60);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(38, 15);
            lblMensaje.TabIndex = 1;
            lblMensaje.Text = "label1";
            // 
            // btnAConsola
            // 
            btnAConsola.Location = new Point(144, 24);
            btnAConsola.Name = "btnAConsola";
            btnAConsola.Size = new Size(75, 23);
            btnAConsola.TabIndex = 2;
            btnAConsola.Text = "A Consola";
            btnAConsola.UseVisualStyleBackColor = true;
            btnAConsola.Click += btnAConsola_Click;
            // 
            // btnPide
            // 
            btnPide.Location = new Point(145, 54);
            btnPide.Name = "btnPide";
            btnPide.Size = new Size(75, 23);
            btnPide.TabIndex = 3;
            btnPide.Text = "Pide";
            btnPide.UseVisualStyleBackColor = true;
            btnPide.Click += btnPide_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 275);
            Controls.Add(btnPide);
            Controls.Add(btnAConsola);
            Controls.Add(lblMensaje);
            Controls.Add(txtDato);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDato;
        private Label lblMensaje;
        private Button btnAConsola;
        private Button btnPide;
    }
}