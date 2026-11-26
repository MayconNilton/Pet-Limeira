namespace PetLimeira.Forms
{
    partial class AnimalForm
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            btnLimpar = new Button();
            btnExcluir = new Button();
            btnAtualizar = new Button();
            btnAdicionar = new Button();
            cmbTutor = new ComboBox();
            cmbAnimal = new ComboBox();
            dtpHora = new DateTimePicker();
            dtpData = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(353, 15);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(528, 440);
            dataGridView1.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpData);
            groupBox1.Controls.Add(dtpHora);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnLimpar);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnAtualizar);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(cmbTutor);
            groupBox1.Controls.Add(cmbAnimal);
            groupBox1.Location = new Point(12, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 392);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastro de Animais";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 106);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 16;
            label2.Text = "Tutor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 55);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 15;
            label1.Text = "Animal";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(241, 346);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(70, 23);
            btnLimpar.TabIndex = 14;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(165, 346);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(70, 23);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(78, 346);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(70, 23);
            btnAtualizar.TabIndex = 12;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(6, 346);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(66, 23);
            btnAdicionar.TabIndex = 11;
            btnAdicionar.Text = "Add";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // cmbTutor
            // 
            cmbTutor.FormattingEnabled = true;
            cmbTutor.Location = new Point(6, 124);
            cmbTutor.Name = "cmbTutor";
            cmbTutor.Size = new Size(140, 23);
            cmbTutor.TabIndex = 1;
            // 
            // cmbAnimal
            // 
            cmbAnimal.FormattingEnabled = true;
            cmbAnimal.Location = new Point(6, 73);
            cmbAnimal.Name = "cmbAnimal";
            cmbAnimal.Size = new Size(140, 23);
            cmbAnimal.TabIndex = 0;
            // 
            // dtpHora
            // 
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(0, 217);
            dtpHora.Name = "dtpHora";
            dtpHora.Size = new Size(200, 23);
            dtpHora.TabIndex = 17;
            // 
            // dtpData
            // 
            dtpData.Location = new Point(0, 172);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(200, 23);
            dtpData.TabIndex = 18;
            // 
            // AnimalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 467);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "AnimalForm";
            Text = "animalForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private ComboBox cmbAnimal;
        private ComboBox cmbTutor;
        private Button btnAdicionar;
        private Button btnExcluir;
        private Button btnAtualizar;
        private Button btnLimpar;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpData;
        private DateTimePicker dtpHora;
    }
}