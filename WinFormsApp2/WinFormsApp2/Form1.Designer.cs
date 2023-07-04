namespace WinFormsApp2
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
            txtKanGrubu = new TextBox();
            lblSonuc = new Label();
            btnKontrolEt = new Button();
            SuspendLayout();
            // 
            // txtKanGrubu
            // 
            txtKanGrubu.Location = new Point(294, 180);
            txtKanGrubu.Name = "txtKanGrubu";
            txtKanGrubu.Size = new Size(158, 27);
            txtKanGrubu.TabIndex = 0;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(339, 288);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(52, 20);
            lblSonuc.TabIndex = 1;
            lblSonuc.Text = "Sonuç:";
            lblSonuc.Click += lblSonuc_Click;
            // 
            // btnKontrolEt
            // 
            btnKontrolEt.Location = new Point(324, 234);
            btnKontrolEt.Name = "btnKontrolEt";
            btnKontrolEt.Size = new Size(94, 29);
            btnKontrolEt.TabIndex = 2;
            btnKontrolEt.Text = "Kontrol Et";
            btnKontrolEt.UseVisualStyleBackColor = true;
            btnKontrolEt.Click += btnKontrolEt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKontrolEt);
            Controls.Add(lblSonuc);
            Controls.Add(txtKanGrubu);
            Name = "Form1";
            Text = "Kan Grubu Uygulaması";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKanGrubu;
        private Label lblSonuc;
        private Button btnKontrolEt;
    }
}