using System.Data;
using InventoryManagement.Models;
using Microsoft.Data.SqlClient;

namespace InventoryManagement.Data;

public class ProductRepository
{
    private readonly DatabaseConnection _database;

    public ProductRepository(DatabaseConnection database)
    {
        _database = database;
    }

    public async Task<List<Product>> GetAllAsync(string? search = null)
    {
        const string sql = @"
            SELECT ProductId, ProductName, Category, Price, Quantity, Supplier
            FROM   dbo.Products
            WHERE  @Search IS NULL
               OR  ProductName LIKE '%' + @Search + '%'
               OR  Category    LIKE '%' + @Search + '%'
               OR  Supplier    LIKE '%' + @Search + '%'
            ORDER  BY ProductId DESC;";

        var products = new List<Product>();

        await using var connection = _database.Create();
        await using var command = new SqlCommand(sql, connection);

        var searchParameter = command.Parameters.Add("@Search", SqlDbType.NVarChar, 100);
        searchParameter.Value = string.IsNullOrWhiteSpace(search) ? DBNull.Value : search.Trim();

        await connection.OpenAsync();
        await using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            products.Add(ReadProduct(reader));
        }

        return products;
    }

    public async Task<Product?> GetByIdAsync(int id)
    {
        const string sql = @"
            SELECT ProductId, ProductName, Category, Price, Quantity, Supplier
            FROM   dbo.Products
            WHERE  ProductId = @ProductId;";

        await using var connection = _database.Create();
        await using var command = new SqlCommand(sql, connection);
        command.Parameters.Add("@ProductId", SqlDbType.Int).Value = id;

        await connection.OpenAsync();
        await using var reader = await command.ExecuteReaderAsync();
        return await reader.ReadAsync() ? ReadProduct(reader) : null;
    }

    public async Task<int> CreateAsync(Product product)
    {
        const string sql = @"
            INSERT INTO dbo.Products (ProductName, Category, Price, Quantity, Supplier)
            OUTPUT INSERTED.ProductId
            VALUES (@ProductName, @Category, @Price, @Quantity, @Supplier);";

        await using var connection = _database.Create();
        await using var command = new SqlCommand(sql, connection);
        AddProductParameters(command, product);

        await connection.OpenAsync();
        var newId = await command.ExecuteScalarAsync();
        return Convert.ToInt32(newId);
    }

    public async Task<bool> UpdateAsync(Product product)
    {
        const string sql = @"
            UPDATE dbo.Products
            SET    ProductName = @ProductName,
                   Category    = @Category,
                   Price       = @Price,
                   Quantity    = @Quantity,
                   Supplier    = @Supplier
            WHERE  ProductId   = @ProductId;";

        await using var connection = _database.Create();
        await using var command = new SqlCommand(sql, connection);
        command.Parameters.Add("@ProductId", SqlDbType.Int).Value = product.ProductId;
        AddProductParameters(command, product);

        await connection.OpenAsync();
        return await command.ExecuteNonQueryAsync() > 0;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        const string sql = "DELETE FROM dbo.Products WHERE ProductId = @ProductId;";

        await using var connection = _database.Create();
        await using var command = new SqlCommand(sql, connection);
        command.Parameters.Add("@ProductId", SqlDbType.Int).Value = id;

        await connection.OpenAsync();
        return await command.ExecuteNonQueryAsync() > 0;
    }

    private static void AddProductParameters(SqlCommand command, Product product)
    {
        command.Parameters.Add("@ProductName", SqlDbType.NVarChar, 100).Value = product.ProductName;
        command.Parameters.Add("@Category", SqlDbType.NVarChar, 50).Value = product.Category;

        var price = command.Parameters.Add("@Price", SqlDbType.Decimal);
        price.Precision = 18;
        price.Scale = 2;
        price.Value = product.Price;

        command.Parameters.Add("@Quantity", SqlDbType.Int).Value = product.Quantity;
        command.Parameters.Add("@Supplier", SqlDbType.NVarChar, 100).Value = product.Supplier;
    }

    private static Product ReadProduct(SqlDataReader reader)
    {
        return new Product
        {
            ProductId = reader.GetInt32(0),
            ProductName = reader.GetString(1),
            Category = reader.GetString(2),
            Price = reader.GetDecimal(3),
            Quantity = reader.GetInt32(4),
            Supplier = reader.GetString(5)
        };
    }
}
