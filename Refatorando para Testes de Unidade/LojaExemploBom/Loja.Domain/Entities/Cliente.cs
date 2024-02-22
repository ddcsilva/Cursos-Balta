namespace Loja.Domain.Entities;

/// <summary>
/// Entidade que representa um cliente
/// </summary>
public class Cliente : BaseEntity
{
    /// <summary>
    /// Construtor que inicializa as propriedades Nome e Email
    /// </summary>
    /// <param name="nome"></param>
    /// <param name="email"></param>
    public Cliente(string nome, string email)
    {
        Nome = nome;
        Email = email;
    }

    // É uma boa prática criar propriedades somente leitura para as entidades
    // Isso evita que as propriedades sejam alteradas após a criação da entidade
    public string Nome { get; private set; }
    public string Email { get; private set; }
}
