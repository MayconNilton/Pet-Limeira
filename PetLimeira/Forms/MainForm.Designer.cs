namespace PetLimeira.Forms
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            tutorToolStripMenuItem = new ToolStripMenuItem();
            animalToolStripMenuItem = new ToolStripMenuItem();
            nomeToolStripMenuItem = new ToolStripMenuItem();
            espécieToolStripMenuItem = new ToolStripMenuItem();
            raçaToolStripMenuItem = new ToolStripMenuItem();
            dToolStripMenuItem = new ToolStripMenuItem();
            pesoToolStripMenuItem = new ToolStripMenuItem();
            veterinariosToolStripMenuItem = new ToolStripMenuItem();
            nomeToolStripMenuItem1 = new ToolStripMenuItem();
            cRMVToolStripMenuItem = new ToolStripMenuItem();
            especialidadeToolStripMenuItem = new ToolStripMenuItem();
            consultaToolStripMenuItem = new ToolStripMenuItem();
            dataEHoraToolStripMenuItem = new ToolStripMenuItem();
            motivoToolStripMenuItem = new ToolStripMenuItem();
            observaçõesToolStripMenuItem = new ToolStripMenuItem();
            procedimentosToolStripMenuItem = new ToolStripMenuItem();
            nomeToolStripMenuItem2 = new ToolStripMenuItem();
            preçoToolStripMenuItem = new ToolStripMenuItem();
            quantidadeAplicadaToolStripMenuItem = new ToolStripMenuItem();
            valorFinalToolStripMenuItem = new ToolStripMenuItem();
            carteiraDeVacinaçãoÚnicaToolStripMenuItem = new ToolStripMenuItem();
            numeroDeRegistroToolStripMenuItem = new ToolStripMenuItem();
            dataDeEmissãoToolStripMenuItem = new ToolStripMenuItem();
            ultilToolStripMenuItem = new ToolStripMenuItem();
            calculadoraToolStripMenuItem = new ToolStripMenuItem();
            blocoDeNotasToolStripMenuItem = new ToolStripMenuItem();
            excelToolStripMenuItem = new ToolStripMenuItem();
            dadosExternosToolStripMenuItem = new ToolStripMenuItem();
            listaDeCidadesToolStripMenuItem = new ToolStripMenuItem();
            preçoDosCombustíveisToolStripMenuItem = new ToolStripMenuItem();
            todosOsCampeõesMundiaisToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            tutoriaisToolStripMenuItem = new ToolStripMenuItem();
            helpDeskToolStripMenuItem = new ToolStripMenuItem();
            youtubeToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            sobreOSistemaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            status2 = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, ultilToolStripMenuItem, dadosExternosToolStripMenuItem, ajudaToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tutorToolStripMenuItem, animalToolStripMenuItem, veterinariosToolStripMenuItem, consultaToolStripMenuItem, procedimentosToolStripMenuItem, carteiraDeVacinaçãoÚnicaToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // tutorToolStripMenuItem
            // 
            tutorToolStripMenuItem.Name = "tutorToolStripMenuItem";
            tutorToolStripMenuItem.Size = new Size(220, 22);
            tutorToolStripMenuItem.Text = "Tutores";
            tutorToolStripMenuItem.Click += tutorToolStripMenuItem_Click;
            // 
            // animalToolStripMenuItem
            // 
            animalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nomeToolStripMenuItem, espécieToolStripMenuItem, raçaToolStripMenuItem, dToolStripMenuItem, pesoToolStripMenuItem });
            animalToolStripMenuItem.Name = "animalToolStripMenuItem";
            animalToolStripMenuItem.Size = new Size(220, 22);
            animalToolStripMenuItem.Text = "Animais";
            animalToolStripMenuItem.Click += animalToolStripMenuItem_Click;
            // 
            // nomeToolStripMenuItem
            // 
            nomeToolStripMenuItem.Name = "nomeToolStripMenuItem";
            nomeToolStripMenuItem.Size = new Size(181, 22);
            nomeToolStripMenuItem.Text = "Nome";
            // 
            // espécieToolStripMenuItem
            // 
            espécieToolStripMenuItem.Name = "espécieToolStripMenuItem";
            espécieToolStripMenuItem.Size = new Size(181, 22);
            espécieToolStripMenuItem.Text = "Espécie";
            // 
            // raçaToolStripMenuItem
            // 
            raçaToolStripMenuItem.Name = "raçaToolStripMenuItem";
            raçaToolStripMenuItem.Size = new Size(181, 22);
            raçaToolStripMenuItem.Text = "Raça";
            // 
            // dToolStripMenuItem
            // 
            dToolStripMenuItem.Name = "dToolStripMenuItem";
            dToolStripMenuItem.Size = new Size(181, 22);
            dToolStripMenuItem.Text = "Data de Nascimento";
            // 
            // pesoToolStripMenuItem
            // 
            pesoToolStripMenuItem.Name = "pesoToolStripMenuItem";
            pesoToolStripMenuItem.Size = new Size(181, 22);
            pesoToolStripMenuItem.Text = "Peso ";
            // 
            // veterinariosToolStripMenuItem
            // 
            veterinariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nomeToolStripMenuItem1, cRMVToolStripMenuItem, especialidadeToolStripMenuItem });
            veterinariosToolStripMenuItem.Name = "veterinariosToolStripMenuItem";
            veterinariosToolStripMenuItem.Size = new Size(220, 22);
            veterinariosToolStripMenuItem.Text = "Veterinarios";
            // 
            // nomeToolStripMenuItem1
            // 
            nomeToolStripMenuItem1.Name = "nomeToolStripMenuItem1";
            nomeToolStripMenuItem1.Size = new Size(145, 22);
            nomeToolStripMenuItem1.Text = "Nome";
            // 
            // cRMVToolStripMenuItem
            // 
            cRMVToolStripMenuItem.Name = "cRMVToolStripMenuItem";
            cRMVToolStripMenuItem.Size = new Size(145, 22);
            cRMVToolStripMenuItem.Text = "CRMV";
            // 
            // especialidadeToolStripMenuItem
            // 
            especialidadeToolStripMenuItem.Name = "especialidadeToolStripMenuItem";
            especialidadeToolStripMenuItem.Size = new Size(145, 22);
            especialidadeToolStripMenuItem.Text = "Especialidade";
            // 
            // consultaToolStripMenuItem
            // 
            consultaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dataEHoraToolStripMenuItem, motivoToolStripMenuItem, observaçõesToolStripMenuItem });
            consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            consultaToolStripMenuItem.Size = new Size(220, 22);
            consultaToolStripMenuItem.Text = "Consultas";
            // 
            // dataEHoraToolStripMenuItem
            // 
            dataEHoraToolStripMenuItem.Name = "dataEHoraToolStripMenuItem";
            dataEHoraToolStripMenuItem.Size = new Size(141, 22);
            dataEHoraToolStripMenuItem.Text = "Data e Hora";
            // 
            // motivoToolStripMenuItem
            // 
            motivoToolStripMenuItem.Name = "motivoToolStripMenuItem";
            motivoToolStripMenuItem.Size = new Size(141, 22);
            motivoToolStripMenuItem.Text = "Motivo";
            // 
            // observaçõesToolStripMenuItem
            // 
            observaçõesToolStripMenuItem.Name = "observaçõesToolStripMenuItem";
            observaçõesToolStripMenuItem.Size = new Size(141, 22);
            observaçõesToolStripMenuItem.Text = "Observações";
            // 
            // procedimentosToolStripMenuItem
            // 
            procedimentosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nomeToolStripMenuItem2, preçoToolStripMenuItem, quantidadeAplicadaToolStripMenuItem, valorFinalToolStripMenuItem });
            procedimentosToolStripMenuItem.Name = "procedimentosToolStripMenuItem";
            procedimentosToolStripMenuItem.Size = new Size(220, 22);
            procedimentosToolStripMenuItem.Text = "Procedimentos";
            procedimentosToolStripMenuItem.Click += procedimentosToolStripMenuItem_Click;
            // 
            // nomeToolStripMenuItem2
            // 
            nomeToolStripMenuItem2.Name = "nomeToolStripMenuItem2";
            nomeToolStripMenuItem2.Size = new Size(183, 22);
            nomeToolStripMenuItem2.Text = "Nome";
            // 
            // preçoToolStripMenuItem
            // 
            preçoToolStripMenuItem.Name = "preçoToolStripMenuItem";
            preçoToolStripMenuItem.Size = new Size(183, 22);
            preçoToolStripMenuItem.Text = "Preço de Tabela";
            // 
            // quantidadeAplicadaToolStripMenuItem
            // 
            quantidadeAplicadaToolStripMenuItem.Name = "quantidadeAplicadaToolStripMenuItem";
            quantidadeAplicadaToolStripMenuItem.Size = new Size(183, 22);
            quantidadeAplicadaToolStripMenuItem.Text = "Quantidade aplicada";
            // 
            // valorFinalToolStripMenuItem
            // 
            valorFinalToolStripMenuItem.Name = "valorFinalToolStripMenuItem";
            valorFinalToolStripMenuItem.Size = new Size(183, 22);
            valorFinalToolStripMenuItem.Text = "Valor Final";
            // 
            // carteiraDeVacinaçãoÚnicaToolStripMenuItem
            // 
            carteiraDeVacinaçãoÚnicaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { numeroDeRegistroToolStripMenuItem, dataDeEmissãoToolStripMenuItem });
            carteiraDeVacinaçãoÚnicaToolStripMenuItem.Name = "carteiraDeVacinaçãoÚnicaToolStripMenuItem";
            carteiraDeVacinaçãoÚnicaToolStripMenuItem.Size = new Size(220, 22);
            carteiraDeVacinaçãoÚnicaToolStripMenuItem.Text = "Carteira de Vacinação Única";
            // 
            // numeroDeRegistroToolStripMenuItem
            // 
            numeroDeRegistroToolStripMenuItem.Name = "numeroDeRegistroToolStripMenuItem";
            numeroDeRegistroToolStripMenuItem.Size = new Size(180, 22);
            numeroDeRegistroToolStripMenuItem.Text = "Numero de Registro";
            // 
            // dataDeEmissãoToolStripMenuItem
            // 
            dataDeEmissãoToolStripMenuItem.Name = "dataDeEmissãoToolStripMenuItem";
            dataDeEmissãoToolStripMenuItem.Size = new Size(180, 22);
            dataDeEmissãoToolStripMenuItem.Text = "Data de Emissão";
            // 
            // ultilToolStripMenuItem
            // 
            ultilToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculadoraToolStripMenuItem, blocoDeNotasToolStripMenuItem, excelToolStripMenuItem });
            ultilToolStripMenuItem.Name = "ultilToolStripMenuItem";
            ultilToolStripMenuItem.Size = new Size(69, 20);
            ultilToolStripMenuItem.Text = "Utilitários";
            // 
            // calculadoraToolStripMenuItem
            // 
            calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            calculadoraToolStripMenuItem.Size = new Size(155, 22);
            calculadoraToolStripMenuItem.Text = "Calculadora";
            calculadoraToolStripMenuItem.Click += calculadoraToolStripMenuItem_Click;
            // 
            // blocoDeNotasToolStripMenuItem
            // 
            blocoDeNotasToolStripMenuItem.Name = "blocoDeNotasToolStripMenuItem";
            blocoDeNotasToolStripMenuItem.Size = new Size(155, 22);
            blocoDeNotasToolStripMenuItem.Text = "Bloco De Notas";
            blocoDeNotasToolStripMenuItem.Click += blocoDeNotasToolStripMenuItem_Click;
            // 
            // excelToolStripMenuItem
            // 
            excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            excelToolStripMenuItem.Size = new Size(155, 22);
            excelToolStripMenuItem.Text = "Excel";
            excelToolStripMenuItem.Click += excelToolStripMenuItem_Click;
            // 
            // dadosExternosToolStripMenuItem
            // 
            dadosExternosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeCidadesToolStripMenuItem, preçoDosCombustíveisToolStripMenuItem, todosOsCampeõesMundiaisToolStripMenuItem });
            dadosExternosToolStripMenuItem.Name = "dadosExternosToolStripMenuItem";
            dadosExternosToolStripMenuItem.Size = new Size(99, 20);
            dadosExternosToolStripMenuItem.Text = "Dados Externos";
            // 
            // listaDeCidadesToolStripMenuItem
            // 
            listaDeCidadesToolStripMenuItem.Name = "listaDeCidadesToolStripMenuItem";
            listaDeCidadesToolStripMenuItem.Size = new Size(232, 22);
            listaDeCidadesToolStripMenuItem.Text = "Lista de Cidades";
            listaDeCidadesToolStripMenuItem.Click += listaDeCidadesToolStripMenuItem_Click;
            // 
            // preçoDosCombustíveisToolStripMenuItem
            // 
            preçoDosCombustíveisToolStripMenuItem.Name = "preçoDosCombustíveisToolStripMenuItem";
            preçoDosCombustíveisToolStripMenuItem.Size = new Size(232, 22);
            preçoDosCombustíveisToolStripMenuItem.Text = "Preço Dos Combustíveis";
            preçoDosCombustíveisToolStripMenuItem.Click += preçoDosCombustíveisToolStripMenuItem_Click;
            // 
            // todosOsCampeõesMundiaisToolStripMenuItem
            // 
            todosOsCampeõesMundiaisToolStripMenuItem.Name = "todosOsCampeõesMundiaisToolStripMenuItem";
            todosOsCampeõesMundiaisToolStripMenuItem.Size = new Size(232, 22);
            todosOsCampeõesMundiaisToolStripMenuItem.Text = "Todos os Campeões Mundiais";
            todosOsCampeõesMundiaisToolStripMenuItem.Click += todosOsCampeõesMundiaisToolStripMenuItem_Click;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tutoriaisToolStripMenuItem, helpDeskToolStripMenuItem, youtubeToolStripMenuItem, toolStripSeparator1, sobreOSistemaToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // tutoriaisToolStripMenuItem
            // 
            tutoriaisToolStripMenuItem.Name = "tutoriaisToolStripMenuItem";
            tutoriaisToolStripMenuItem.Size = new Size(158, 22);
            tutoriaisToolStripMenuItem.Text = "Tutoriais";
            // 
            // helpDeskToolStripMenuItem
            // 
            helpDeskToolStripMenuItem.Name = "helpDeskToolStripMenuItem";
            helpDeskToolStripMenuItem.Size = new Size(158, 22);
            helpDeskToolStripMenuItem.Text = "Help Desk";
            // 
            // youtubeToolStripMenuItem
            // 
            youtubeToolStripMenuItem.Name = "youtubeToolStripMenuItem";
            youtubeToolStripMenuItem.Size = new Size(158, 22);
            youtubeToolStripMenuItem.Text = "Youtube";
            youtubeToolStripMenuItem.Click += youtubeToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(155, 6);
            // 
            // sobreOSistemaToolStripMenuItem
            // 
            sobreOSistemaToolStripMenuItem.Name = "sobreOSistemaToolStripMenuItem";
            sobreOSistemaToolStripMenuItem.Size = new Size(158, 22);
            sobreOSistemaToolStripMenuItem.Text = "Sobre o Sistema";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, status2 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(72, 17);
            toolStripStatusLabel1.Text = "Pet Limeira |";
            // 
            // status2
            // 
            status2.Name = "status2";
            status2.Size = new Size(118, 17);
            status2.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pet Limeira - Sistema de Gestão";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem tutorToolStripMenuItem;
        private ToolStripMenuItem animalToolStripMenuItem;
        private ToolStripMenuItem veterinariosToolStripMenuItem;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripMenuItem procedimentosToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem tutoriaisToolStripMenuItem;
        private ToolStripMenuItem helpDeskToolStripMenuItem;
        private ToolStripMenuItem youtubeToolStripMenuItem;
        private ToolStripMenuItem sobreOSistemaToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem nomeToolStripMenuItem;
        private ToolStripMenuItem espécieToolStripMenuItem;
        private ToolStripMenuItem raçaToolStripMenuItem;
        private ToolStripMenuItem dToolStripMenuItem;
        private ToolStripMenuItem pesoToolStripMenuItem;
        private ToolStripMenuItem nomeToolStripMenuItem1;
        private ToolStripMenuItem cRMVToolStripMenuItem;
        private ToolStripMenuItem especialidadeToolStripMenuItem;
        private ToolStripMenuItem dataEHoraToolStripMenuItem;
        private ToolStripMenuItem carteiraDeVacinaçãoÚnicaToolStripMenuItem;
        private ToolStripMenuItem numeroDeRegistroToolStripMenuItem;
        private ToolStripMenuItem dataDeEmissãoToolStripMenuItem;
        private ToolStripMenuItem motivoToolStripMenuItem;
        private ToolStripMenuItem observaçõesToolStripMenuItem;
        private ToolStripMenuItem nomeToolStripMenuItem2;
        private ToolStripMenuItem preçoToolStripMenuItem;
        private ToolStripMenuItem quantidadeAplicadaToolStripMenuItem;
        private ToolStripMenuItem valorFinalToolStripMenuItem;
        private ToolStripMenuItem ultilToolStripMenuItem;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
        private ToolStripMenuItem blocoDeNotasToolStripMenuItem;
        private ToolStripMenuItem dadosExternosToolStripMenuItem;
        private ToolStripMenuItem listaDeCidadesToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel status2;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem excelToolStripMenuItem;
        private ToolStripMenuItem preçoDosCombustíveisToolStripMenuItem;
        private ToolStripMenuItem todosOsCampeõesMundiaisToolStripMenuItem;
    }
}