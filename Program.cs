using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder()
    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
    .AddJsonFile("appsettings.json")
    .Build();

// Method 1: Get directly
Console.WriteLine(configuration["AppSettings:Title"]);

// Method 2: Get via GetSection method.
var appSettings = configuration.GetSection("AppSettings");
Console.WriteLine(appSettings["Version"]);

// Method 3: Get via GetConnection method for connection string
var mysqlConnString = configuration.GetConnectionString("MySql");
Console.WriteLine($"MySQL Connection String: {mysqlConnString}");
