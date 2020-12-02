using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Periodo { get; set; }

        public ICollection<Turma> Turmas { get; set; }
    }
}
