namespace hello_asp_identity.Contracts.V1.Responses;

public record UserResponse(
    int Id,
    string Username,
    string Email,
    int Age,
    bool EmailConfirmed,
    bool Suspended,
    string CreatedOn,
    string UpdatedOn,
    string UpdaterId
);