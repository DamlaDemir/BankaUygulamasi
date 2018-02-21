namespace Soru2Banka
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOrtalamaIslem = new System.Windows.Forms.Label();
            this.btnOrtalamaIslem = new System.Windows.Forms.Button();
            this.rtxtListele = new System.Windows.Forms.RichTextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblDongusel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblIslemTamamlanmaKB = new System.Windows.Forms.Label();
            this.btnIslemTamamlanmaKB = new System.Windows.Forms.Button();
            this.rtxtListeleKB = new System.Windows.Forms.RichTextBox();
            this.btnSilOncelikKB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblIslemTamamlanmaBK = new System.Windows.Forms.Label();
            this.btnIslemTamamlanmaBK = new System.Windows.Forms.Button();
            this.rtxtListeleBK = new System.Windows.Forms.RichTextBox();
            this.btnSilOncelikBK = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblKazancKB = new System.Windows.Forms.Label();
            this.btnKazancKB = new System.Windows.Forms.Button();
            this.rtxtKarsilastirListeleKB = new System.Windows.Forms.RichTextBox();
            this.rtxtKarsilastirListeleBK = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblKazancBK = new System.Windows.Forms.Label();
            this.btnKazanBK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblOrtalamaIslem);
            this.panel1.Controls.Add(this.btnOrtalamaIslem);
            this.panel1.Controls.Add(this.rtxtListele);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(7, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 530);
            this.panel1.TabIndex = 0;
            // 
            // lblOrtalamaIslem
            // 
            this.lblOrtalamaIslem.AutoSize = true;
            this.lblOrtalamaIslem.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrtalamaIslem.Location = new System.Drawing.Point(246, 487);
            this.lblOrtalamaIslem.Name = "lblOrtalamaIslem";
            this.lblOrtalamaIslem.Size = new System.Drawing.Size(34, 39);
            this.lblOrtalamaIslem.TabIndex = 4;
            this.lblOrtalamaIslem.Text = "0";
            this.lblOrtalamaIslem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOrtalamaIslem
            // 
            this.btnOrtalamaIslem.BackColor = System.Drawing.SystemColors.Window;
            this.btnOrtalamaIslem.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrtalamaIslem.Location = new System.Drawing.Point(16, 444);
            this.btnOrtalamaIslem.Name = "btnOrtalamaIslem";
            this.btnOrtalamaIslem.Size = new System.Drawing.Size(595, 45);
            this.btnOrtalamaIslem.TabIndex = 3;
            this.btnOrtalamaIslem.Text = "ORTALAMA İŞLEM TAMAMLANMA SÜRESİ";
            this.btnOrtalamaIslem.UseVisualStyleBackColor = false;
            this.btnOrtalamaIslem.Click += new System.EventHandler(this.btnOrtalamaIslem_Click);
            // 
            // rtxtListele
            // 
            this.rtxtListele.Location = new System.Drawing.Point(16, 80);
            this.rtxtListele.Name = "rtxtListele";
            this.rtxtListele.Size = new System.Drawing.Size(595, 341);
            this.rtxtListele.TabIndex = 2;
            this.rtxtListele.Text = "";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.Window;
            this.btnSil.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(16, 29);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(595, 45);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "İŞİ BİTEN MÜŞTERİYİ ÇIKAR";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblDongusel
            // 
            this.lblDongusel.AutoSize = true;
            this.lblDongusel.BackColor = System.Drawing.Color.RosyBrown;
            this.lblDongusel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDongusel.Location = new System.Drawing.Point(7, 9);
            this.lblDongusel.Name = "lblDongusel";
            this.lblDongusel.Size = new System.Drawing.Size(211, 29);
            this.lblDongusel.TabIndex = 0;
            this.lblDongusel.Text = "DÖNGÜSEL KUYRUK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(704, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÖNCELİK KUYRUĞU K-->B";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblIslemTamamlanmaKB);
            this.panel2.Controls.Add(this.btnIslemTamamlanmaKB);
            this.panel2.Controls.Add(this.rtxtListeleKB);
            this.panel2.Controls.Add(this.btnSilOncelikKB);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(704, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(679, 530);
            this.panel2.TabIndex = 2;
            // 
            // lblIslemTamamlanmaKB
            // 
            this.lblIslemTamamlanmaKB.AutoSize = true;
            this.lblIslemTamamlanmaKB.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIslemTamamlanmaKB.Location = new System.Drawing.Point(271, 487);
            this.lblIslemTamamlanmaKB.Name = "lblIslemTamamlanmaKB";
            this.lblIslemTamamlanmaKB.Size = new System.Drawing.Size(34, 39);
            this.lblIslemTamamlanmaKB.TabIndex = 4;
            this.lblIslemTamamlanmaKB.Text = "0";
            this.lblIslemTamamlanmaKB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIslemTamamlanmaKB
            // 
            this.btnIslemTamamlanmaKB.BackColor = System.Drawing.SystemColors.Window;
            this.btnIslemTamamlanmaKB.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslemTamamlanmaKB.Location = new System.Drawing.Point(28, 439);
            this.btnIslemTamamlanmaKB.Name = "btnIslemTamamlanmaKB";
            this.btnIslemTamamlanmaKB.Size = new System.Drawing.Size(600, 45);
            this.btnIslemTamamlanmaKB.TabIndex = 3;
            this.btnIslemTamamlanmaKB.Text = "ORTALAMA İŞLEM TAMAMLANMA SÜRESİ";
            this.btnIslemTamamlanmaKB.UseVisualStyleBackColor = false;
            this.btnIslemTamamlanmaKB.Click += new System.EventHandler(this.btnIslemTamamlanmaKB_Click);
            // 
            // rtxtListeleKB
            // 
            this.rtxtListeleKB.Location = new System.Drawing.Point(28, 80);
            this.rtxtListeleKB.Name = "rtxtListeleKB";
            this.rtxtListeleKB.Size = new System.Drawing.Size(595, 341);
            this.rtxtListeleKB.TabIndex = 2;
            this.rtxtListeleKB.Text = "";
            // 
            // btnSilOncelikKB
            // 
            this.btnSilOncelikKB.BackColor = System.Drawing.SystemColors.Window;
            this.btnSilOncelikKB.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSilOncelikKB.Location = new System.Drawing.Point(28, 29);
            this.btnSilOncelikKB.Name = "btnSilOncelikKB";
            this.btnSilOncelikKB.Size = new System.Drawing.Size(595, 45);
            this.btnSilOncelikKB.TabIndex = 1;
            this.btnSilOncelikKB.Text = "İŞİ BİTEN MÜŞTERİYİ ÇIKAR";
            this.btnSilOncelikKB.UseVisualStyleBackColor = false;
            this.btnSilOncelikKB.Click += new System.EventHandler(this.btnSilOncelikKB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1406, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "ÖNCELİK KUYRUĞU B-->K";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RosyBrown;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblIslemTamamlanmaBK);
            this.panel3.Controls.Add(this.btnIslemTamamlanmaBK);
            this.panel3.Controls.Add(this.rtxtListeleBK);
            this.panel3.Controls.Add(this.btnSilOncelikBK);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(1406, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(679, 530);
            this.panel3.TabIndex = 4;
            // 
            // lblIslemTamamlanmaBK
            // 
            this.lblIslemTamamlanmaBK.AutoSize = true;
            this.lblIslemTamamlanmaBK.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIslemTamamlanmaBK.Location = new System.Drawing.Point(235, 487);
            this.lblIslemTamamlanmaBK.Name = "lblIslemTamamlanmaBK";
            this.lblIslemTamamlanmaBK.Size = new System.Drawing.Size(34, 39);
            this.lblIslemTamamlanmaBK.TabIndex = 4;
            this.lblIslemTamamlanmaBK.Text = "0";
            this.lblIslemTamamlanmaBK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIslemTamamlanmaBK
            // 
            this.btnIslemTamamlanmaBK.BackColor = System.Drawing.SystemColors.Window;
            this.btnIslemTamamlanmaBK.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslemTamamlanmaBK.Location = new System.Drawing.Point(21, 444);
            this.btnIslemTamamlanmaBK.Name = "btnIslemTamamlanmaBK";
            this.btnIslemTamamlanmaBK.Size = new System.Drawing.Size(600, 45);
            this.btnIslemTamamlanmaBK.TabIndex = 3;
            this.btnIslemTamamlanmaBK.Text = "ORTALAMA İŞLEM TAMAMLANMA SÜRESİ";
            this.btnIslemTamamlanmaBK.UseVisualStyleBackColor = false;
            this.btnIslemTamamlanmaBK.Click += new System.EventHandler(this.btnIslemTamamlanmaBK_Click);
            // 
            // rtxtListeleBK
            // 
            this.rtxtListeleBK.Location = new System.Drawing.Point(21, 80);
            this.rtxtListeleBK.Name = "rtxtListeleBK";
            this.rtxtListeleBK.Size = new System.Drawing.Size(595, 341);
            this.rtxtListeleBK.TabIndex = 2;
            this.rtxtListeleBK.Text = "";
            // 
            // btnSilOncelikBK
            // 
            this.btnSilOncelikBK.BackColor = System.Drawing.SystemColors.Window;
            this.btnSilOncelikBK.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSilOncelikBK.Location = new System.Drawing.Point(21, 29);
            this.btnSilOncelikBK.Name = "btnSilOncelikBK";
            this.btnSilOncelikBK.Size = new System.Drawing.Size(595, 45);
            this.btnSilOncelikBK.TabIndex = 1;
            this.btnSilOncelikBK.Text = "İŞİ BİTEN MÜŞTERİYİ ÇIKAR";
            this.btnSilOncelikBK.UseVisualStyleBackColor = false;
            this.btnSilOncelikBK.Click += new System.EventHandler(this.btnSilOncelikBK_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RosyBrown;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lblKazancKB);
            this.panel4.Controls.Add(this.btnKazancKB);
            this.panel4.Controls.Add(this.rtxtKarsilastirListeleKB);
            this.panel4.Location = new System.Drawing.Point(86, 597);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(849, 386);
            this.panel4.TabIndex = 5;
            // 
            // lblKazancKB
            // 
            this.lblKazancKB.AutoSize = true;
            this.lblKazancKB.BackColor = System.Drawing.Color.RosyBrown;
            this.lblKazancKB.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKazancKB.Location = new System.Drawing.Point(28, 326);
            this.lblKazancKB.Name = "lblKazancKB";
            this.lblKazancKB.Size = new System.Drawing.Size(20, 24);
            this.lblKazancKB.TabIndex = 5;
            this.lblKazancKB.Text = "0";
            this.lblKazancKB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKazancKB
            // 
            this.btnKazancKB.BackColor = System.Drawing.SystemColors.Window;
            this.btnKazancKB.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKazancKB.Location = new System.Drawing.Point(32, 267);
            this.btnKazancKB.Name = "btnKazancKB";
            this.btnKazancKB.Size = new System.Drawing.Size(781, 45);
            this.btnKazancKB.TabIndex = 5;
            this.btnKazancKB.Text = "ORTALAMA İŞLEM TAMAMLANMA SÜRESİNDEKİ KAZANÇ";
            this.btnKazancKB.UseVisualStyleBackColor = false;
            this.btnKazancKB.Click += new System.EventHandler(this.btnKazancKB_Click);
            // 
            // rtxtKarsilastirListeleKB
            // 
            this.rtxtKarsilastirListeleKB.BackColor = System.Drawing.SystemColors.Window;
            this.rtxtKarsilastirListeleKB.Location = new System.Drawing.Point(32, 13);
            this.rtxtKarsilastirListeleKB.Name = "rtxtKarsilastirListeleKB";
            this.rtxtKarsilastirListeleKB.Size = new System.Drawing.Size(781, 248);
            this.rtxtKarsilastirListeleKB.TabIndex = 0;
            this.rtxtKarsilastirListeleKB.Text = "";
            // 
            // rtxtKarsilastirListeleBK
            // 
            this.rtxtKarsilastirListeleBK.Location = new System.Drawing.Point(38, 13);
            this.rtxtKarsilastirListeleBK.Name = "rtxtKarsilastirListeleBK";
            this.rtxtKarsilastirListeleBK.Size = new System.Drawing.Size(781, 248);
            this.rtxtKarsilastirListeleBK.TabIndex = 8;
            this.rtxtKarsilastirListeleBK.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RosyBrown;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(181, 585);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(595, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "DÖNGÜSEL KUYRUK VE ÖNCELİK KUYRUĞU K-->B KARŞILAŞTIRMASI";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RosyBrown;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.lblKazancBK);
            this.panel6.Controls.Add(this.btnKazanBK);
            this.panel6.Controls.Add(this.rtxtKarsilastirListeleBK);
            this.panel6.Location = new System.Drawing.Point(1100, 597);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(849, 386);
            this.panel6.TabIndex = 1;
            // 
            // lblKazancBK
            // 
            this.lblKazancBK.AutoSize = true;
            this.lblKazancBK.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKazancBK.Location = new System.Drawing.Point(34, 326);
            this.lblKazancBK.Name = "lblKazancBK";
            this.lblKazancBK.Size = new System.Drawing.Size(20, 24);
            this.lblKazancBK.TabIndex = 6;
            this.lblKazancBK.Text = "0";
            this.lblKazancBK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKazanBK
            // 
            this.btnKazanBK.BackColor = System.Drawing.SystemColors.Window;
            this.btnKazanBK.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKazanBK.Location = new System.Drawing.Point(38, 267);
            this.btnKazanBK.Name = "btnKazanBK";
            this.btnKazanBK.Size = new System.Drawing.Size(781, 45);
            this.btnKazanBK.TabIndex = 6;
            this.btnKazanBK.Text = "ORTALAMA İŞLEM TAMAMLANMA SÜRESİNDEKİ KAZANÇ";
            this.btnKazanBK.UseVisualStyleBackColor = false;
            this.btnKazanBK.Click += new System.EventHandler(this.btnKazanBK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.RosyBrown;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1200, 585);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(595, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "DÖNGÜSEL KUYRUK VE ÖNCELİK KUYRUĞU B-->K KARŞILAŞTIRMASI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1914, 1045);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblDongusel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtxtListele;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblDongusel;
        private System.Windows.Forms.Label lblOrtalamaIslem;
        private System.Windows.Forms.Button btnOrtalamaIslem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblIslemTamamlanmaKB;
        private System.Windows.Forms.Button btnIslemTamamlanmaKB;
        private System.Windows.Forms.RichTextBox rtxtListeleKB;
        private System.Windows.Forms.Button btnSilOncelikKB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblIslemTamamlanmaBK;
        private System.Windows.Forms.Button btnIslemTamamlanmaBK;
        private System.Windows.Forms.RichTextBox rtxtListeleBK;
        private System.Windows.Forms.Button btnSilOncelikBK;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox rtxtKarsilastirListeleKB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxtKarsilastirListeleBK;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKazancKB;
        private System.Windows.Forms.Button btnKazancKB;
        private System.Windows.Forms.Label lblKazancBK;
        private System.Windows.Forms.Button btnKazanBK;

    }
}

