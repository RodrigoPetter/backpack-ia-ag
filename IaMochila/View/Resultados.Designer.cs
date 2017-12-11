namespace IaMochila.View
{
    partial class Resultados
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
            this.listBox_Itens = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_Mochilas = new System.Windows.Forms.ListBox();
            this.button_GerarItens = new System.Windows.Forms.Button();
            this.button_AprimorarPopulacao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox_Itens_Mochila = new System.Windows.Forms.ListBox();
            this.button1_config = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox_bestItens = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox_Mochilas_best = new System.Windows.Forms.ListBox();
            this.button_Processar = new System.Windows.Forms.Button();
            this.ValorCol1 = new System.Windows.Forms.Label();
            this.PesoCol1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_Itens
            // 
            this.listBox_Itens.FormattingEnabled = true;
            this.listBox_Itens.Location = new System.Drawing.Point(29, 48);
            this.listBox_Itens.Name = "listBox_Itens";
            this.listBox_Itens.Size = new System.Drawing.Size(189, 381);
            this.listBox_Itens.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Itens";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Primeira Lista de Mochilas";
            // 
            // listBox_Mochilas
            // 
            this.listBox_Mochilas.FormattingEnabled = true;
            this.listBox_Mochilas.Location = new System.Drawing.Point(224, 48);
            this.listBox_Mochilas.Name = "listBox_Mochilas";
            this.listBox_Mochilas.Size = new System.Drawing.Size(266, 212);
            this.listBox_Mochilas.TabIndex = 2;
            this.listBox_Mochilas.SelectedIndexChanged += new System.EventHandler(this.listBox_Mochilas_SelectedIndexChanged);
            // 
            // button_GerarItens
            // 
            this.button_GerarItens.Location = new System.Drawing.Point(29, 482);
            this.button_GerarItens.Name = "button_GerarItens";
            this.button_GerarItens.Size = new System.Drawing.Size(189, 23);
            this.button_GerarItens.TabIndex = 6;
            this.button_GerarItens.Text = "Gerar Itens";
            this.button_GerarItens.UseVisualStyleBackColor = true;
            this.button_GerarItens.Click += new System.EventHandler(this.button_GerarItens_Click);
            // 
            // button_AprimorarPopulacao
            // 
            this.button_AprimorarPopulacao.Location = new System.Drawing.Point(224, 482);
            this.button_AprimorarPopulacao.Name = "button_AprimorarPopulacao";
            this.button_AprimorarPopulacao.Size = new System.Drawing.Size(266, 23);
            this.button_AprimorarPopulacao.TabIndex = 7;
            this.button_AprimorarPopulacao.Text = "Gerar População";
            this.button_AprimorarPopulacao.UseVisualStyleBackColor = true;
            this.button_AprimorarPopulacao.Click += new System.EventHandler(this.button_AprimorarPopulacao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lista de Itens";
            // 
            // listBox_Itens_Mochila
            // 
            this.listBox_Itens_Mochila.FormattingEnabled = true;
            this.listBox_Itens_Mochila.Location = new System.Drawing.Point(225, 280);
            this.listBox_Itens_Mochila.Name = "listBox_Itens_Mochila";
            this.listBox_Itens_Mochila.Size = new System.Drawing.Size(266, 147);
            this.listBox_Itens_Mochila.TabIndex = 8;
            // 
            // button1_config
            // 
            this.button1_config.Location = new System.Drawing.Point(30, 6);
            this.button1_config.Name = "button1_config";
            this.button1_config.Size = new System.Drawing.Size(99, 23);
            this.button1_config.TabIndex = 10;
            this.button1_config.Text = "Configurações";
            this.button1_config.UseVisualStyleBackColor = true;
            this.button1_config.Click += new System.EventHandler(this.button1_config_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Lista de Itens";
            // 
            // listBox_bestItens
            // 
            this.listBox_bestItens.FormattingEnabled = true;
            this.listBox_bestItens.Location = new System.Drawing.Point(497, 280);
            this.listBox_bestItens.Name = "listBox_bestItens";
            this.listBox_bestItens.Size = new System.Drawing.Size(262, 147);
            this.listBox_bestItens.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Melhores Mochilas";
            // 
            // listBox_Mochilas_best
            // 
            this.listBox_Mochilas_best.FormattingEnabled = true;
            this.listBox_Mochilas_best.Location = new System.Drawing.Point(496, 48);
            this.listBox_Mochilas_best.Name = "listBox_Mochilas_best";
            this.listBox_Mochilas_best.Size = new System.Drawing.Size(263, 212);
            this.listBox_Mochilas_best.TabIndex = 11;
            this.listBox_Mochilas_best.SelectedIndexChanged += new System.EventHandler(this.listBox_Mochilas_best_SelectedIndexChanged);
            // 
            // button_Processar
            // 
            this.button_Processar.Location = new System.Drawing.Point(496, 482);
            this.button_Processar.Name = "button_Processar";
            this.button_Processar.Size = new System.Drawing.Size(269, 23);
            this.button_Processar.TabIndex = 15;
            this.button_Processar.Text = "Processar";
            this.button_Processar.UseVisualStyleBackColor = true;
            this.button_Processar.Click += new System.EventHandler(this.button_Processar_Click);
            // 
            // ValorCol1
            // 
            this.ValorCol1.AutoSize = true;
            this.ValorCol1.Location = new System.Drawing.Point(27, 458);
            this.ValorCol1.Name = "ValorCol1";
            this.ValorCol1.Size = new System.Drawing.Size(31, 13);
            this.ValorCol1.TabIndex = 16;
            this.ValorCol1.Text = "Valor";
            // 
            // PesoCol1
            // 
            this.PesoCol1.AutoSize = true;
            this.PesoCol1.Location = new System.Drawing.Point(27, 436);
            this.PesoCol1.Name = "PesoCol1";
            this.PesoCol1.Size = new System.Drawing.Size(31, 13);
            this.PesoCol1.TabIndex = 17;
            this.PesoCol1.Text = "Peso";
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 531);
            this.Controls.Add(this.PesoCol1);
            this.Controls.Add(this.ValorCol1);
            this.Controls.Add(this.button_Processar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox_bestItens);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox_Mochilas_best);
            this.Controls.Add(this.button1_config);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox_Itens_Mochila);
            this.Controls.Add(this.button_AprimorarPopulacao);
            this.Controls.Add(this.button_GerarItens);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_Mochilas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Itens);
            this.Name = "Resultados";
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.Resultados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Itens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_Mochilas;
        private System.Windows.Forms.Button button_GerarItens;
        private System.Windows.Forms.Button button_AprimorarPopulacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox_Itens_Mochila;
        private System.Windows.Forms.Button button1_config;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox_bestItens;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox_Mochilas_best;
        private System.Windows.Forms.Button button_Processar;
        private System.Windows.Forms.Label ValorCol1;
        private System.Windows.Forms.Label PesoCol1;
    }
}