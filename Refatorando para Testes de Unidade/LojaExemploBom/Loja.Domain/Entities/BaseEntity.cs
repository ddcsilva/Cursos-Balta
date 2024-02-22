using Flunt.Notifications;

namespace Loja.Domain.Entities;

/// <summary>
/// Classe base para as entidades
/// </summary>
public class BaseEntity : Notifiable
{
    /// <summary>
    /// Construtor que inicializa a propriedade Id com um novo Guid
    /// </summary>
    public BaseEntity()
    {
        Id = Guid.NewGuid();
    }

    // É uma boa prática criar propriedades somente leitura para as entidades
    // Isso evita que as propriedades sejam alteradas após a criação da entidade
    public Guid Id { get; private set; }
}