using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace PetLimeira.services
{
    public class HashSenha
    {
        public static string Gerar(string senha)
        {
            // Transforma a senha em bytes e calcula o hash
            byte[] bytes = Encoding.UTF8.GetBytes(senha);
            byte[] hash = SHA256.HashData(bytes);

            // Converte o hash para uma string hexadecimal
            return Convert.ToHexString(hash);
        }

        // Método para conferir se a senha digitada corresponde ao hash do banco
        public static bool Verificar(string senha, string hashArmazenado)
        {
            // Gera a senha , compara e retorna verdadeiro ou falso
            return Gerar(senha) == hashArmazenado;
        }
    }
}
