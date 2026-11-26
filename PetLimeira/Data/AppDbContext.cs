using Microsoft.EntityFrameworkCore;
using PetLimeira.Models;
using PetLimeira.services;
using System;
using System.Collections.Generic;
using System.Text;
using static System.ComponentModel.Design.ObjectSelectorEditor;
namespace PetLimeira.Data
{
    public class BancoContext : DbContext
    {
        public DbSet<Tutor> ControleTutores { get; set; }
        public DbSet<Usuario> ControleUsuario { get; set; }
        public DbSet<Animais> ControleAnimais { get; set; }
        public DbSet<CadastroAnimal> ControleCadastroAnimal { get; set; }

        // Método para informaçoes do banco
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string conexao = "server=127.0.0.1;port=3306;database=pet_limeira;user=root;";
            // var versao = new MariaDbServerVersion(new Version(8, 0, 0));
            options.UseMySql(conexao, ServerVersion.AutoDetect(conexao));
            // base.OnConfiguring(options);
        }
    }
}