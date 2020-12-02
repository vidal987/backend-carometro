using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace App.Models
{
    public class Ocorrencia
    {   
        public int Id { get;  set; }
        public DateTime DataCriacao { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }

        public int IdAluno { get; set; }
        [JsonIgnore]    
        public Aluno Aluno { get; set; }


    }
}

