using SqlSugar.IOC;

namespace Tally.Api;

// ReSharper disable once ClassNeverInstantiated.Global
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        #region SqlSugar IOC

        builder.Configuration
            .AddJsonFile("appsettings.json", true, false)
            .AddJsonFile("appsettings.private.json", true, false);
        string? connectionString = builder.Configuration.GetConnectionString("SqlServer");

        SugarIocServices.AddSqlSugar(
            new IocConfig
            {
                ConnectionString = connectionString,
                DbType = IocDbType.SqlServer,
                IsAutoCloseConnection = true // 自动释放
            }
        );
        Console.WriteLine(connectionString);

        #endregion

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}