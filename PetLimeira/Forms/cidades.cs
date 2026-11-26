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
    public partial class cidades : Form
    {
        // Criar uma propriedade
        // DataTable é uma tabela em memória. Só existe dentro do sistema.
        private DataTable tabelaDeDados = new DataTable();

        public cidades()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            // definir o caminho e o nome do arquivo de dados
            string caminho = "C:\\Users\\guilherme.zsguerrero\\Documents\\dados\\cidades.csv";

            // ler o texto do arquivo
            var texto = new StreamReader(caminho, Encoding.GetEncoding("ISO-8859-1"));

            // percorrer a 1 linha para identificar o cabeçalho
            // coluna é a variavel que recebera os nomes das coluunas
            // ReadLine faz parte da classe StreamReader e le uma linha por vez
            // Split divide o texto em um determinado caracter, aqui, o ;

            foreach (string coluna in texto.ReadLine().Split(";"))
            {
                tabelaDeDados.Columns.Add(coluna);
            }

            // Demais colunas
            string linha;
            while ((linha = texto.ReadLine()) != null)
            {
                {
                    // Adicionar linha por linha na tabela de dados
                    // Dividindo a linha em colunas usando o Split
                    tabelaDeDados.Rows.Add(linha.Split(";"));
                }
                // Incluir a tabela de dados no GridView
                dataGridView1.DataSource = tabelaDeDados;

            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            // Validar se o datatable ja esta carregado
            if (tabelaDeDados == null || tabelaDeDados.Rows.Count == 0)
            {
                Mensagem.Aviso("Primeiro, clique no botão Carregar Dados");
                return;  // Interrompe a execução do método
            }

            // Criar uma lista que sera usada no filtro
            var filtro = new List<string>();

            // Aplicar o filtro de UF
            if (cmbUf.SelectedIndex > 0) // Indica que tem UF selecionado
            {
                filtro.Add($"uf = '{cmbUf.SelectedItem}'");
            }

            // Recuperar valores do textBox e converter para inteiro
            int.TryParse(txtMinimo.Text, out int populacaoMin);
            int.TryParse(txtMaximo.Text, out int populacaoMax);

            // Verificar se a conversão para int deu certo
            if (populacaoMin > 0 && populacaoMax > 0)
            {
                filtro.Add($"pop2021 >= {populacaoMin}");
                filtro.Add($"pop2021 <= {populacaoMax}");
            }

            // Incluir o filtro no DataTable
            tabelaDeDados.DefaultView.RowFilter = string.Join(" AND ", filtro);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}


