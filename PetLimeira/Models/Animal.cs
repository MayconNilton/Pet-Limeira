using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetLimeira.Models
{
    [Table("animais")]
    public class Animais
    {
        [Key]
        [Column("id_animal")]
        public int IdAnimal { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

    }
}
