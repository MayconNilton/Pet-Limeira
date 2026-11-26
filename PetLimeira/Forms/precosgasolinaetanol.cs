using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PetLimeira.Forms
{
    public partial class precosgasolinaetanol : Form
    {
        // Criar uma propriedade
        // DataTable é uma tabela em memória. Só existe dentro do sistema.
        private DataTable tabelaDeDados2 = new DataTable();
        public precosgasolinaetanol()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            // definir o caminho e o nome do arquivo de dados
            string caminho = "C:\\Users\\guilherme.zsguerrero\\Documents\\dados\\precos-gasolina-etanol.csv";

            // ler o texto do arquivo
            var texto = new StreamReader(caminho, Encoding.GetEncoding("ISO-8859-1"));

            // percorrer a 1 linha para identificar o cabeçalho
            // coluna é a variavel que recebera os nomes das coluunas
            // ReadLine faz parte da classe StreamReader e le uma linha por vez
            // Split divide o texto em um determinado caracter, aqui, o ;

            foreach (string coluna in texto.ReadLine().Split(";"))
            {
                tabelaDeDados2.Columns.Add(coluna);
            }

            // Demais colunas
            string linha;
            while ((linha = texto.ReadLine()) != null)
            {
                {
                    // Adicionar linha por linha na tabela de dados
                    // Dividindo a linha em colunas usando o Split
                    tabelaDeDados2.Rows.Add(linha.Split(";"));
                }
                // Incluir a tabela de dados no GridView
                dataGridView1.DataSource = tabelaDeDados2;

            }
        }
    }
}
