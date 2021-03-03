using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;

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

        [Required]
        [Column(TypeName = "longblob")]
        public byte[] Foto { get; set; }
        public int IdTurma { get; set; }
        [JsonIgnore]
        public Turma Turma { get; set; }
        public ICollection<Ocorrencia> Ocorrencias { get; set; }
    }
}
