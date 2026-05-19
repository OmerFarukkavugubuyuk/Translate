namespace CeviriUygulamasi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cmbKaynakDil = new System.Windows.Forms.ComboBox();
            this.cmbHedefDil = new System.Windows.Forms.ComboBox();
            this.txtKaynak = new System.Windows.Forms.RichTextBox();
            this.txtHedef = new System.Windows.Forms.RichTextBox();
            this.btnCevir = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblOk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbKaynakDil
            // 
            this.cmbKaynakDil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKaynakDil.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKaynakDil.FormattingEnabled = true;
            this.cmbKaynakDil.Location = new System.Drawing.Point(30, 80);
            this.cmbKaynakDil.Name = "cmbKaynakDil";
            this.cmbKaynakDil.Size = new System.Drawing.Size(200, 28);
            this.cmbKaynakDil.TabIndex = 0;
            // 
            // cmbHedefDil
            // 
            this.cmbHedefDil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbHedefDil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHedefDil.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbHedefDil.FormattingEnabled = true;
            this.cmbHedefDil.Location = new System.Drawing.Point(470, 80);
            this.cmbHedefDil.Name = "cmbHedefDil";
            this.cmbHedefDil.Size = new System.Drawing.Size(200, 28);
            this.cmbHedefDil.TabIndex = 1;
            // 
            // txtKaynak
            // 
            this.txtKaynak.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtKaynak.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKaynak.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKaynak.Location = new System.Drawing.Point(30, 120);
            this.txtKaynak.Name = "txtKaynak";
            this.txtKaynak.Size = new System.Drawing.Size(400, 260);
            this.txtKaynak.TabIndex = 2;
            this.txtKaynak.Text = "";
            // 
            // txtHedef
            // 
            this.txtHedef.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHedef.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtHedef.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHedef.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHedef.Location = new System.Drawing.Point(470, 120);
            this.txtHedef.Name = "txtHedef";
            this.txtHedef.ReadOnly = true;
            this.txtHedef.Size = new System.Drawing.Size(400, 260);
            this.txtHedef.TabIndex = 3;
            this.txtHedef.Text = "";
            // 
            // btnCevir
            // 
            this.btnCevir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCevir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnCevir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCevir.FlatAppearance.BorderSize = 0;
            this.btnCevir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCevir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCevir.ForeColor = System.Drawing.Color.White;
            this.btnCevir.Location = new System.Drawing.Point(720, 400);
            this.btnCevir.Name = "btnCevir";
            this.btnCevir.Size = new System.Drawing.Size(150, 45);
            this.btnCevir.TabIndex = 4;
            this.btnCevir.Text = "Çevir";
            this.btnCevir.UseVisualStyleBackColor = false;
            this.btnCevir.Click += new System.EventHandler(this.btnCevir_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.ForeColor = System.Drawing.Color.Gray;
            this.lblDurum.Location = new System.Drawing.Point(30, 415);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(127, 17);
            this.lblDurum.TabIndex = 5;
            this.lblDurum.Text = "Çeviri bekleniyor...";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBaslik.Location = new System.Drawing.Point(23, 20);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(262, 37);
            this.lblBaslik.TabIndex = 6;
            this.lblBaslik.Text = "NMT Çeviri Motoru";
            // 
            // lblOk
            // 
            this.lblOk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblOk.AutoSize = true;
            this.lblOk.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOk.ForeColor = System.Drawing.Color.Silver;
            this.lblOk.Location = new System.Drawing.Point(436, 120);
            this.lblOk.Name = "lblOk";
            this.lblOk.Size = new System.Drawing.Size(28, 30);
            this.lblOk.TabIndex = 7;
            this.lblOk.Text = "➔";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(900, 470);
            this.Controls.Add(this.lblOk);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.btnCevir);
            this.Controls.Add(this.txtHedef);
            this.Controls.Add(this.txtKaynak);
            this.Controls.Add(this.cmbHedefDil);
            this.Controls.Add(this.cmbKaynakDil);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çeviri Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKaynakDil;
        private System.Windows.Forms.ComboBox cmbHedefDil;
        private System.Windows.Forms.RichTextBox txtKaynak;
        private System.Windows.Forms.RichTextBox txtHedef;
        private System.Windows.Forms.Button btnCevir;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblOk;
    }
}