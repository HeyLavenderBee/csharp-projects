namespace prjListBox
{
    partial class ListBox
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
            this.lst_relacao_cidades = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.txt_qtd_cidades = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lst_selecionado = new System.Windows.Forms.ListBox();
            this.btn_selecionar = new System.Windows.Forms.Button();
            this.btn_devolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_relacao_cidades
            // 
            this.lst_relacao_cidades.FormattingEnabled = true;
            this.lst_relacao_cidades.Items.AddRange(new object[] {
            "S. André",
            "S. Bernardo"});
            this.lst_relacao_cidades.Location = new System.Drawing.Point(26, 113);
            this.lst_relacao_cidades.Name = "lst_relacao_cidades";
            this.lst_relacao_cidades.Size = new System.Drawing.Size(199, 95);
            this.lst_relacao_cidades.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Relação de Cidades";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(26, 50);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(199, 20);
            this.txt_cidade.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cidade";
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(240, 46);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(66, 27);
            this.btn_adicionar.TabIndex = 4;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // txt_qtd_cidades
            // 
            this.txt_qtd_cidades.Location = new System.Drawing.Point(26, 245);
            this.txt_qtd_cidades.Name = "txt_qtd_cidades";
            this.txt_qtd_cidades.Size = new System.Drawing.Size(199, 20);
            this.txt_qtd_cidades.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total de cidades";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(254, 185);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(66, 23);
            this.btnRemover.TabIndex = 8;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lst_selecionado
            // 
            this.lst_selecionado.FormattingEnabled = true;
            this.lst_selecionado.Location = new System.Drawing.Point(345, 113);
            this.lst_selecionado.Name = "lst_selecionado";
            this.lst_selecionado.Size = new System.Drawing.Size(199, 95);
            this.lst_selecionado.TabIndex = 9;
            // 
            // btn_selecionar
            // 
            this.btn_selecionar.Location = new System.Drawing.Point(254, 113);
            this.btn_selecionar.Name = "btn_selecionar";
            this.btn_selecionar.Size = new System.Drawing.Size(66, 23);
            this.btn_selecionar.TabIndex = 10;
            this.btn_selecionar.Text = "Selecionar";
            this.btn_selecionar.UseVisualStyleBackColor = true;
            this.btn_selecionar.Click += new System.EventHandler(this.btn_selecionar_Click);
            // 
            // btn_devolver
            // 
            this.btn_devolver.Location = new System.Drawing.Point(254, 149);
            this.btn_devolver.Name = "btn_devolver";
            this.btn_devolver.Size = new System.Drawing.Size(66, 23);
            this.btn_devolver.TabIndex = 11;
            this.btn_devolver.Text = "Devolver";
            this.btn_devolver.UseVisualStyleBackColor = true;
            this.btn_devolver.Click += new System.EventHandler(this.btn_devolver_Click);
            // 
            // ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 356);
            this.Controls.Add(this.btn_selecionar);
            this.Controls.Add(this.lst_selecionado);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_qtd_cidades);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_relacao_cidades);
            this.Controls.Add(this.btn_devolver);
            this.Name = "ListBox";
            this.Text = "List Box";
            this.Activated += new System.EventHandler(this.ListBox_Activated);
            this.Load += new System.EventHandler(this.ListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_relacao_cidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.TextBox txt_qtd_cidades;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ListBox lst_selecionado;
        private System.Windows.Forms.Button btn_selecionar;
        private System.Windows.Forms.Button btn_devolver;
    }
}

