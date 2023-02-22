namespace PraticaOrdenacao
{
    partial class FormOrdenacao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.algoritmoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crescenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decrescenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crescenteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.decrescenteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatórioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inserçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crescenteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.decrescenteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatórioToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.shellsortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crescenteToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.decrescenteToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatórioToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.heapsortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crescenteToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.decrescenteToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatórioToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.quicksortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crescenteToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.decrescenteToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatórioToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.mergesortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crescenteToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.decrescenteToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatórioToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.estatísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolhaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 27);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(500, 300);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmoToolStripMenuItem,
            this.estatísticasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // algoritmoToolStripMenuItem
            // 
            this.algoritmoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bolhaToolStripMenuItem,
            this.seleçãoToolStripMenuItem,
            this.inserçãoToolStripMenuItem,
            this.shellsortToolStripMenuItem,
            this.heapsortToolStripMenuItem,
            this.quicksortToolStripMenuItem,
            this.mergesortToolStripMenuItem});
            this.algoritmoToolStripMenuItem.Name = "algoritmoToolStripMenuItem";
            this.algoritmoToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.algoritmoToolStripMenuItem.Text = "Algoritmo";
            // 
            // bolhaToolStripMenuItem
            // 
            this.bolhaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crescenteToolStripMenuItem,
            this.decrescenteToolStripMenuItem,
            this.aleatórioToolStripMenuItem});
            this.bolhaToolStripMenuItem.Name = "bolhaToolStripMenuItem";
            this.bolhaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bolhaToolStripMenuItem.Text = "Bolha";
            // 
            // crescenteToolStripMenuItem
            // 
            this.crescenteToolStripMenuItem.Name = "crescenteToolStripMenuItem";
            this.crescenteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.crescenteToolStripMenuItem.Text = "Crescente";
            this.crescenteToolStripMenuItem.Click += new System.EventHandler(this.crescenteToolStripMenuItem_Click);
            // 
            // decrescenteToolStripMenuItem
            // 
            this.decrescenteToolStripMenuItem.Name = "decrescenteToolStripMenuItem";
            this.decrescenteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.decrescenteToolStripMenuItem.Text = "Decrescente";
            this.decrescenteToolStripMenuItem.Click += new System.EventHandler(this.decrescenteToolStripMenuItem_Click);
            // 
            // aleatórioToolStripMenuItem
            // 
            this.aleatórioToolStripMenuItem.Name = "aleatórioToolStripMenuItem";
            this.aleatórioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aleatórioToolStripMenuItem.Text = "Aleatório";
            this.aleatórioToolStripMenuItem.Click += new System.EventHandler(this.aleatórioToolStripMenuItem_Click);
            // 
            // seleçãoToolStripMenuItem
            // 
            this.seleçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crescenteToolStripMenuItem1,
            this.decrescenteToolStripMenuItem1,
            this.aleatórioToolStripMenuItem1});
            this.seleçãoToolStripMenuItem.Name = "seleçãoToolStripMenuItem";
            this.seleçãoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.seleçãoToolStripMenuItem.Text = "Seleção";
            // 
            // crescenteToolStripMenuItem1
            // 
            this.crescenteToolStripMenuItem1.Name = "crescenteToolStripMenuItem1";
            this.crescenteToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.crescenteToolStripMenuItem1.Text = "Crescente";
            this.crescenteToolStripMenuItem1.Click += new System.EventHandler(this.crescenteToolStripMenuItem1_Click);
            // 
            // decrescenteToolStripMenuItem1
            // 
            this.decrescenteToolStripMenuItem1.Name = "decrescenteToolStripMenuItem1";
            this.decrescenteToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.decrescenteToolStripMenuItem1.Text = "Decrescente";
            this.decrescenteToolStripMenuItem1.Click += new System.EventHandler(this.decrescenteToolStripMenuItem1_Click);
            // 
            // aleatórioToolStripMenuItem1
            // 
            this.aleatórioToolStripMenuItem1.Name = "aleatórioToolStripMenuItem1";
            this.aleatórioToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.aleatórioToolStripMenuItem1.Text = "Aleatório";
            this.aleatórioToolStripMenuItem1.Click += new System.EventHandler(this.aleatórioToolStripMenuItem1_Click);
            // 
            // inserçãoToolStripMenuItem
            // 
            this.inserçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crescenteToolStripMenuItem2,
            this.decrescenteToolStripMenuItem2,
            this.aleatórioToolStripMenuItem2});
            this.inserçãoToolStripMenuItem.Name = "inserçãoToolStripMenuItem";
            this.inserçãoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inserçãoToolStripMenuItem.Text = "Inserção";
            // 
            // crescenteToolStripMenuItem2
            // 
            this.crescenteToolStripMenuItem2.Name = "crescenteToolStripMenuItem2";
            this.crescenteToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.crescenteToolStripMenuItem2.Text = "Crescente";
            this.crescenteToolStripMenuItem2.Click += new System.EventHandler(this.crescenteToolStripMenuItem2_Click);
            // 
            // decrescenteToolStripMenuItem2
            // 
            this.decrescenteToolStripMenuItem2.Name = "decrescenteToolStripMenuItem2";
            this.decrescenteToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.decrescenteToolStripMenuItem2.Text = "Decrescente";
            this.decrescenteToolStripMenuItem2.Click += new System.EventHandler(this.decrescenteToolStripMenuItem2_Click);
            // 
            // aleatórioToolStripMenuItem2
            // 
            this.aleatórioToolStripMenuItem2.Name = "aleatórioToolStripMenuItem2";
            this.aleatórioToolStripMenuItem2.Size = new System.Drawing.Size(138, 22);
            this.aleatórioToolStripMenuItem2.Text = "Aleatório";
            this.aleatórioToolStripMenuItem2.Click += new System.EventHandler(this.aleatórioToolStripMenuItem2_Click);
            // 
            // shellsortToolStripMenuItem
            // 
            this.shellsortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crescenteToolStripMenuItem3,
            this.decrescenteToolStripMenuItem3,
            this.aleatórioToolStripMenuItem3});
            this.shellsortToolStripMenuItem.Name = "shellsortToolStripMenuItem";
            this.shellsortToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.shellsortToolStripMenuItem.Text = "Shellsort";
            // 
            // crescenteToolStripMenuItem3
            // 
            this.crescenteToolStripMenuItem3.Name = "crescenteToolStripMenuItem3";
            this.crescenteToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.crescenteToolStripMenuItem3.Text = "Crescente";
            this.crescenteToolStripMenuItem3.Click += new System.EventHandler(this.crescenteToolStripMenuItem3_Click);
            // 
            // decrescenteToolStripMenuItem3
            // 
            this.decrescenteToolStripMenuItem3.Name = "decrescenteToolStripMenuItem3";
            this.decrescenteToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.decrescenteToolStripMenuItem3.Text = "Decrescente";
            this.decrescenteToolStripMenuItem3.Click += new System.EventHandler(this.decrescenteToolStripMenuItem3_Click);
            // 
            // aleatórioToolStripMenuItem3
            // 
            this.aleatórioToolStripMenuItem3.Name = "aleatórioToolStripMenuItem3";
            this.aleatórioToolStripMenuItem3.Size = new System.Drawing.Size(138, 22);
            this.aleatórioToolStripMenuItem3.Text = "Aleatório";
            this.aleatórioToolStripMenuItem3.Click += new System.EventHandler(this.aleatórioToolStripMenuItem3_Click);
            // 
            // heapsortToolStripMenuItem
            // 
            this.heapsortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crescenteToolStripMenuItem4,
            this.decrescenteToolStripMenuItem4,
            this.aleatórioToolStripMenuItem4});
            this.heapsortToolStripMenuItem.Name = "heapsortToolStripMenuItem";
            this.heapsortToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.heapsortToolStripMenuItem.Text = "Heapsort";
            // 
            // crescenteToolStripMenuItem4
            // 
            this.crescenteToolStripMenuItem4.Name = "crescenteToolStripMenuItem4";
            this.crescenteToolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.crescenteToolStripMenuItem4.Text = "Crescente";
            this.crescenteToolStripMenuItem4.Click += new System.EventHandler(this.crescenteToolStripMenuItem4_Click);
            // 
            // decrescenteToolStripMenuItem4
            // 
            this.decrescenteToolStripMenuItem4.Name = "decrescenteToolStripMenuItem4";
            this.decrescenteToolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.decrescenteToolStripMenuItem4.Text = "Decrescente";
            this.decrescenteToolStripMenuItem4.Click += new System.EventHandler(this.decrescenteToolStripMenuItem4_Click);
            // 
            // aleatórioToolStripMenuItem4
            // 
            this.aleatórioToolStripMenuItem4.Name = "aleatórioToolStripMenuItem4";
            this.aleatórioToolStripMenuItem4.Size = new System.Drawing.Size(138, 22);
            this.aleatórioToolStripMenuItem4.Text = "Aleatório";
            this.aleatórioToolStripMenuItem4.Click += new System.EventHandler(this.aleatórioToolStripMenuItem4_Click);
            // 
            // quicksortToolStripMenuItem
            // 
            this.quicksortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crescenteToolStripMenuItem5,
            this.decrescenteToolStripMenuItem5,
            this.aleatórioToolStripMenuItem5});
            this.quicksortToolStripMenuItem.Name = "quicksortToolStripMenuItem";
            this.quicksortToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quicksortToolStripMenuItem.Text = "Quicksort";
            // 
            // crescenteToolStripMenuItem5
            // 
            this.crescenteToolStripMenuItem5.Name = "crescenteToolStripMenuItem5";
            this.crescenteToolStripMenuItem5.Size = new System.Drawing.Size(152, 22);
            this.crescenteToolStripMenuItem5.Text = "Crescente";
            this.crescenteToolStripMenuItem5.Click += new System.EventHandler(this.crescenteToolStripMenuItem5_Click);
            // 
            // decrescenteToolStripMenuItem5
            // 
            this.decrescenteToolStripMenuItem5.Name = "decrescenteToolStripMenuItem5";
            this.decrescenteToolStripMenuItem5.Size = new System.Drawing.Size(152, 22);
            this.decrescenteToolStripMenuItem5.Text = "Decrescente";
            this.decrescenteToolStripMenuItem5.Click += new System.EventHandler(this.decrescenteToolStripMenuItem5_Click);
            // 
            // aleatórioToolStripMenuItem5
            // 
            this.aleatórioToolStripMenuItem5.Name = "aleatórioToolStripMenuItem5";
            this.aleatórioToolStripMenuItem5.Size = new System.Drawing.Size(138, 22);
            this.aleatórioToolStripMenuItem5.Text = "Aleatório";
            this.aleatórioToolStripMenuItem5.Click += new System.EventHandler(this.aleatórioToolStripMenuItem5_Click);
            // 
            // mergesortToolStripMenuItem
            // 
            this.mergesortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crescenteToolStripMenuItem6,
            this.decrescenteToolStripMenuItem6,
            this.aleatórioToolStripMenuItem6});
            this.mergesortToolStripMenuItem.Name = "mergesortToolStripMenuItem";
            this.mergesortToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mergesortToolStripMenuItem.Text = "Mergesort";
            // 
            // crescenteToolStripMenuItem6
            // 
            this.crescenteToolStripMenuItem6.Name = "crescenteToolStripMenuItem6";
            this.crescenteToolStripMenuItem6.Size = new System.Drawing.Size(152, 22);
            this.crescenteToolStripMenuItem6.Text = "Crescente";
            this.crescenteToolStripMenuItem6.Click += new System.EventHandler(this.crescenteToolStripMenuItem6_Click);
            // 
            // decrescenteToolStripMenuItem6
            // 
            this.decrescenteToolStripMenuItem6.Name = "decrescenteToolStripMenuItem6";
            this.decrescenteToolStripMenuItem6.Size = new System.Drawing.Size(152, 22);
            this.decrescenteToolStripMenuItem6.Text = "Decrescente";
            this.decrescenteToolStripMenuItem6.Click += new System.EventHandler(this.decrescenteToolStripMenuItem6_Click);
            // 
            // aleatórioToolStripMenuItem6
            // 
            this.aleatórioToolStripMenuItem6.Name = "aleatórioToolStripMenuItem6";
            this.aleatórioToolStripMenuItem6.Size = new System.Drawing.Size(138, 22);
            this.aleatórioToolStripMenuItem6.Text = "Aleatório";
            this.aleatórioToolStripMenuItem6.Click += new System.EventHandler(this.aleatórioToolStripMenuItem6_Click);
            // 
            // estatísticasToolStripMenuItem
            // 
            this.estatísticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bolhaToolStripMenuItem1});
            this.estatísticasToolStripMenuItem.Name = "estatísticasToolStripMenuItem";
            this.estatísticasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.estatísticasToolStripMenuItem.Text = "Estatísticas";
            // 
            // bolhaToolStripMenuItem1
            // 
            this.bolhaToolStripMenuItem1.Name = "bolhaToolStripMenuItem1";
            this.bolhaToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.bolhaToolStripMenuItem1.Text = "Bolha";
            this.bolhaToolStripMenuItem1.Click += new System.EventHandler(this.bolhaToolStripMenuItem1_Click_1);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // bgw
            // 
            this.bgw.WorkerSupportsCancellation = true;
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // FormOrdenacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 331);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormOrdenacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prática 5 - Métodos de Ordenação 2018/1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algoritmoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bolhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatísticasToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.ToolStripMenuItem bolhaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem crescenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decrescenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aleatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crescenteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inserçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shellsortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heapsortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quicksortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergesortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decrescenteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aleatórioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem crescenteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem decrescenteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aleatórioToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem crescenteToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem decrescenteToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem aleatórioToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem crescenteToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem decrescenteToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem aleatórioToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem crescenteToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem decrescenteToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem aleatórioToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem crescenteToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem decrescenteToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem aleatórioToolStripMenuItem6;
    }
}

