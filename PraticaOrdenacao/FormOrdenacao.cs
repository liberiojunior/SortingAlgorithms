using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace PraticaOrdenacao
{
    public partial class FormOrdenacao : Form
    {
        int[] vet = new int[500]; // vetor interno para a animação

        public FormOrdenacao()
        {
            InitializeComponent();
            panel.Paint += new PaintEventHandler(panel_Paint);
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, panel, new object[] { true });
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < vet.Length; i++)
            {
                e.Graphics.DrawLine(System.Drawing.Pens.Red, i, 299, i, 299 - vet[i]);
            }
        }


        // TODO: animação e estatísticas dos demais métodos de ordenação

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,
                "Métodos de Ordenação - 2018/1\n\nDesenvolvido por:\n71800760 - Libério Albino de Sousa Júnior\nProf. Virgílio Borges de Oliveira\n\nAlgoritmos e Estruturas de Dados\nFaculdade COTEMIG\nSomente para fins didáticos.",
                "Sobre o trabalho...",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void iniciaAnimacao(Action a)
        {
            if (bgw.IsBusy != true)
            {
                bgw.RunWorkerAsync(a);
            }
            else
            {
                MessageBox.Show(this,
                   "Aguarde o fim da execução atual...",
                   "Métodos de Ordenação - 2018/1",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);
            }
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            Action a = (Action)e.Argument;
            a();
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(this,
               "Animação concluída!",
               "Métodos de Ordenação - 2018/1",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }

        private void bolhaToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            int[] vetor = new int[10000]; // TODO
            Preenchimento.Aleatorio(vetor, 1000); // TODO
            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            OrdenacaoEstatistica.Bolha(vetor);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: TODO" +
                  "\nOrdenação inicial: TODO" +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: TODO" +
                  "\nNº de trocas: TODO",
                  "Estatísticas do Método Bolha",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }


        private void aleatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preenchimento.Aleatorio(vet, 299);
            iniciaAnimacao(() => OrdenacaoGrafica.Bolha(vet, panel));
        }

        private void aleatórioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Preenchimento.Aleatorio(vet, 299);
            iniciaAnimacao(() => OrdenacaoGrafica.selecao(vet, panel));
        }

        private void aleatórioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Preenchimento.Aleatorio(vet, 299);
            iniciaAnimacao(() => OrdenacaoGrafica.insercao(vet, panel));
        }

        private void aleatórioToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Preenchimento.Aleatorio(vet, 299);
            iniciaAnimacao(() => OrdenacaoGrafica.shellSort(vet, panel));
        }

        private void aleatórioToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Preenchimento.Aleatorio(vet, 299);
            iniciaAnimacao(() => OrdenacaoGrafica.heapSort(vet, panel));
        }

        private void aleatórioToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Preenchimento.Aleatorio(vet, 299);
            iniciaAnimacao(() => OrdenacaoGrafica.mergeSort(vet, 0, vet.Length - 1, panel));
        }

        private void aleatórioToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Preenchimento.Aleatorio(vet, 299);
            iniciaAnimacao(() => OrdenacaoGrafica.quickSort(vet, 0, vet.Length - 1, panel));
        }

        private void crescenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preenchimento.Crescente(vet, 299);
            iniciaAnimacao(() => OrdenacaoGrafica.Bolha(vet, panel));
        }

        private void crescenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Preenchimento.Crescente(vet, 299);
            iniciaAnimacao(() => OrdenacaoGrafica.selecao(vet, panel));
        }

        private void crescenteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Preenchimento.Crescente(vet, 299);
            iniciaAnimacao(() => OrdenacaoGrafica.insercao(vet, panel));
        }

        private void crescenteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Preenchimento.Crescente(vet, 299);
            iniciaAnimacao(() => OrdenacaoGrafica.shellSort(vet, panel));
        }

        private void crescenteToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Preenchimento.Crescente(vet, 299);
            iniciaAnimacao(() => OrdenacaoGrafica.heapSort(vet, panel));
        }

        private void crescenteToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Preenchimento.Crescente(vet, 299);
            iniciaAnimacao(() => OrdenacaoGrafica.quickSort(vet, 0, vet.Length - 1, panel));
        }

        private void crescenteToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Preenchimento.Crescente(vet, 299);
            iniciaAnimacao(() => OrdenacaoGrafica.mergeSort(vet, 0, vet.Length - 1, panel));
        }

        private void decrescenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Preenchimento.Decrescente(vet, 299);
            iniciaAnimacao(() => OrdenacaoGrafica.Bolha(vet, panel));
        }

        private void decrescenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Preenchimento.Decrescente(vet, 299);
            iniciaAnimacao(() => OrdenacaoGrafica.selecao(vet, panel));
        }

        private void decrescenteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Preenchimento.Decrescente(vet, 299);
            iniciaAnimacao(() => OrdenacaoGrafica.insercao(vet, panel));
        }

        private void decrescenteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Preenchimento.Decrescente(vet, 299);
            iniciaAnimacao(() => OrdenacaoGrafica.shellSort(vet, panel));
        }

        private void decrescenteToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Preenchimento.Decrescente(vet, 299);
            iniciaAnimacao(() => OrdenacaoGrafica.heapSort(vet, panel));
        }

        private void decrescenteToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Preenchimento.Decrescente(vet, 299);
            iniciaAnimacao(() => OrdenacaoGrafica.quickSort(vet, 0, vet.Length - 1, panel));
        }

        private void decrescenteToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Preenchimento.Decrescente(vet, 299);
            iniciaAnimacao(() => OrdenacaoGrafica.mergeSort(vet, 0, vet.Length - 1, panel));
        }
    }
}
