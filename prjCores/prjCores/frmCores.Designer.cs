namespace prjCores
{
    partial class frmCores
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
            this.components = new System.ComponentModel.Container();
            this.lbl_meu_texto = new System.Windows.Forms.Label();
            this.btn_cor_texto = new System.Windows.Forms.Button();
            this.btn_cor_fundo = new System.Windows.Forms.Button();
            this.color_dialog = new System.Windows.Forms.ColorDialog();
            this.context_menu_strip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.corDoTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.corDoFuntoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.context_menu_strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_meu_texto
            // 
            this.lbl_meu_texto.AutoSize = true;
            this.lbl_meu_texto.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_meu_texto.Location = new System.Drawing.Point(218, 201);
            this.lbl_meu_texto.Name = "lbl_meu_texto";
            this.lbl_meu_texto.Size = new System.Drawing.Size(92, 33);
            this.lbl_meu_texto.TabIndex = 0;
            this.lbl_meu_texto.Text = "Texto";
            // 
            // btn_cor_texto
            // 
            this.btn_cor_texto.Font = new System.Drawing.Font("Perpetua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cor_texto.Location = new System.Drawing.Point(102, 71);
            this.btn_cor_texto.Name = "btn_cor_texto";
            this.btn_cor_texto.Size = new System.Drawing.Size(149, 79);
            this.btn_cor_texto.TabIndex = 1;
            this.btn_cor_texto.Text = "Cor do texto";
            this.btn_cor_texto.UseVisualStyleBackColor = true;
            this.btn_cor_texto.Click += new System.EventHandler(this.btn_cor_texto_Click);
            // 
            // btn_cor_fundo
            // 
            this.btn_cor_fundo.Font = new System.Drawing.Font("Perpetua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cor_fundo.Location = new System.Drawing.Point(274, 71);
            this.btn_cor_fundo.Name = "btn_cor_fundo";
            this.btn_cor_fundo.Size = new System.Drawing.Size(149, 79);
            this.btn_cor_fundo.TabIndex = 2;
            this.btn_cor_fundo.Text = "Cor do fundo";
            this.btn_cor_fundo.UseVisualStyleBackColor = true;
            this.btn_cor_fundo.Click += new System.EventHandler(this.btn_cor_fundo_Click);
            // 
            // context_menu_strip
            // 
            this.context_menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.corDoTextoToolStripMenuItem,
            this.corDoFuntoToolStripMenuItem});
            this.context_menu_strip.Name = "context_menu_strip";
            this.context_menu_strip.Size = new System.Drawing.Size(190, 86);
            // 
            // corDoTextoToolStripMenuItem
            // 
            this.corDoTextoToolStripMenuItem.Name = "corDoTextoToolStripMenuItem";
            this.corDoTextoToolStripMenuItem.Size = new System.Drawing.Size(189, 30);
            this.corDoTextoToolStripMenuItem.Text = "cor do texto";
            this.corDoTextoToolStripMenuItem.Click += new System.EventHandler(this.corDoTextoToolStripMenuItem_Click);
            // 
            // corDoFuntoToolStripMenuItem
            // 
            this.corDoFuntoToolStripMenuItem.Name = "corDoFuntoToolStripMenuItem";
            this.corDoFuntoToolStripMenuItem.Size = new System.Drawing.Size(189, 30);
            this.corDoFuntoToolStripMenuItem.Text = "cor do fundo";
            this.corDoFuntoToolStripMenuItem.Click += new System.EventHandler(this.corDoFuntoToolStripMenuItem_Click);
            // 
            // frmCores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 439);
            this.ContextMenuStrip = this.context_menu_strip;
            this.Controls.Add(this.btn_cor_fundo);
            this.Controls.Add(this.btn_cor_texto);
            this.Controls.Add(this.lbl_meu_texto);
            this.Name = "frmCores";
            this.Text = "Form1";
            this.context_menu_strip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_meu_texto;
        private System.Windows.Forms.Button btn_cor_texto;
        private System.Windows.Forms.Button btn_cor_fundo;
        private System.Windows.Forms.ColorDialog color_dialog;
        private System.Windows.Forms.ContextMenuStrip context_menu_strip;
        private System.Windows.Forms.ToolStripMenuItem corDoTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem corDoFuntoToolStripMenuItem;
    }
}

