namespace prjFormatacaoDeCampos
{
    partial class frmFormatacaoDeCampos
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
            this.txtCEP_E = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCEP_S = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCEP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCEP_E
            // 
            this.txtCEP_E.Location = new System.Drawing.Point(37, 66);
            this.txtCEP_E.Name = "txtCEP_E";
            this.txtCEP_E.Size = new System.Drawing.Size(132, 20);
            this.txtCEP_E.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CEP";
            // 
            // txtCEP_S
            // 
            this.txtCEP_S.Location = new System.Drawing.Point(331, 66);
            this.txtCEP_S.Name = "txtCEP_S";
            this.txtCEP_S.Size = new System.Drawing.Size(132, 20);
            this.txtCEP_S.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CEP";
            // 
            // btnCEP
            // 
            this.btnCEP.Location = new System.Drawing.Point(194, 64);
            this.btnCEP.Name = "btnCEP";
            this.btnCEP.Size = new System.Drawing.Size(115, 23);
            this.btnCEP.TabIndex = 4;
            this.btnCEP.Text = "Formatar CEP";
            this.btnCEP.UseVisualStyleBackColor = true;
            this.btnCEP.Click += new System.EventHandler(this.btnCEP_Click);
            // 
            // frmFormatacaoDeCampos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 335);
            this.Controls.Add(this.btnCEP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCEP_S);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCEP_E);
            this.Name = "frmFormatacaoDeCampos";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCEP_E;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCEP_S;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCEP;
    }
}

