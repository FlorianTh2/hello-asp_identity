namespace darwin.Contracts.V1.Requests;

public record IdentityEmailUpdateRequest(
    string OldEmail,
    string UnConfirmedEmail
);