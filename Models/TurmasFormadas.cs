using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace App.Models
{
    public class TurmasFormadas
    {
        public int TurmaId{ get; set; }
        [JsonIgnore]
        public ICollection<Turma> Turmas { get; set; }


    }
}
