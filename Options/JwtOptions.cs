namespace hello_asp_identity.Options;

public class JwtOptions
{
    public const string SectionName = "Jwt";
    public string Secret { get; set; }
    public TimeSpan TokenLifetime { get; set; }
}