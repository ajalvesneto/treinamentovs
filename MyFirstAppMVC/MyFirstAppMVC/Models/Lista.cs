using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFirstAppMVC.Models
{
    public class Lista
    {
        [Key]
        public int id { get; set; }
        public string Nome { get; set; }
        public int Ativa { get; set; }
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
        public ICollection<Tarefa> Tarefas { get; set; }
    }
}