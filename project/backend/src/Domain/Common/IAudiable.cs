namespace Domain.Common;

public interface IAudiable
{
    public DateTime CreatedAt { get;}
    public DateTime? UpdatedAt { get; set; }
}
