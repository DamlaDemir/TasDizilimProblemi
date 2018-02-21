namespace YazılımSınamaÖdev1
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
            this.btnGoster = new System.Windows.Forms.Button();
            this.txtBasamakSayisi = new System.Windows.Forms.TextBox();
            this.lblBasamakSayisi = new System.Windows.Forms.Label();
            this.lblElemanSayisi = new System.Windows.Forms.Label();
            this.rtxtElemanlar = new System.Windows.Forms.RichTextBox();
            this.lblBeyaz = new System.Windows.Forms.Label();
            this.lblSiyah = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGoster
            // 
            this.btnGoster.BackColor = System.Drawing.Color.SeaShell;
            this.btnGoster.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoster.ForeColor = System.Drawing.Color.Maroon;
            this.btnGoster.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGoster.Location = new System.Drawing.Point(12, 97);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(695, 55);
            this.btnGoster.TabIndex = 1;
            this.btnGoster.Text = "TAŞ DİZİLİMİNİ GÖSTER";
            this.btnGoster.UseVisualStyleBackColor = false;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // txtBasamakSayisi
            // 
            this.txtBasamakSayisi.BackColor = System.Drawing.Color.SeaShell;
            this.txtBasamakSayisi.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBasamakSayisi.ForeColor = System.Drawing.Color.Maroon;
            this.txtBasamakSayisi.Location = new System.Drawing.Point(12, 57);
            this.txtBasamakSayisi.Multiline = true;
            this.txtBasamakSayisi.Name = "txtBasamakSayisi";
            this.txtBasamakSayisi.Size = new System.Drawing.Size(695, 34);
            this.txtBasamakSayisi.TabIndex = 2;
            // 
            // lblBasamakSayisi
            // 
            this.lblBasamakSayisi.AutoSize = true;
            this.lblBasamakSayisi.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBasamakSayisi.ForeColor = System.Drawing.Color.Maroon;
            this.lblBasamakSayisi.Location = new System.Drawing.Point(10, 28);
            this.lblBasamakSayisi.Name = "lblBasamakSayisi";
            this.lblBasamakSayisi.Size = new System.Drawing.Size(150, 26);
            this.lblBasamakSayisi.TabIndex = 3;
            this.lblBasamakSayisi.Text = "Basamak Sayısı:";
            // 
            // lblElemanSayisi
            // 
            this.lblElemanSayisi.AutoSize = true;
            this.lblElemanSayisi.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblElemanSayisi.ForeColor = System.Drawing.Color.Maroon;
            this.lblElemanSayisi.Location = new System.Drawing.Point(185, 524);
            this.lblElemanSayisi.Name = "lblElemanSayisi";
            this.lblElemanSayisi.Size = new System.Drawing.Size(67, 27);
            this.lblElemanSayisi.TabIndex = 5;
            this.lblElemanSayisi.Text = "label1";
            this.lblElemanSayisi.Visible = false;
            // 
            // rtxtElemanlar
            // 
            this.rtxtElemanlar.BackColor = System.Drawing.Color.SeaShell;
            this.rtxtElemanlar.Location = new System.Drawing.Point(12, 210);
            this.rtxtElemanlar.Name = "rtxtElemanlar";
            this.rtxtElemanlar.Size = new System.Drawing.Size(695, 288);
            this.rtxtElemanlar.TabIndex = 6;
            this.rtxtElemanlar.Text = "";
            // 
            // lblBeyaz
            // 
            this.lblBeyaz.AutoSize = true;
            this.lblBeyaz.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBeyaz.ForeColor = System.Drawing.Color.Maroon;
            this.lblBeyaz.Location = new System.Drawing.Point(12, 171);
            this.lblBeyaz.Name = "lblBeyaz";
            this.lblBeyaz.Size = new System.Drawing.Size(103, 27);
            this.lblBeyaz.TabIndex = 7;
            this.lblBeyaz.Text = "Beyaz->1";
            // 
            // lblSiyah
            // 
            this.lblSiyah.AutoSize = true;
            this.lblSiyah.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSiyah.ForeColor = System.Drawing.Color.Maroon;
            this.lblSiyah.Location = new System.Drawing.Point(130, 171);
            this.lblSiyah.Name = "lblSiyah";
            this.lblSiyah.Size = new System.Drawing.Size(99, 27);
            this.lblSiyah.TabIndex = 8;
            this.lblSiyah.Text = "Siyah->0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 569);
            this.Controls.Add(this.lblSiyah);
            this.Controls.Add(this.lblBeyaz);
            this.Controls.Add(this.rtxtElemanlar);
            this.Controls.Add(this.lblElemanSayisi);
            this.Controls.Add(this.lblBasamakSayisi);
            this.Controls.Add(this.txtBasamakSayisi);
            this.Controls.Add(this.btnGoster);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.TextBox txtBasamakSayisi;
        private System.Windows.Forms.Label lblBasamakSayisi;
        private System.Windows.Forms.Label lblElemanSayisi;
        private System.Windows.Forms.RichTextBox rtxtElemanlar;
        private System.Windows.Forms.Label lblBeyaz;
        private System.Windows.Forms.Label lblSiyah;
    }
}

