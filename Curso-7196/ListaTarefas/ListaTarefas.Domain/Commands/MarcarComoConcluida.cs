using Flunt.Notifications;
using Flunt.Validations;
using ListaTarefas.Domain.Commands.Contracts;

namespace ListaTarefas.Domain.Commands;

public class MarcarComoConcluida : Notifiable, ICommand
{
    public MarcarComoConcluida() { }

    public MarcarComoConcluida(Guid id, string usuario)
    {
        Id = id;
        Usuario = usuario;
    }

    public Guid Id { get; set; }
    public string? Usuario { get; set; }

    public void Validate()
    {
        AddNotifications(
            new Contract()
                .Requires()
                .HasMinLen(Usuario, 6, "Usuario", "Usuário inválido!")
        );
    }
}