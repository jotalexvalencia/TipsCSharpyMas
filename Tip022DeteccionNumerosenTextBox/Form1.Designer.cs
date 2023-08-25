namespace Tip022DeteccionNumerosenTextBox
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
            lblDato = new Label();
            txtDato = new TextBox();
            btnDetecta = new Button();
            SuspendLayout();
            // 
            // lblDato
            // 
            lblDato.AutoSize = true;
            lblDato.Location = new Point(11, 26);
            lblDato.Name = "lblDato";
            lblDato.Size = new Size(32, 15);
            lblDato.TabIndex = 0;
            lblDato.Text = "Dato";
            // 
            // txtDato
            // 
            txtDato.Location = new Point(49, 18);
            txtDato.Name = "txtDato";
            txtDato.Size = new Size(100, 23);
            txtDato.TabIndex = 1;
            // 
            // btnDetecta
            // 
            btnDetecta.Location = new Point(184, 18);
            btnDetecta.Name = "btnDetecta";
            btnDetecta.Size = new Size(75, 23);
            btnDetecta.TabIndex = 2;
            btnDetecta.Text = "Detecta";
            btnDetecta.UseVisualStyleBackColor = true;
            btnDetecta.Click += btnDetecta_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 257);
            Controls.Add(btnDetecta);
            Controls.Add(txtDato);
            Controls.Add(lblDato);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDato;
        private TextBox txtDato;
        private Button btnDetecta;
    }
}