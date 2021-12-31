namespace hello_asp_identity.Contracts.V1;

public static class ApiRoutes
{
    public const string Root = "api";

    public const string Version = "v1";

    public const string Base = Root + "/" + Version;

    // ressources
    public const string IdentityRessource = Base + "/" + "identity";
    public const string UserRessource = Base + "/" + "users";

    public static class Identity
    {

        public const string Register = IdentityRessource + "/register";
        public const string RegisterConfirm = IdentityRessource + "/register_confirm";
        public const string Login = IdentityRessource + "/login";
        public const string RefreshAccessToken = IdentityRessource + "/refresh";
        public const string PasswordReset = IdentityRessource + "/password_reset";
        public const string PasswordResetConfirm = IdentityRessource + "/password_reset";
        public const string PasswordUpdate = IdentityRessource + "/password_update";
        public const string UsernameUpdate = IdentityRessource + "/username_update";
        public const string EmailUpdate = IdentityRessource + "/email_update";
        public const string EmailUpdateConfirm = IdentityRessource + "/email_update";

    }

    public static class User
    {

        public const string GetAll = UserRessource;
        public const string Get = UserRessource + "/{userId}";
        public const string Update = UserRessource + "/{userId}";
        public const string Delete = UserRessource + "/{userId}";
    }
}