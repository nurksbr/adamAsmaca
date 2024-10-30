using System;

namespace WindowsFormsApp
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
            this.picAdamAsmaca = new System.Windows.Forms.PictureBox();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.lblKelime = new System.Windows.Forms.Label();
            this.lblHak = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAdamAsmaca)).BeginInit();
            this.SuspendLayout();
            // 
            // picAdamAsmaca
            // 
            this.picAdamAsmaca.BackColor = System.Drawing.Color.Green;
            this.picAdamAsmaca.Location = new System.Drawing.Point(12, 39);
            this.picAdamAsmaca.Name = "picAdamAsmaca";
            this.picAdamAsmaca.Size = new System.Drawing.Size(256, 332);
            this.picAdamAsmaca.TabIndex = 0;
            this.picAdamAsmaca.TabStop = false;
            // 
            // txtTahmin
            // 
            this.txtTahmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTahmin.Location = new System.Drawing.Point(298, 264);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(177, 20);
            this.txtTahmin.TabIndex = 1;
            // 
            // btnTahmin
            // 
            this.btnTahmin.BackColor = System.Drawing.Color.Lime;
            this.btnTahmin.Location = new System.Drawing.Point(453, 306);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(75, 23);
            this.btnTahmin.TabIndex = 2;
            this.btnTahmin.Text = "Check";
            this.btnTahmin.UseVisualStyleBackColor = false;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.77358F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelime.Location = new System.Drawing.Point(350, 168);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(125, 39);
            this.lblKelime.TabIndex = 3;
            this.lblKelime.Text = "kelime";
            // 
            // lblHak
            // 
            this.lblHak.AutoSize = true;
            this.lblHak.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.69811F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHak.Location = new System.Drawing.Point(310, 82);
            this.lblHak.Name = "lblHak";
            this.lblHak.Size = new System.Drawing.Size(65, 33);
            this.lblHak.TabIndex = 4;
            this.lblHak.Text = "hak";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.lblHak);
            this.Controls.Add(this.lblKelime);
            this.Controls.Add(this.btnTahmin);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.picAdamAsmaca);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picAdamAsmaca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAdamAsmaca;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.Label lblHak;
    }
}

