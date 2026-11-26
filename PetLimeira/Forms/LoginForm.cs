using PetLimeira.Data;
using PetLimeira.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PetLimeira.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            // CriarHashParaOBanco();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // validar os campos vazios
            if (txtLogin.Text.Trim() == "")
            {
                Mensagem.Aviso("Informe o login");
                txtLogin.Focus();
                return;
            }
            if (txtSenha.Text.Trim() == "")
            {
                Mensagem.Aviso("Informe a senha");
                txtSenha.Focus();
                return;
            }

            // autenticar o usuario no banco de dados
            var banco = new BancoContext();

            // buscar no banco de dados o usuario com o login e senha informados
            var usuario = banco.ControleUsuario
                .FirstOrDefault(novoDoBanco =>
                novoDoBanco.Login == txtLogin.Text.Trim());


            // o codigo acima irá retornar um objeto usuario do banco 
            // com isso poderemo usar o usuario id, usuario.login e usuario.senha
            // Na comparação abaixo , chamo o métedo verificar e passo com parámetro
            // a senha digitada e a senha retornada do banco
            if (usuario == null || !HashSenha.Verificar(txtSenha.Text, usuario.Senha))
            {
                Mensagem.Aviso("Usuario ou senha Invalidos");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void CriarHashParaOBanco()
        {
            var minhahash = HashSenha.Gerar("123456");


            var banco = new BancoContext();
            var admin = new Usuario
            {
                Login = "maycon",
                Senha = minhahash
            };
            banco.ControleUsuario.Add(admin);
            banco.SaveChanges();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
