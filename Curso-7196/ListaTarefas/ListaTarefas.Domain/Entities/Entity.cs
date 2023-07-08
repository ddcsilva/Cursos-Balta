namespace ListaTarefas.Domain.Entities;

/// <summary>
/// Classe base para as entidades.
/// </summary>
public abstract class Entity: IEquatable<Entity>
{
    public Entity()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; private set; }

    public bool Equals(Entity? other)
    {
        return Id == other?.Id;
    }
}