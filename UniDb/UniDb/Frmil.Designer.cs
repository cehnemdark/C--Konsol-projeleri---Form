namespace UniDb
{
    partial class Frmil
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
            dataGridView2 = new DataGridView();
            BtnSend2 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(36, 21);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(741, 265);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtnSend2
            // 
            BtnSend2.Location = new Point(248, 375);
            BtnSend2.Name = "BtnSend2";
            BtnSend2.Size = new Size(125, 47);
            BtnSend2.TabIndex = 1;
            BtnSend2.Text = "Ekle";
            BtnSend2.UseVisualStyleBackColor = true;
            BtnSend2.Click += BtnSend2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(248, 331);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 331);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 3;
            label1.Text = "İl ekle:";
            // 
            // Frmil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(BtnSend2);
            Controls.Add(dataGridView2);
            Name = "Frmil";
            Text = "Frmil";
            WindowState = FormWindowState.Maximized;
            Load += Frmil_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button button1;
        private TextBox textBox1;
        private Button BtnSend2;
        private TextBox textBox2;
        private Label label1;
    }
}