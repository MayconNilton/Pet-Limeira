using PetLimeira.Data;
using PetLimeira.Models;
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
    public partial class AnimalForm : Form
    {
        public AnimalForm()
        {
            InitializeComponent();
            CarregarCombos();
            ListarAnimais();

        }

        private void CarregarCombos()
        {
            // Carregar os combos de animais e tutores
            var banco = new BancoContext();

            cmbAnimal.DisplayMember = "Nome";
            cmbAnimal.ValueMember = "IdAnimal";
            cmbAnimal.DataSource = banco.ControleAnimais.ToList();

            cmbTutor.DisplayMember = "Nome";
            cmbTutor.ValueMember = "IdTutor";
            cmbTutor.DataSource = banco.ControleTutores.ToList();

        }

        private void ListarAnimais()
        {
            var banco = new BancoContext();

            var animais =
                from a in banco.ControleAnimais
                join t in banco.ControleTutores on a.Tutor equals t.IdTutor
                select new
                {
                    a.IdAnimal,
                    a.Data,
                    a.Hora,
                    Animal = a.Animal,
                    Tutor = t.Nome
                };
            dataGridView1.DataSource = animais.ToList();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                return;
            }

            var banco = new BancoContext();

            var cadastroAnimal = new CadastroAnimal
            {
                Data = dtpData.Value.Date,
                Hora = dtpHora.Value.TimeOfDay,
                Animal = (int)cmbAnimal.SelectedValue,
                Tutor = (int)cmbTutor.SelectedValue
            };

            banco.ControleCadastroAnimal.Add(cadastroAnimal);
            banco.SaveChanges();
            
            ListarAnimais();

            Mensagem.Aviso("Dados gravados com sucesso!");
        }

        private bool Validar()  
        {
            int idAnimal = (int)cmbAnimal.SelectedValue;
            int idTutor = (int)cmbTutor.SelectedValue;

            var banco = new BancoContext();
            bool JaExiste = banco.ControleAnimais.Any(
            a => 
            a.IdAnimal == idAnimal &&
            a.Tutor == idTutor);

            if (JaExiste)
            {
                Mensagem.Aviso("Já existe um cadastro com este animal e tutor");
                return false;

            } 

            return true;
        }
    }
}
