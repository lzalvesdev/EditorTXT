namespace EditorTXT
{
    partial class Form1
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.mArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoNova = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mArquivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoSalvarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mArquivoSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarDesfazer = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarRefazer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mEditarRecortar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarColar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mEditarData = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatar = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatarQuebra = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatarFonte = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibir = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoomAmpliar = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoomReduzir = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoomRestaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjudaExibir = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjudaSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.StatusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtConteudo = new System.Windows.Forms.RichTextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.Control;
            this.menuBar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArquivo,
            this.mEditar,
            this.mFormatar,
            this.mExibir,
            this.mAjuda});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.menuBar.Size = new System.Drawing.Size(784, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // mArquivo
            // 
            this.mArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArquivoNovo,
            this.mArquivoNova,
            this.toolStripSeparator1,
            this.mArquivoAbrir,
            this.mArquivoSalvar,
            this.mArquivoSalvarComo,
            this.toolStripSeparator2,
            this.mArquivoSair});
            this.mArquivo.Name = "mArquivo";
            this.mArquivo.Size = new System.Drawing.Size(59, 20);
            this.mArquivo.Text = "Arquivo";
            // 
            // mArquivoNovo
            // 
            this.mArquivoNovo.Name = "mArquivoNovo";
            this.mArquivoNovo.Size = new System.Drawing.Size(180, 22);
            this.mArquivoNovo.Text = "Novo";
            this.mArquivoNovo.Click += new System.EventHandler(this.mArquivoNovo_Click);
            // 
            // mArquivoNova
            // 
            this.mArquivoNova.Name = "mArquivoNova";
            this.mArquivoNova.Size = new System.Drawing.Size(180, 22);
            this.mArquivoNova.Text = "Nova Janela";
            this.mArquivoNova.Click += new System.EventHandler(this.mArquivoNova_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mArquivoAbrir
            // 
            this.mArquivoAbrir.Name = "mArquivoAbrir";
            this.mArquivoAbrir.Size = new System.Drawing.Size(180, 22);
            this.mArquivoAbrir.Text = "Abrir";
            this.mArquivoAbrir.Click += new System.EventHandler(this.mArquivoAbrir_Click);
            // 
            // mArquivoSalvar
            // 
            this.mArquivoSalvar.Name = "mArquivoSalvar";
            this.mArquivoSalvar.Size = new System.Drawing.Size(180, 22);
            this.mArquivoSalvar.Text = "Salvar";
            this.mArquivoSalvar.Click += new System.EventHandler(this.mArquivoSalvar_Click);
            // 
            // mArquivoSalvarComo
            // 
            this.mArquivoSalvarComo.Name = "mArquivoSalvarComo";
            this.mArquivoSalvarComo.Size = new System.Drawing.Size(180, 22);
            this.mArquivoSalvarComo.Text = "Salvar Como";
            this.mArquivoSalvarComo.Click += new System.EventHandler(this.mArquivoSalvarComo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // mArquivoSair
            // 
            this.mArquivoSair.Name = "mArquivoSair";
            this.mArquivoSair.Size = new System.Drawing.Size(180, 22);
            this.mArquivoSair.Text = "Sair";
            this.mArquivoSair.Click += new System.EventHandler(this.mArquivoSair_Click);
            // 
            // mEditar
            // 
            this.mEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEditarDesfazer,
            this.mEditarRefazer,
            this.toolStripSeparator3,
            this.mEditarRecortar,
            this.mEditarCopiar,
            this.mEditarColar,
            this.mEditarExcluir,
            this.toolStripSeparator4,
            this.mEditarData});
            this.mEditar.Name = "mEditar";
            this.mEditar.Size = new System.Drawing.Size(51, 20);
            this.mEditar.Text = "Editar";
            // 
            // mEditarDesfazer
            // 
            this.mEditarDesfazer.Name = "mEditarDesfazer";
            this.mEditarDesfazer.Size = new System.Drawing.Size(140, 22);
            this.mEditarDesfazer.Text = "Desfazer";
            // 
            // mEditarRefazer
            // 
            this.mEditarRefazer.Name = "mEditarRefazer";
            this.mEditarRefazer.Size = new System.Drawing.Size(140, 22);
            this.mEditarRefazer.Text = "Refazer";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(137, 6);
            // 
            // mEditarRecortar
            // 
            this.mEditarRecortar.Name = "mEditarRecortar";
            this.mEditarRecortar.Size = new System.Drawing.Size(140, 22);
            this.mEditarRecortar.Text = "Recortar";
            // 
            // mEditarCopiar
            // 
            this.mEditarCopiar.Name = "mEditarCopiar";
            this.mEditarCopiar.Size = new System.Drawing.Size(140, 22);
            this.mEditarCopiar.Text = "Copiar";
            // 
            // mEditarColar
            // 
            this.mEditarColar.Name = "mEditarColar";
            this.mEditarColar.Size = new System.Drawing.Size(140, 22);
            this.mEditarColar.Text = "Colar";
            // 
            // mEditarExcluir
            // 
            this.mEditarExcluir.Name = "mEditarExcluir";
            this.mEditarExcluir.Size = new System.Drawing.Size(140, 22);
            this.mEditarExcluir.Text = "Excluir";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(137, 6);
            // 
            // mEditarData
            // 
            this.mEditarData.Name = "mEditarData";
            this.mEditarData.Size = new System.Drawing.Size(140, 22);
            this.mEditarData.Text = "Data e Hora";
            // 
            // mFormatar
            // 
            this.mFormatar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFormatarQuebra,
            this.mFormatarFonte});
            this.mFormatar.Name = "mFormatar";
            this.mFormatar.Size = new System.Drawing.Size(69, 20);
            this.mFormatar.Text = "Formatar";
            // 
            // mFormatarQuebra
            // 
            this.mFormatarQuebra.Name = "mFormatarQuebra";
            this.mFormatarQuebra.Size = new System.Drawing.Size(226, 22);
            this.mFormatarQuebra.Text = "Quebra automática de linha";
            // 
            // mFormatarFonte
            // 
            this.mFormatarFonte.Name = "mFormatarFonte";
            this.mFormatarFonte.Size = new System.Drawing.Size(226, 22);
            this.mFormatarFonte.Text = "Fonte";
            // 
            // mExibir
            // 
            this.mExibir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mExibirZoom,
            this.mExibirStatus});
            this.mExibir.Name = "mExibir";
            this.mExibir.Size = new System.Drawing.Size(49, 20);
            this.mExibir.Text = "Exibir";
            // 
            // mExibirZoom
            // 
            this.mExibirZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mExibirZoomAmpliar,
            this.mExibirZoomReduzir,
            this.mExibirZoomRestaurar});
            this.mExibirZoom.Name = "mExibirZoom";
            this.mExibirZoom.Size = new System.Drawing.Size(158, 22);
            this.mExibirZoom.Text = "Zoom";
            // 
            // mExibirZoomAmpliar
            // 
            this.mExibirZoomAmpliar.Name = "mExibirZoomAmpliar";
            this.mExibirZoomAmpliar.Size = new System.Drawing.Size(129, 22);
            this.mExibirZoomAmpliar.Text = "Ampliar";
            // 
            // mExibirZoomReduzir
            // 
            this.mExibirZoomReduzir.Name = "mExibirZoomReduzir";
            this.mExibirZoomReduzir.Size = new System.Drawing.Size(129, 22);
            this.mExibirZoomReduzir.Text = "Reduzir";
            // 
            // mExibirZoomRestaurar
            // 
            this.mExibirZoomRestaurar.Name = "mExibirZoomRestaurar";
            this.mExibirZoomRestaurar.Size = new System.Drawing.Size(129, 22);
            this.mExibirZoomRestaurar.Text = "Restaurar";
            // 
            // mExibirStatus
            // 
            this.mExibirStatus.Checked = true;
            this.mExibirStatus.CheckOnClick = true;
            this.mExibirStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mExibirStatus.Name = "mExibirStatus";
            this.mExibirStatus.Size = new System.Drawing.Size(158, 22);
            this.mExibirStatus.Text = "Barra de status";
            // 
            // mAjuda
            // 
            this.mAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAjudaExibir,
            this.mAjudaSobre});
            this.mAjuda.Name = "mAjuda";
            this.mAjuda.Size = new System.Drawing.Size(50, 20);
            this.mAjuda.Text = "Ajuda";
            // 
            // mAjudaExibir
            // 
            this.mAjudaExibir.Name = "mAjudaExibir";
            this.mAjudaExibir.Size = new System.Drawing.Size(138, 22);
            this.mAjudaExibir.Text = "Exibir ajuda";
            // 
            // mAjudaSobre
            // 
            this.mAjudaSobre.Name = "mAjudaSobre";
            this.mAjudaSobre.Size = new System.Drawing.Size(138, 22);
            this.mAjudaSobre.Text = "Sobre";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 539);
            this.statusBar.Name = "statusBar";
            this.statusBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusBar.Size = new System.Drawing.Size(784, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // StatusBarLabel
            // 
            this.StatusBarLabel.Name = "StatusBarLabel";
            this.StatusBarLabel.Size = new System.Drawing.Size(35, 17);
            this.StatusBarLabel.Text = "100%";
            // 
            // txtConteudo
            // 
            this.txtConteudo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConteudo.Location = new System.Drawing.Point(0, 24);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(784, 515);
            this.txtConteudo.TabIndex = 2;
            this.txtConteudo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditorTXT";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem mArquivo;
        private System.Windows.Forms.ToolStripMenuItem mEditar;
        private System.Windows.Forms.ToolStripMenuItem mArquivoNovo;
        private System.Windows.Forms.ToolStripMenuItem mArquivoNova;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mArquivoAbrir;
        private System.Windows.Forms.ToolStripMenuItem mArquivoSalvar;
        private System.Windows.Forms.ToolStripMenuItem mArquivoSalvarComo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mArquivoSair;
        private System.Windows.Forms.ToolStripMenuItem mFormatar;
        private System.Windows.Forms.ToolStripMenuItem mExibir;
        private System.Windows.Forms.ToolStripMenuItem mAjuda;
        private System.Windows.Forms.ToolStripMenuItem mEditarDesfazer;
        private System.Windows.Forms.ToolStripMenuItem mEditarRefazer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mEditarRecortar;
        private System.Windows.Forms.ToolStripMenuItem mEditarCopiar;
        private System.Windows.Forms.ToolStripMenuItem mEditarColar;
        private System.Windows.Forms.ToolStripMenuItem mEditarExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mEditarData;
        private System.Windows.Forms.ToolStripMenuItem mFormatarQuebra;
        private System.Windows.Forms.ToolStripMenuItem mFormatarFonte;
        private System.Windows.Forms.ToolStripMenuItem mExibirZoom;
        private System.Windows.Forms.ToolStripMenuItem mExibirZoomAmpliar;
        private System.Windows.Forms.ToolStripMenuItem mExibirZoomReduzir;
        private System.Windows.Forms.ToolStripMenuItem mExibirZoomRestaurar;
        private System.Windows.Forms.ToolStripMenuItem mExibirStatus;
        private System.Windows.Forms.ToolStripMenuItem mAjudaExibir;
        private System.Windows.Forms.ToolStripMenuItem mAjudaSobre;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarLabel;
        private System.Windows.Forms.RichTextBox txtConteudo;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

