
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
            this.txt_sepala_largura = new System.Windows.Forms.TextBox();
            this.txt_sepala_comprimento = new System.Windows.Forms.TextBox();
            this.lbl_sepala_comprimento = new System.Windows.Forms.Label();
            this.txt_petala_largura = new System.Windows.Forms.TextBox();
            this.lbl_petala_largura = new System.Windows.Forms.Label();
            this.txt_petala_comprimento = new System.Windows.Forms.TextBox();
            this.lbl_petala_comprimento = new System.Windows.Forms.Label();
            this.btn_prever = new System.Windows.Forms.Button();
            this.btn_amostra_setosa = new System.Windows.Forms.Button();
            this.btn_amostra_versicolor = new System.Windows.Forms.Button();
            this.btn_amostra_virginica = new System.Windows.Forms.Button();
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
            // txt_sepala_largura
            // 
            this.txt_sepala_largura.Location = new System.Drawing.Point(688, 12);
            this.txt_sepala_largura.Name = "txt_sepala_largura";
            this.txt_sepala_largura.Size = new System.Drawing.Size(100, 23);
            this.txt_sepala_largura.TabIndex = 3;
            // 
            // txt_sepala_comprimento
            // 
            this.txt_sepala_comprimento.Location = new System.Drawing.Point(688, 41);
            this.txt_sepala_comprimento.Name = "txt_sepala_comprimento";
            this.txt_sepala_comprimento.Size = new System.Drawing.Size(100, 23);
            this.txt_sepala_comprimento.TabIndex = 5;
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
            // txt_petala_largura
            // 
            this.txt_petala_largura.Location = new System.Drawing.Point(688, 70);
            this.txt_petala_largura.Name = "txt_petala_largura";
            this.txt_petala_largura.Size = new System.Drawing.Size(100, 23);
            this.txt_petala_largura.TabIndex = 7;
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
            // txt_petala_comprimento
            // 
            this.txt_petala_comprimento.Location = new System.Drawing.Point(688, 99);
            this.txt_petala_comprimento.Name = "txt_petala_comprimento";
            this.txt_petala_comprimento.Size = new System.Drawing.Size(100, 23);
            this.txt_petala_comprimento.TabIndex = 9;
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
            // btn_prever
            // 
            this.btn_prever.Enabled = false;
            this.btn_prever.Location = new System.Drawing.Point(598, 247);
            this.btn_prever.Name = "btn_prever";
            this.btn_prever.Size = new System.Drawing.Size(190, 25);
            this.btn_prever.TabIndex = 10;
            this.btn_prever.Text = "Prever";
            this.btn_prever.UseVisualStyleBackColor = true;
            this.btn_prever.Click += new System.EventHandler(this.btn_prever_Click);
            // 
            // btn_amostra_setosa
            // 
            this.btn_amostra_setosa.Location = new System.Drawing.Point(598, 128);
            this.btn_amostra_setosa.Name = "btn_amostra_setosa";
            this.btn_amostra_setosa.Size = new System.Drawing.Size(190, 23);
            this.btn_amostra_setosa.TabIndex = 11;
            this.btn_amostra_setosa.Text = "Amostra Setosa (Classe 1)";
            this.btn_amostra_setosa.UseVisualStyleBackColor = true;
            this.btn_amostra_setosa.Click += new System.EventHandler(this.btn_amostra_setosa_Click);
            // 
            // btn_amostra_versicolor
            // 
            this.btn_amostra_versicolor.Location = new System.Drawing.Point(598, 158);
            this.btn_amostra_versicolor.Name = "btn_amostra_versicolor";
            this.btn_amostra_versicolor.Size = new System.Drawing.Size(190, 23);
            this.btn_amostra_versicolor.TabIndex = 12;
            this.btn_amostra_versicolor.Text = "Amostra Versicolor (Classe 2)";
            this.btn_amostra_versicolor.UseVisualStyleBackColor = true;
            this.btn_amostra_versicolor.Click += new System.EventHandler(this.btn_amostra_versicolor_Click);
            // 
            // btn_amostra_virginica
            // 
            this.btn_amostra_virginica.Location = new System.Drawing.Point(598, 188);
            this.btn_amostra_virginica.Name = "btn_amostra_virginica";
            this.btn_amostra_virginica.Size = new System.Drawing.Size(190, 23);
            this.btn_amostra_virginica.TabIndex = 13;
            this.btn_amostra_virginica.Text = "Amostra Virginica (Classe 3)";
            this.btn_amostra_virginica.UseVisualStyleBackColor = true;
            this.btn_amostra_virginica.Click += new System.EventHandler(this.btn_amostra_virginica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_amostra_virginica);
            this.Controls.Add(this.btn_amostra_versicolor);
            this.Controls.Add(this.btn_amostra_setosa);
            this.Controls.Add(this.btn_prever);
            this.Controls.Add(this.txt_petala_comprimento);
            this.Controls.Add(this.lbl_petala_comprimento);
            this.Controls.Add(this.txt_petala_largura);
            this.Controls.Add(this.lbl_petala_largura);
            this.Controls.Add(this.txt_sepala_comprimento);
            this.Controls.Add(this.lbl_sepala_comprimento);
            this.Controls.Add(this.txt_sepala_largura);
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
        private System.Windows.Forms.TextBox txt_sepala_largura;
        private System.Windows.Forms.TextBox txt_sepala_comprimento;
        private System.Windows.Forms.Label lbl_sepala_comprimento;
        private System.Windows.Forms.TextBox txt_petala_largura;
        private System.Windows.Forms.Label lbl_petala_largura;
        private System.Windows.Forms.TextBox txt_petala_comprimento;
        private System.Windows.Forms.Label lbl_petala_comprimento;
        private System.Windows.Forms.Button btn_prever;
        private System.Windows.Forms.Button btn_amostra_setosa;
        private System.Windows.Forms.Button btn_amostra_versicolor;
        private System.Windows.Forms.Button btn_amostra_virginica;
    }
}

