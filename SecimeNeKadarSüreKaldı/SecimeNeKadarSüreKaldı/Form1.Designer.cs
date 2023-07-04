namespace SecimeNeKadarSüreKaldı
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnSend = new Button();
            richTextBox1 = new RichTextBox();
            dataGridView1 = new DataGridView();
            btnDelete = new Button();
            textBox2 = new TextBox();
            label10 = new Label();
            btnUpdate = new Button();
            button2 = new Button();
            label9 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 64);
            label1.Name = "label1";
            label1.Size = new Size(256, 38);
            label1.TabIndex = 1;
            label1.Text = "Seçime kalan gün:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(285, 74);
            label2.Name = "label2";
            label2.Size = new Size(79, 31);
            label2.TabIndex = 2;
            label2.Text = "label2";
            //label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(285, 105);
            label3.Name = "label3";
            label3.Size = new Size(79, 31);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(201, 143);
            label4.Name = "label4";
            label4.Size = new Size(78, 38);
            label4.TabIndex = 1;
            label4.Text = "saat:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(167, 105);
            label5.Name = "label5";
            label5.Size = new Size(112, 38);
            label5.TabIndex = 1;
            label5.Text = "dakika:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(172, 181);
            label6.Name = "label6";
            label6.Size = new Size(107, 38);
            label6.TabIndex = 1;
            label6.Text = "saniye:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(285, 150);
            label7.Name = "label7";
            label7.Size = new Size(79, 31);
            label7.TabIndex = 4;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(285, 186);
            label8.Name = "label8";
            label8.Size = new Size(79, 31);
            label8.TabIndex = 5;
            label8.Text = "label8";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(419, 336);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(321, 29);
            btnSend.TabIndex = 8;
            btnSend.Text = "Geri bildirim gönder";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(419, 64);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(320, 256);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(785, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(316, 256);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            //dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(785, 336);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(97, 425);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(166, 27);
            textBox2.TabIndex = 15;
            //textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 425);
            label10.Name = "label10";
            label10.Size = new Size(73, 20);
            label10.TabIndex = 18;
            label10.Text = "Açıklama:";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(124, 474);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(497, 457);
            button2.Name = "button2";
            button2.Size = new Size(137, 29);
            button2.TabIndex = 20;
            button2.Text = "Form 2'ye geç";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(184, 241);
            label9.Name = "label9";
            label9.Size = new Size(81, 31);
            label9.TabIndex = 21;
            label9.Text = "Salise:";
            //label9.Click += label9_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(272, 241);
            label11.Name = "label11";
            label11.Size = new Size(92, 31);
            label11.TabIndex = 22;
            label11.Text = "label11";
            //label11.Click += label11_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 610);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(btnUpdate);
            Controls.Add(label10);
            Controls.Add(textBox2);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Controls.Add(richTextBox1);
            Controls.Add(btnSend);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGeriBildirim;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private System.Windows.Forms.Timer timer1;
        private Button btnSend;
        private RichTextBox richTextBox1;
        private DataGridView dataGridView1;
        private Button btnDelete;
        private TextBox textBox2;
        private Button button1;
        private Label label10;
        private Button btnUpdate_Click;
        private Button btnUpdate;
        private Button button2;
        private Label label9;
        private Label label11;
    }
}