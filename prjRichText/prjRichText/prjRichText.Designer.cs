namespace prjRichText
{
    partial class prjRichText
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
            this.btnCor = new System.Windows.Forms.Button();
            this.btnFonte = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnAumentarFonte = new System.Windows.Forms.Button();
            this.btnDiminuirFonte = new System.Windows.Forms.Button();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnCor
            // 
            this.btnCor.Location = new System.Drawing.Point(105, 212);
            this.btnCor.Name = "btnCor";
            this.btnCor.Size = new System.Drawing.Size(75, 33);
            this.btnCor.TabIndex = 0;
            this.btnCor.Text = "Cor";
            this.btnCor.UseVisualStyleBackColor = true;
            this.btnCor.Click += new System.EventHandler(this.btnCor_Click);
            // 
            // btnFonte
            // 
            this.btnFonte.Location = new System.Drawing.Point(195, 212);
            this.btnFonte.Name = "btnFonte";
            this.btnFonte.Size = new System.Drawing.Size(75, 33);
            this.btnFonte.TabIndex = 1;
            this.btnFonte.Text = "Fonte";
            this.btnFonte.UseVisualStyleBackColor = true;
            this.btnFonte.Click += new System.EventHandler(this.btnFonte_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(105, 76);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(165, 96);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // btnAumentarFonte
            // 
            this.btnAumentarFonte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAumentarFonte.Location = new System.Drawing.Point(291, 135);
            this.btnAumentarFonte.Name = "btnAumentarFonte";
            this.btnAumentarFonte.Size = new System.Drawing.Size(41, 37);
            this.btnAumentarFonte.TabIndex = 3;
            this.btnAumentarFonte.Text = "+";
            this.btnAumentarFonte.UseVisualStyleBackColor = true;
            this.btnAumentarFonte.Click += new System.EventHandler(this.btnAumentarFonte_Click);
            // 
            // btnDiminuirFonte
            // 
            this.btnDiminuirFonte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiminuirFonte.Location = new System.Drawing.Point(42, 135);
            this.btnDiminuirFonte.Name = "btnDiminuirFonte";
            this.btnDiminuirFonte.Size = new System.Drawing.Size(41, 37);
            this.btnDiminuirFonte.TabIndex = 4;
            this.btnDiminuirFonte.Text = "-";
            this.btnDiminuirFonte.UseVisualStyleBackColor = true;
            this.btnDiminuirFonte.Click += new System.EventHandler(this.btnDiminuirFonte_Click);
            // 
            // prjRichText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 327);
            this.Controls.Add(this.btnDiminuirFonte);
            this.Controls.Add(this.btnAumentarFonte);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.btnFonte);
            this.Controls.Add(this.btnCor);
            this.Name = "prjRichText";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.prjRichText_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCor;
        private System.Windows.Forms.Button btnFonte;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnAumentarFonte;
        private System.Windows.Forms.Button btnDiminuirFonte;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

