namespace Acme.PhamacyManagement;

public static class PhamacyManagementDbProperties
{
    public static string DbTablePrefix { get; set; } = "PhamacyManagement";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "PhamacyManagement";
}
