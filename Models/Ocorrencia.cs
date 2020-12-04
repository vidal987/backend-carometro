using System;
using System.Text.Json.Serialization;

namespace App.Models
{
    public class Ocorrencia
    {   
        public int Id { get;  set; }
        public DateTime DataCriacao { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public string CriadoPor { get; set; }
        public int IdAluno { get; set; }
        [JsonIgnore]    
        public Aluno Aluno { get; set; }


    }
}

