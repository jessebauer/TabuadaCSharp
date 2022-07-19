namespace Tabuada
{
    partial class Form3
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
            this.lblPosOuNeg = new System.Windows.Forms.Label();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPosOuNeg
            // 
            this.lblPosOuNeg.AutoSize = true;
            this.lblPosOuNeg.Location = new System.Drawing.Point(170, 72);
            this.lblPosOuNeg.Name = "lblPosOuNeg";
            this.lblPosOuNeg.Size = new System.Drawing.Size(0, 15);
            this.lblPosOuNeg.TabIndex = 0;
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(70, 36);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(75, 23);
            this.btnCalcula.TabIndex = 1;
            this.btnCalcula.Text = "Executar";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // txtVisor
            // 
            this.txtVisor.Location = new System.Drawing.Point(160, 36);
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.Size = new System.Drawing.Size(100, 23);
            this.txtVisor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Positivo ou negativo?";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 489);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVisor);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.lblPosOuNeg);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPosOuNeg;
        private Button btnCalcula;
        private TextBox txtVisor;
        private Label label2;
    }
}