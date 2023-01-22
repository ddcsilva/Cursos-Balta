using System;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class CriarComandoTodo : IComando
    {
        public CriarComandoTodo() { }

        public CriarComandoTodo(string titulo, DateTime data, string usuario)
        {
            Titulo = titulo;
            Data = data;
            Usuario = usuario;
        }

        public string Titulo { get; set; }
        public DateTime Data { get; set; }
        public string Usuario { get; set; }

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
