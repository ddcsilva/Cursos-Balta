using Flunt.Notifications;
using Flunt.Validations;
using ListaTarefas.Domain.Commands.Contracts;

namespace ListaTarefas.Domain.Commands;

/// <summary>
/// Comando para criar uma nova tarefa.
/// </summary>
public class CriarTarefaCommand : Notifiable, ICommand
{
    public CriarTarefaCommand() { }

    public CriarTarefaCommand(string titulo, DateTime dataConclusao, string usuario)
    {
        Titulo = titulo;
        DataConclusao = dataConclusao;
        Usuario = usuario;
    }

    public string Titulo { get; set; }
    public DateTime DataConclusao { get; set; }
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
