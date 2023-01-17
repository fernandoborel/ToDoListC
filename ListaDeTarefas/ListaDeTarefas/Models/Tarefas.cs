using System;

namespace ListaTarefas.Models
{
    public class Tarefas
    {
        public int TarefasId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public string Nivel { get; set; }
    }
}
