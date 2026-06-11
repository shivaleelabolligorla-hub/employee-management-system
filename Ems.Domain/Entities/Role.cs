namespace EMS.Domain.Entities;

public class Role
{
    public int Id { get; set; }

    public string RoleName { get; set; } = string.Empty;
    public ICollection<User> Users = new List<User>();
}