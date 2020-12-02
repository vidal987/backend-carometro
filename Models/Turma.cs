using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace App.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [JsonIgnore]
        public Curso Curso { get; set; }
        public int IdCurso { get; set; }
        public ICollection<Aluno> Alunos { get; set; }

    }
}
