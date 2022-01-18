using Microsoft.AspNetCore.Identity;

namespace hello_asp_identity.Entities;

public class AppUser : IdentityUser<Guid>
{
    public int Age { get; set; }
    public string ConfirmedCode { get; set; }
    public bool Suspended { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime? UpdatedOn { get; set; }
    public string UpdaterId { get; set; }
    public DateTime? DeletedOn { get; set; }
    public string DeleterId { get; set; }
    public string UnConfirmedEmail { get; set; }

    public virtual ICollection<AppUserRole> UserRoles { get; set; }
}