namespace PetLimeira.Forms
{
    partial class TutorForm
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
            groupBox1 = new GroupBox();
            btnLimpar = new Button();
            btnExcluir = new Button();
            btnAtualizar = new Button();
            btnAdicionar = new Button();
            txtTelefoneTutor2 = new TextBox();
            txtCelularTutor = new TextBox();
            txtCepTutor = new TextBox();
            txtCidadeTutor = new TextBox();
            txtBairroTutor = new TextBox();
            txtNumeroTutor = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtRuaTutor = new TextBox();
            txtCpfTutor = new TextBox();
            txtNomeTutor = new TextBox();
            dataGridView1 = new DataGridView();
            txtCampoBuscar = new TextBox();
            btnBuscar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLimpar);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnAtualizar);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(txtTelefoneTutor2);
            groupBox1.Controls.Add(txtCelularTutor);
            groupBox1.Controls.Add(txtCepTutor);
            groupBox1.Controls.Add(txtCidadeTutor);
            groupBox1.Controls.Add(txtBairroTutor);
            groupBox1.Controls.Add(txtNumeroTutor);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtRuaTutor);
            groupBox1.Controls.Add(txtCpfTutor);
            groupBox1.Controls.Add(txtNomeTutor);
            groupBox1.Location = new Point(12, 7);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(305, 483);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do Tutor";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 10F);
            btnLimpar.Location = new Point(231, 337);
            btnLimpar.Margin = new Padding(2);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(70, 29);
            btnLimpar.TabIndex = 14;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 10F);
            btnExcluir.Location = new Point(146, 337);
            btnExcluir.Margin = new Padding(2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(81, 29);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Font = new Font("Segoe UI", 11F);
            btnAtualizar.Location = new Point(61, 337);
            btnAtualizar.Margin = new Padding(2);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(81, 29);
            btnAtualizar.TabIndex = 12;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Segoe UI", 11F);
            btnAdicionar.Location = new Point(4, 337);
            btnAdicionar.Margin = new Padding(2);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(53, 29);
            btnAdicionar.TabIndex = 11;
            btnAdicionar.Text = "Add";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtTelefoneTutor2
            // 
            txtTelefoneTutor2.Font = new Font("Segoe UI", 11F);
            txtTelefoneTutor2.Location = new Point(118, 127);
            txtTelefoneTutor2.Margin = new Padding(2);
            txtTelefoneTutor2.Name = "txtTelefoneTutor2";
            txtTelefoneTutor2.PlaceholderText = "Numero do Telefone";
            txtTelefoneTutor2.Size = new Size(146, 27);
            txtTelefoneTutor2.TabIndex = 10;
            txtTelefoneTutor2.TextChanged += txtTelefoneTutor2_TextChanged;
            // 
            // txtCelularTutor
            // 
            txtCelularTutor.Font = new Font("Segoe UI", 11F);
            txtCelularTutor.Location = new Point(118, 100);
            txtCelularTutor.Margin = new Padding(2);
            txtCelularTutor.Name = "txtCelularTutor";
            txtCelularTutor.PlaceholderText = "Numero do Celular";
            txtCelularTutor.Size = new Size(146, 27);
            txtCelularTutor.TabIndex = 9;
            // 
            // txtCepTutor
            // 
            txtCepTutor.Font = new Font("Segoe UI", 11F);
            txtCepTutor.Location = new Point(4, 192);
            txtCepTutor.Margin = new Padding(2);
            txtCepTutor.Name = "txtCepTutor";
            txtCepTutor.PlaceholderText = "CEP";
            txtCepTutor.Size = new Size(73, 27);
            txtCepTutor.TabIndex = 8;
            txtCepTutor.TextChanged += txtCepTutor_TextChanged;
            // 
            // txtCidadeTutor
            // 
            txtCidadeTutor.Font = new Font("Segoe UI", 11F);
            txtCidadeTutor.Location = new Point(4, 162);
            txtCidadeTutor.Margin = new Padding(2);
            txtCidadeTutor.Name = "txtCidadeTutor";
            txtCidadeTutor.PlaceholderText = "Cidade";
            txtCidadeTutor.Size = new Size(73, 27);
            txtCidadeTutor.TabIndex = 7;
            // 
            // txtBairroTutor
            // 
            txtBairroTutor.Font = new Font("Segoe UI", 11F);
            txtBairroTutor.Location = new Point(4, 131);
            txtBairroTutor.Margin = new Padding(2);
            txtBairroTutor.Name = "txtBairroTutor";
            txtBairroTutor.PlaceholderText = "Bairro";
            txtBairroTutor.Size = new Size(73, 27);
            txtBairroTutor.TabIndex = 6;
            // 
            // txtNumeroTutor
            // 
            txtNumeroTutor.Font = new Font("Segoe UI", 11F);
            txtNumeroTutor.Location = new Point(4, 223);
            txtNumeroTutor.Margin = new Padding(2);
            txtNumeroTutor.Name = "txtNumeroTutor";
            txtNumeroTutor.PlaceholderText = "Numero";
            txtNumeroTutor.Size = new Size(71, 27);
            txtNumeroTutor.TabIndex = 5;
            txtNumeroTutor.TextChanged += txtNumeroTutor_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 83);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 4;
            label2.Text = "Telefone para Contato:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 83);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 3;
            label1.Text = "Endereço:";
            label1.Click += label1_Click;
            // 
            // txtRuaTutor
            // 
            txtRuaTutor.Font = new Font("Segoe UI", 11F);
            txtRuaTutor.Location = new Point(4, 100);
            txtRuaTutor.Margin = new Padding(2);
            txtRuaTutor.Name = "txtRuaTutor";
            txtRuaTutor.PlaceholderText = "Rua";
            txtRuaTutor.Size = new Size(73, 27);
            txtRuaTutor.TabIndex = 2;
            // 
            // txtCpfTutor
            // 
            txtCpfTutor.Font = new Font("Segoe UI", 10F);
            txtCpfTutor.Location = new Point(118, 21);
            txtCpfTutor.Margin = new Padding(2);
            txtCpfTutor.Name = "txtCpfTutor";
            txtCpfTutor.PlaceholderText = "CPF";
            txtCpfTutor.Size = new Size(90, 25);
            txtCpfTutor.TabIndex = 1;
            // 
            // txtNomeTutor
            // 
            txtNomeTutor.Font = new Font("Segoe UI", 10F);
            txtNomeTutor.Location = new Point(4, 21);
            txtNomeTutor.Margin = new Padding(2);
            txtNomeTutor.Name = "txtNomeTutor";
            txtNomeTutor.PlaceholderText = "Nome Completo";
            txtNomeTutor.Size = new Size(110, 25);
            txtNomeTutor.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(321, 41);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(546, 541);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtCampoBuscar
            // 
            txtCampoBuscar.Location = new Point(322, 13);
            txtCampoBuscar.Name = "txtCampoBuscar";
            txtCampoBuscar.PlaceholderText = "Buscar por tutores";
            txtCampoBuscar.Size = new Size(123, 23);
            txtCampoBuscar.TabIndex = 2;
            txtCampoBuscar.TextChanged += txtCampoBuscar_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(451, 13);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.TextChanged += btnBuscar_TextChanged;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // TutorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 598);
            Controls.Add(btnBuscar);
            Controls.Add(txtCampoBuscar);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "TutorForm";
            Text = "TutorForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNomeTutor;
        private TextBox txtRuaTutor;
        private TextBox txtCpfTutor;
        private Label label2;
        private Label label1;
        private TextBox txtNumeroTutor;
        private TextBox txtCepTutor;
        private TextBox txtCidadeTutor;
        private TextBox txtBairroTutor;
        private TextBox txtTelefoneTutor2;
        private TextBox txtCelularTutor;
        private Button btnAdicionar;
        private Button btnLimpar;
        private Button btnExcluir;
        private Button btnAtualizar;
        private DataGridView dataGridView1;
        private TextBox txtCampoBuscar;
        private Button btnBuscar;
    }
}