namespace Tabuada
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtNumTres = new System.Windows.Forms.TextBox();
            this.txtNumDois = new System.Windows.Forms.TextBox();
            this.txtNumUm = new System.Windows.Forms.TextBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maior e menor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero três";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero dois";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero Um";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(138, 106);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 54);
            this.txtResultado.TabIndex = 4;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // txtNumTres
            // 
            this.txtNumTres.Location = new System.Drawing.Point(138, 77);
            this.txtNumTres.Name = "txtNumTres";
            this.txtNumTres.Size = new System.Drawing.Size(100, 23);
            this.txtNumTres.TabIndex = 5;
            this.txtNumTres.TextChanged += new System.EventHandler(this.txtNumTres_TextChanged);
            // 
            // txtNumDois
            // 
            this.txtNumDois.Location = new System.Drawing.Point(138, 48);
            this.txtNumDois.Name = "txtNumDois";
            this.txtNumDois.Size = new System.Drawing.Size(100, 23);
            this.txtNumDois.TabIndex = 6;
            this.txtNumDois.TextChanged += new System.EventHandler(this.txtNumDois_TextChanged);
            // 
            // txtNumUm
            // 
            this.txtNumUm.Location = new System.Drawing.Point(138, 19);
            this.txtNumUm.Name = "txtNumUm";
            this.txtNumUm.Size = new System.Drawing.Size(100, 23);
            this.txtNumUm.TabIndex = 7;
            this.txtNumUm.TextChanged += new System.EventHandler(this.txtNumUm_TextChanged);
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(244, 109);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(75, 23);
            this.btnCalcula.TabIndex = 8;
            this.btnCalcula.Text = "Executar";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 383);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.txtNumUm);
            this.Controls.Add(this.txtNumDois);
            this.Controls.Add(this.txtNumTres);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtResultado;
        private TextBox txtNumTres;
        private TextBox txtNumDois;
        private TextBox txtNumUm;
        private Button btnCalcula;
    }
}