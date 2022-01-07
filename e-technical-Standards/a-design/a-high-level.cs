//MeuProjeto.Domain
public static class Settings {
    public static string ConnectionString { get; set; }
}


//MeuProjeto.Api
public Startup(IConfiguration configuration)
{
    Settings.ConnectionString = configuration.GetConnectionString("connectionString");
}


//MeuProjeto.Infra
using(var connection = new SqlConnection(Settings.ConnectionString)) {
    ...
}