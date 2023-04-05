namespace Authorization.Entities;

public abstract class BaseEntities
{
    protected BaseEntities()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
}