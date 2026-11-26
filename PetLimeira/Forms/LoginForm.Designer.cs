namespace PetLimeira.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtUsuario = new Panel();
            txtLogin = new TextBox();
            label1 = new Label();
            lblTitulo = new Label();
            label3 = new Label();
            lbConta = new LinkLabel();
            label5 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            btnCancelar = new Button();
            btnEntrar = new Button();
            txtSuaSenha = new Panel();
            txtSenha = new TextBox();
            pictureBox1 = new PictureBox();
            txtUsuario.SuspendLayout();
            txtSuaSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.Window;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Controls.Add(txtLogin);
            txtUsuario.Location = new Point(38, 148);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(322, 42);
            txtUsuario.TabIndex = 14;
            // 
            // txtLogin
            // 
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogin.Location = new Point(-1, 3);
            txtLogin.Multiline = true;
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Digite seu usuário";
            txtLogin.Size = new Size(322, 34);
            txtLogin.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 129);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 16;
            label1.Text = "Login";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(106, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(198, 30);
            lblTitulo.TabIndex = 15;
            lblTitulo.Text = "Acesso ao Sistema ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(38, 206);
            label3.Name = "label3";
            label3.Size = new Size(46, 16);
            label3.TabIndex = 23;
            label3.Text = "Senha";
            // 
            // lbConta
            // 
            lbConta.AutoSize = true;
            lbConta.Location = new Point(168, 407);
            lbConta.Name = "lbConta";
            lbConta.Size = new Size(65, 15);
            lbConta.TabIndex = 27;
            lbConta.TabStop = true;
            lbConta.Text = "Criar conta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(36, 407);
            label5.Name = "label5";
            label5.Size = new Size(126, 15);
            label5.TabIndex = 26;
            label5.Text = "Ainda não tem conta ?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(253, 281);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 25;
            label4.Text = "Esqueci minha senha";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.Black;
            checkBox1.Location = new Point(49, 277);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(88, 19);
            checkBox1.TabIndex = 24;
            checkBox1.Text = "Lembre-me";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.MenuHighlight;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = SystemColors.Window;
            btnCancelar.Location = new Point(253, 323);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(126, 35);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = SystemColors.MenuHighlight;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.ForeColor = SystemColors.Window;
            btnEntrar.Location = new Point(38, 323);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(126, 35);
            btnEntrar.TabIndex = 21;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtSuaSenha
            // 
            txtSuaSenha.AccessibleRole = AccessibleRole.MenuPopup;
            txtSuaSenha.BackColor = SystemColors.Window;
            txtSuaSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSuaSenha.Controls.Add(txtSenha);
            txtSuaSenha.Location = new Point(38, 225);
            txtSuaSenha.Name = "txtSuaSenha";
            txtSuaSenha.Size = new Size(322, 42);
            txtSuaSenha.TabIndex = 28;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(-1, 3);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Sua senha";
            txtSenha.Size = new Size(322, 22);
            txtSenha.TabIndex = 1;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(163, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 444);
            Controls.Add(pictureBox1);
            Controls.Add(txtSuaSenha);
            Controls.Add(label3);
            Controls.Add(lbConta);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(checkBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnEntrar);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Controls.Add(txtUsuario);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            txtUsuario.ResumeLayout(false);
            txtUsuario.PerformLayout();
            txtSuaSenha.ResumeLayout(false);
            txtSuaSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel txtUsuario;
        private TextBox txtLogin;
        private Label label1;
        private Label lblTitulo;
        private Label label3;
        private LinkLabel lbConta;
        private Label label5;
        private Label label4;
        private CheckBox checkBox1;
        private Button btnCancelar;
        private Button btnEntrar;
        private Panel txtSuaSenha;
        private TextBox txtSenha;
        private PictureBox pictureBox1;
    }
}