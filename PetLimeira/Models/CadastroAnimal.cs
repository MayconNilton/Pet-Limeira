using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetLimeira.Models
{
    [Table("cadastro_animais")]
    public class CadastroAnimal
    {
        [Key]
        [Column("id")]
        public int IdAnimal { get; set; }

        [Column("data")]
        public DateTime? Data { get; set; }

        [Column("hora")]
        public TimeSpan? Hora { get; set; }

        [Column("animal")]
        public int? Animal { get; set; }

        [Column("tutor")]
        public int? Tutor { get; set; }
    }
}
