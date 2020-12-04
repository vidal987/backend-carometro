using System.Collections.Generic;
using System.Text.Json.Serialization;

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
        public bool Formado { get; set; }

    }
}
