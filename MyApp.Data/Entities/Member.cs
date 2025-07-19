namespace MyApp.Data.Entities;

public enum Gender
{
    Male,
    Female,
    ApacheHelicopter,
    NonBinary,
}

public class Member
{
    public Guid Id { get; set; }
    public string GivenName { get; set; }
    public string FamilyName { get; set; }
    public Gender Gender { get; set; }
    public string Email { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}