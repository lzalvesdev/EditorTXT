using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorTXT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Menu Arquivo
        private void mArquivoNovo_Click(object sender, EventArgs e)
        {
            txtConteudo.Clear();
            mArquivoSalvar.Enabled = true;
            Text = Application.ProductName;
        }

        private void mArquivoNova_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new Form1()));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void mArquivoAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Abrir";
            dialog.Filter = "texto|*.txt|todos|*.*";

            DialogResult result = dialog.ShowDialog();

            if (result != DialogResult.Cancel && result != DialogResult.Abort)
            {
                if (File.Exists(dialog.FileName))
                {
                    FileInfo file = new FileInfo(dialog.FileName);
                    Text = $"{file.Name} - {Application.ProductName}";

                    Gerenciador.FolderPath = file.DirectoryName + @"\";
                    Gerenciador.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
                    Gerenciador.FileExt = file.Extension;

                    StreamReader stream = null;

                    try
                    {
                        stream = new StreamReader(file.FullName, true);

                        txtConteudo.Text = stream.ReadToEnd();

                        mArquivoSalvar.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Formato de arquivo não suportado.\n{ex.Message}");
                    }
                    finally
                    {
                        stream.Close();
                    }
                }
            }
        }

        private void SalvarArquivo(string path)
        {
            // Objeto responsável por escrever o arquivo
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(path, false);
                writer.Write(txtConteudo.Text);

                FileInfo file = new FileInfo(path);
                Gerenciador.FolderPath = file.DirectoryName + "\\";
                Gerenciador.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
                Gerenciador.FileExt = file.Extension;

                Text =$"{file.Name} - {Application.ProductName}";

                mArquivoSalvar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Salvar Arquivo: \n{ex.Message}");
            }
            finally
            {
                writer.Close();
            }
        }

        private void mArquivoSalvar_Click(object sender, EventArgs e)
        {
            if (File.Exists(Gerenciador.FilePath))
            {
                SalvarArquivo(Gerenciador.FilePath);
            }
            else
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Title = "Salvar";
                dialog.Filter = "texto|*.txt|todos|*.*";
                dialog.CheckFileExists = false;
                dialog.CheckPathExists = true;

                var result = dialog.ShowDialog();

                if (result != DialogResult.Cancel && result != DialogResult.Abort)
                {
                    SalvarArquivo(dialog.FileName);
                }
            }
        }

        private void mArquivoSalvarComo_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Salvar Como";
            dialog.Filter = "texto|*.txt|todos|*.*";
            dialog.CheckFileExists = false;
            dialog.CheckPathExists = true;

            var result = dialog.ShowDialog();

            if (result != DialogResult.Cancel && result != DialogResult.Abort)
            {
                SalvarArquivo(dialog.FileName);
            }
        }

        private void mArquivoSair_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente sair?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtConteudo_TextChanged(object sender, EventArgs e)
        {
            mArquivoSalvar.Enabled = true;
        }

        #endregion

        #region Menu Editar
        private void mEditarDesfazer_Click(object sender, EventArgs e)
        {
            txtConteudo.Undo();
        }

        private void mEditarRefazer_Click(object sender, EventArgs e)
        {
            txtConteudo.Redo();
        }

        private void mEditarRecortar_Click(object sender, EventArgs e)
        {
            txtConteudo.Cut();
        }

        private void mEditarCopiar_Click(object sender, EventArgs e)
        {
            txtConteudo.Copy();
        }

        private void mEditarColar_Click(object sender, EventArgs e)
        {
            txtConteudo.Paste();
        }

        private void mEditarExcluir_Click(object sender, EventArgs e)
        {
            txtConteudo.Text = txtConteudo.Text.Remove(txtConteudo.SelectionStart, txtConteudo.SelectedText.Length);
        }

        private void mEditarData_Click(object sender, EventArgs e)
        {
            int index = txtConteudo.SelectionStart;
            string dataHora = DateTime.Now.ToString();

            if (txtConteudo.SelectionStart == txtConteudo.Text.Length)
            {
                txtConteudo.Text = txtConteudo.Text + dataHora;
                txtConteudo.SelectionStart = index + dataHora.Length;
                return;
            }

            string temp = "";
            for (int i = 0; i < txtConteudo.Text.Length; i++)
            {
                if (i == txtConteudo.SelectionStart)
                {
                    temp += dataHora;
                    temp += txtConteudo.Text[i];
                }
                else
                {
                    temp += txtConteudo.Text[i];
                }
            }

            txtConteudo.Text += temp;
            txtConteudo.SelectionStart += index + dataHora.Length;
        }

        #endregion

        #region Menu Formatar
        private void mFormatarQuebra_Click(object sender, EventArgs e)
        {
            txtConteudo.WordWrap = mFormatarQuebra.Checked;
        }

        private void mFormatarFonte_Click(object sender, EventArgs e)
        {
            FontDialog fonte = new FontDialog();
            fonte.ShowColor = true;
            fonte.ShowEffects = true;
            
            fonte.Font = txtConteudo.Font;
            fonte.Color = txtConteudo.ForeColor;

            DialogResult result = fonte.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtConteudo.Font = fonte.Font;
                txtConteudo.ForeColor = fonte.Color;
            }
        }
        #endregion

        #region Menu Exibir
        private void ZoomStatus(float zoom)
        {
            StatusBarLabel.Text = $"{Math.Round(zoom * 100)}%";
        }
        private void mExibirZoomAmpliar_Click(object sender, EventArgs e)
        {
            txtConteudo.ZoomFactor += 0.25f;
            ZoomStatus(txtConteudo.ZoomFactor);
        }

        private void mExibirZoomReduzir_Click(object sender, EventArgs e)
        {
            if (txtConteudo.ZoomFactor <= 0.25f)
            {
                MessageBox.Show("Limite minimo de zoom atingido !");
                txtConteudo.ZoomFactor = 0.25f;
            }
            else
            {            
                txtConteudo.ZoomFactor -= 0.25f;
            }
            ZoomStatus(txtConteudo.ZoomFactor);
        }

        private void mExibirZoomRestaurar_Click(object sender, EventArgs e)
        {
            txtConteudo.ZoomFactor = 1f;
            ZoomStatus(txtConteudo.ZoomFactor);
        }

        private void mExibirStatus_Click(object sender, EventArgs e)
        {
            statusBar.Visible = mExibirStatus.Checked;
        }

        #endregion

        #region Menu Ajuda
        private void mAjudaExibir_Click(object sender, EventArgs e)
        {
            FormAjuda f = new FormAjuda();
            f.Show();
        }

        private void mAjudaSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clone de um bloco de notas");
        }
        #endregion

    }
}
