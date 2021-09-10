
namespace DSAML
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
            this.treinar = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.RichTextBox();
            this.lbl_sepala_largura = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_sepala_comprimento = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl_petala_largura = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbl_petala_comprimento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treinar
            // 
            this.treinar.Location = new System.Drawing.Point(391, 415);
            this.treinar.Name = "treinar";
            this.treinar.Size = new System.Drawing.Size(75, 23);
            this.treinar.TabIndex = 0;
            this.treinar.Text = "Treinar";
            this.treinar.UseVisualStyleBackColor = true;
            this.treinar.Click += new System.EventHandler(this.treinar_Click);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(12, 12);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(454, 397);
            this.log.TabIndex = 1;
            this.log.Text = "";
            // 
            // lbl_sepala_largura
            // 
            this.lbl_sepala_largura.AutoSize = true;
            this.lbl_sepala_largura.Location = new System.Drawing.Point(598, 15);
            this.lbl_sepala_largura.Name = "lbl_sepala_largura";
            this.lbl_sepala_largura.Size = new System.Drawing.Size(84, 15);
            this.lbl_sepala_largura.TabIndex = 2;
            this.lbl_sepala_largura.Text = "Lárgura Sépala";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(688, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(688, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 5;
            // 
            // lbl_sepala_comprimento
            // 
            this.lbl_sepala_comprimento.AutoSize = true;
            this.lbl_sepala_comprimento.Location = new System.Drawing.Point(598, 44);
            this.lbl_sepala_comprimento.Name = "lbl_sepala_comprimento";
            this.lbl_sepala_comprimento.Size = new System.Drawing.Size(84, 15);
            this.lbl_sepala_comprimento.TabIndex = 4;
            this.lbl_sepala_comprimento.Text = "Compr. Sépala";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(688, 70);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 7;
            // 
            // lbl_petala_largura
            // 
            this.lbl_petala_largura.AutoSize = true;
            this.lbl_petala_largura.Location = new System.Drawing.Point(598, 73);
            this.lbl_petala_largura.Name = "lbl_petala_largura";
            this.lbl_petala_largura.Size = new System.Drawing.Size(82, 15);
            this.lbl_petala_largura.TabIndex = 6;
            this.lbl_petala_largura.Text = "Lárgura Pétala";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(688, 99);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 9;
            // 
            // lbl_petala_comprimento
            // 
            this.lbl_petala_comprimento.AutoSize = true;
            this.lbl_petala_comprimento.Location = new System.Drawing.Point(598, 102);
            this.lbl_petala_comprimento.Name = "lbl_petala_comprimento";
            this.lbl_petala_comprimento.Size = new System.Drawing.Size(82, 15);
            this.lbl_petala_comprimento.TabIndex = 8;
            this.lbl_petala_comprimento.Text = "Compr. Pétala";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lbl_petala_comprimento);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lbl_petala_largura);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_sepala_comprimento);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_sepala_largura);
            this.Controls.Add(this.log);
            this.Controls.Add(this.treinar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button treinar;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.Label lbl_sepala_largura;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_sepala_comprimento;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbl_petala_largura;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbl_petala_comprimento;
    }
}

