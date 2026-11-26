using System;
using System.Collections.Generic;
using System.Text;

namespace PetLimeira.services
{
    internal class Mensagem
    {
        // Método para Aviso
        public static void Aviso(string msg)
        {
            MessageBox.Show(
             msg,
             "Aviso",
             MessageBoxButtons.OK,
             MessageBoxIcon.Warning);
        }

        // Método para Erro
        public static void Erro(string msg)
        {
            MessageBox.Show(
             msg,
             "Erro",
             MessageBoxButtons.OK,
             MessageBoxIcon.Error);
        }

        public static DialogResult confirmacao(string msg)
        {
            return MessageBox.Show(
                msg,
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
        }
    }
}
