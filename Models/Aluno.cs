using App.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;

namespace App.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public DateTime DataNasc { get; set; }

        public int IdTurma { get; set; }
        [JsonIgnore]
        public Turma Turma { get; set; }
        public ICollection<Ocorrencia> Ocorrencias { get; set; }
    }
}
