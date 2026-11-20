using Microsoft.Data.SqlClient;

namespace InventoryManagement.Data;

public class DatabaseConnection
{
    private readonly string _connectionString;

    public DatabaseConnection(IConfiguration configuration)
    {
        var connStr = configuration.GetConnectionString("DefaultConnection")
            ?? throw new InvalidOperationException("DefaultConnection is missing in appsettings.json.");

        if (!OperatingSystem.IsWindows() && connStr.Contains("(localdb)", StringComparison.OrdinalIgnoreCase))
        {
            connStr = "Server=localhost,1433;Database=InventoryDB;User Id=sa;Password=YourStrongPassw0rd123;TrustServerCertificate=True;";
        }

        _connectionString = connStr;
    }

    public SqlConnection Create()
    {
        return new SqlConnection(_connectionString);
    }

    public async Task<bool> CanConnectAsync()
    {
        try
        {
            await using var connection = Create();
            await connection.OpenAsync();
            return true;
        }
        catch (SqlException)
        {
            return false;
        }
    }
}
