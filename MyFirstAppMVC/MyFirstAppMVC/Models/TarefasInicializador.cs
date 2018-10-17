using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyFirstAppMVC.Models
{
    public class TarefasInicializador : DropCreateDatabaseIfModelChanges<TarefaContexto>
    {
        protected override void Seed(TarefaContexto context)
        {
            var listas = new List<Lista> {
                new Lista {id =1, Nome = "Treinamento Sefaz", Ativa =1}
            };

            listas.ForEach(s => context.Listas.Add(s));
            context.SaveChanges();

            var tarefas = new List<Tarefa> {
                new Tarefa { TarefaId = 1, Nome = "1ª Tarefa", Ativa = 1, Concluida = 0 },
                new Tarefa { TarefaId = 2, Nome = "2ª Tarefa", Ativa = 1, Concluida = 0 }
            };

            tarefas.ForEach(t => context.Tarefas.Add(t));
            context.SaveChanges();

            var usuarios = new List<Usuario> {
                new Usuario { Id = 1 , Nome = "1º Usuário" , Email = "usuario1@usuarios.com.br", Senha = "123456", Ativo = 1},
                new Usuario { Id = 2 , Nome = "2º Usuário" , Email = "usuario2@usuarios.com.br", Senha = "123456", Ativo = 1},
                new Usuario { Id = 3 , Nome = "3º Usuário" , Email = "usuario3@usuarios.com.br", Senha = "123456", Ativo = 1}
            };

            usuarios.ForEach(u => context.Usuarios.Add(u));
            context.SaveChanges();
        }

    }
}