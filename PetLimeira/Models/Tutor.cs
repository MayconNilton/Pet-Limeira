using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetLimeira.Models
{
    [Table("tutores")]
    public class Tutor
    {
        [Key]
        [Column("id_tutor")]
        public int IdTutor { get; set; }

        [Column("nome")]
        public string Nome { get; set; }
    }
}
