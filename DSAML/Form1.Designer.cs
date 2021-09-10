
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.log);
            this.Controls.Add(this.treinar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button treinar;
        private System.Windows.Forms.RichTextBox log;
    }
}

