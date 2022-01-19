namespace hello_asp_identity.Options;

public class SeedOptions
{
    public const string SectionName = "Seeds";

    public AdminOptions AdminOptions { get; set; } = null!;

}

public class AdminOptions
{
    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string AdminRoleName { get; set; } = null!;
}