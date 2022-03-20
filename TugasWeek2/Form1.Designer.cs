
namespace TugasWeek2
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
            this.labelInput = new System.Windows.Forms.Label();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(12, 13);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(68, 15);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Input Data :";
            this.labelInput.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Location = new System.Drawing.Point(12, 31);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxInput.Size = new System.Drawing.Size(335, 23);
            this.txtBoxInput.TabIndex = 1;
            this.txtBoxInput.TextChanged += new System.EventHandler(this.txtBoxInput_TextChanged);
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(13, 89);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(75, 23);
            this.btnProses.TabIndex = 2;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOutput.Location = new System.Drawing.Point(20, 137);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(84, 28);
            this.labelOutput.TabIndex = 3;
            this.labelOutput.Text = "[EMPTY]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 289);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.txtBoxInput);
            this.Controls.Add(this.labelInput);
            this.Name = "Form1";
            this.Text = "Form Pengaturan Warna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox txtBoxInput;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Label labelOutput;
    }
}

