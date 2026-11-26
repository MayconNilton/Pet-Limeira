using PetLimeira.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PetLimeira.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void procedimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formTutor = new TutorForm();
            formTutor.MdiParent = this;
            formTutor.WindowState = FormWindowState.Maximized;
            formTutor.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Obter a data e hora atual
            DateTime dataHoraAtual = DateTime.Now;

            // Atualizar o status com a data e hora
            status2.Text = dataHoraAtual.ToString();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Pedir confirmação para fechar
            DialogResult confirmacao = MessageBox.Show(
              "Deseja fechar a aplicação",
              "Confirmação",
              MessageBoxButtons.OKCancel,
              MessageBoxIcon.Question);

            if (confirmacao == DialogResult.OK)
            {
                // Fechar a aplicação
                Application.Exit();
            }

        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Notepad.exe");
        }

        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "https://youtube.com");
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "excel.exe",
                UseShellExecute = true,
            });

        }

        private void listaDeCidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Instanciar o formulario (classe) cidades
            Form formCidades = new cidades();
            formCidades.MdiParent = this; // Abrir dentro do principal
            formCidades.WindowState = FormWindowState.Maximized;
            formCidades.Show();

        }

        private void preçoDosCombustíveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciar o formulario (classe) cidades
            Form formPrecogasolinaetanol = new precosgasolinaetanol();
            formPrecogasolinaetanol.MdiParent = this; // Abrir dentro do principal
            formPrecogasolinaetanol.WindowState = FormWindowState.Maximized;
            formPrecogasolinaetanol.Show();

        }

        private void todosOsCampeõesMundiaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mensagem.Aviso("Todos os Campeoes Mundiais - em breve");
        }

        private void animalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formAnimal = new AnimalForm();
            formAnimal.MdiParent = this; // Abrir dentro do principal
            formAnimal.WindowState = FormWindowState.Maximized;
            formAnimal.Show();
        }
    }
}
