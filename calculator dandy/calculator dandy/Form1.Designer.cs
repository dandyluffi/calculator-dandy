namespace calculator_dandy
{
    partial class Form1
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
            this.ter = new System.Windows.Forms.Label();
            this.terserah2 = new System.Windows.Forms.Label();
            this.Operasi = new System.Windows.Forms.Label();
            this.NilaiB = new System.Windows.Forms.TextBox();
            this.Nilai1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Hasil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ter
            // 
            this.ter.AutoSize = true;
            this.ter.Font = new System.Drawing.Font("Lemon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ter.Location = new System.Drawing.Point(230, 120);
            this.ter.Name = "ter";
            this.ter.Size = new System.Drawing.Size(85, 26);
            this.ter.TabIndex = 0;
            this.ter.Text = "Nilai 1";
            // 
            // terserah2
            // 
            this.terserah2.AutoSize = true;
            this.terserah2.Font = new System.Drawing.Font("Lemon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terserah2.Location = new System.Drawing.Point(750, 120);
            this.terserah2.Name = "terserah2";
            this.terserah2.Size = new System.Drawing.Size(88, 26);
            this.terserah2.TabIndex = 1;
            this.terserah2.Text = "Nilai 2";
            // 
            // Operasi
            // 
            this.Operasi.AutoSize = true;
            this.Operasi.Font = new System.Drawing.Font("Lemon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operasi.Location = new System.Drawing.Point(473, 145);
            this.Operasi.Name = "Operasi";
            this.Operasi.Size = new System.Drawing.Size(101, 26);
            this.Operasi.TabIndex = 2;
            this.Operasi.Text = "Operasi";
            // 
            // NilaiB
            // 
            this.NilaiB.Location = new System.Drawing.Point(680, 149);
            this.NilaiB.MaximumSize = new System.Drawing.Size(200, 50);
            this.NilaiB.MinimumSize = new System.Drawing.Size(200, 50);
            this.NilaiB.Name = "NilaiB";
            this.NilaiB.Size = new System.Drawing.Size(200, 50);
            this.NilaiB.TabIndex = 4;
            // 
            // Nilai1
            // 
            this.Nilai1.Location = new System.Drawing.Point(171, 151);
            this.Nilai1.MaximumSize = new System.Drawing.Size(200, 50);
            this.Nilai1.MinimumSize = new System.Drawing.Size(200, 50);
            this.Nilai1.Name = "Nilai1";
            this.Nilai1.Size = new System.Drawing.Size(200, 50);
            this.Nilai1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            ":"});
            this.comboBox1.Location = new System.Drawing.Point(474, 177);
            this.comboBox1.MaximumSize = new System.Drawing.Size(100, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Lemon", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(432, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "EXECUTE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lemon", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "TOTAL";
            // 
            // Hasil
            // 
            this.Hasil.Location = new System.Drawing.Point(432, 445);
            this.Hasil.Name = "Hasil";
            this.Hasil.Size = new System.Drawing.Size(175, 22);
            this.Hasil.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yellowtail", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(957, 624);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = "dandyluffi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::calculator_dandy.Properties.Resources.pan_0;
            this.ClientSize = new System.Drawing.Size(1085, 668);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Hasil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Nilai1);
            this.Controls.Add(this.NilaiB);
            this.Controls.Add(this.Operasi);
            this.Controls.Add(this.terserah2);
            this.Controls.Add(this.ter);
            this.Name = "Form1";
            this.Text = "calculator dandy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ter;
        private System.Windows.Forms.Label terserah2;
        private System.Windows.Forms.Label Operasi;
        private System.Windows.Forms.TextBox NilaiB;
        private System.Windows.Forms.TextBox Nilai1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Hasil;
        private System.Windows.Forms.Label label2;
    }
}

