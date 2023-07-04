namespace UniDb
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
            btnilceler = new Button();
            btnil = new Button();
            btlbolum = new Button();
            btnOgretmen = new Button();
            SuspendLayout();
            // 
            // btnilceler
            // 
            btnilceler.Location = new Point(12, 64);
            btnilceler.Name = "btnilceler";
            btnilceler.Size = new Size(147, 110);
            btnilceler.TabIndex = 0;
            btnilceler.Text = "İlceler Tablosu";
            btnilceler.UseVisualStyleBackColor = true;
            btnilceler.Click += btnilceler_Click;
            // 
            // btnil
            // 
            btnil.Location = new Point(229, 64);
            btnil.Name = "btnil";
            btnil.Size = new Size(147, 110);
            btnil.TabIndex = 0;
            btnil.Text = "İl Tablosu";
            btnil.UseVisualStyleBackColor = true;
            btnil.Click += btnil_Click;
            // 
            // btlbolum
            // 
            btlbolum.Location = new Point(433, 64);
            btlbolum.Name = "btlbolum";
            btlbolum.Size = new Size(147, 110);
            btlbolum.TabIndex = 0;
            btlbolum.Text = "Bölümler";
            btlbolum.UseVisualStyleBackColor = true;
            btlbolum.Click += btlbolum_Click;
            // 
            // btnOgretmen
            // 
            btnOgretmen.Location = new Point(625, 64);
            btnOgretmen.Name = "btnOgretmen";
            btnOgretmen.Size = new Size(147, 110);
            btnOgretmen.TabIndex = 0;
            btnOgretmen.Text = "Öğretmenler";
            btnOgretmen.UseVisualStyleBackColor = true;
            btnOgretmen.Click += btnOgretmen_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 500);
            Controls.Add(btnOgretmen);
            Controls.Add(btlbolum);
            Controls.Add(btnil);
            Controls.Add(btnilceler);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnilceler;
        private Button btnil;
        private Button btlbolum;
        private Button btnOgretmen;
    }
}