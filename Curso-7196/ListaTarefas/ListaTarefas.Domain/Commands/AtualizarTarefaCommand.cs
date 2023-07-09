using Flunt.Notifications;
using Flunt.Validations;
using ListaTarefas.Domain.Commands.Contracts;

namespace ListaTarefas.Domain.Commands;

/// <summary>
/// Comando para atualizar uma tarefa.
/// </summary>
public class AtualizarTarefaCommand : Notifiable, ICommand
{
    public AtualizarTarefaCommand() { }

    public AtualizarTarefaCommand(Guid id, string titulo, string usuario)
    {
        Id = id;
        Titulo = titulo;
        Usuario = usuario;
    }

    public Guid Id { get; set; }
    public string Titulo { get; set; }
    public string Usuario { get; set; }

    public void Validate()
    {
        AddNotifications(
            new Contract()
                .Requires()
                .HasMinLen(Titulo, 3, "Titulo", "Por favor, descreva melhor esta tarefa!")
                .HasMinLen(Usuario, 6, "Usuario", "Usuário inválido!")
        );
    }
}