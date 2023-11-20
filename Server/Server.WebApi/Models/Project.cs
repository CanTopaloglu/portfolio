namespace Server.WebApi.Models;

public sealed class Project
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string CoverImageUrl { get; set; } = string.Empty;

}

//public private protected internal
//access modifier - erişim belirleyicisi