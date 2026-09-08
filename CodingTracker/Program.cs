using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;

var configurationBuilder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false);

IConfiguration configuration = configurationBuilder.Build();

var connectionStringSqlite = configuration.GetConnectionString("CodingTracker");

using (var connection = new SqliteConnection(connectionStringSqlite))
{
    connection.Open();
    
}