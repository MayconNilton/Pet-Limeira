namespace PetLimeira.Forms
{
    partial class precosgasolinaetanol
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
            btnCarregar = new Button();
            label1 = new Label();
            cmbUf = new ComboBox();
            btnFiltrar = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCarregar
            // 
            btnCarregar.Location = new Point(12, 18);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(96, 23);
            btnCarregar.TabIndex = 0;
            btnCarregar.Text = "Carregar Dados";
            btnCarregar.UseVisualStyleBackColor = true;
            btnCarregar.Click += btnCarregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 21);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 1;
            label1.Text = "Filtrar Dados";
            // 
            // cmbUf
            // 
            cmbUf.FormattingEnabled = true;
            cmbUf.Items.AddRange(new object[] { "TODOS", "SP", "MG", "PR", "RJ", "BA", "RS", "GO" });
            cmbUf.Location = new Point(198, 18);
            cmbUf.Name = "cmbUf";
            cmbUf.Size = new Size(121, 23);
            cmbUf.TabIndex = 2;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(334, 17);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(86, 23);
            btnFiltrar.TabIndex = 3;
            btnFiltrar.Text = "Filtrar dados";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(772, 375);
            dataGridView1.TabIndex = 4;
            // 
            // precosgasolinaetanol
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnFiltrar);
            Controls.Add(cmbUf);
            Controls.Add(label1);
            Controls.Add(btnCarregar);
            Name = "precosgasolinaetanol";
            Text = "precosgasolinaetanol";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCarregar;
        private Label label1;
        private ComboBox cmbUf;
        private Button btnFiltrar;
        private DataGridView dataGridView1;
    }
}