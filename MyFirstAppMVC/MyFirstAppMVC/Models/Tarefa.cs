﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFirstAppMVC.Models
{
    public class Tarefa
    {
        [Key]
        public int TarefaId { get; set; }
        public string Nome { get; set; }
        public int Concluida { get; set; }
        public virtual int Ativa { get; set; }
        public virtual Lista lista { get; set; }
        public int ListaId { get; set; }
    }
}