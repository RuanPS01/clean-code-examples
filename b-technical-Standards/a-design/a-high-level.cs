//MeuProjeto.Domain
public static class Settings {
    public static string ConnectionString { get; set; }
}


//MeuProjeto.Api
public Startup(IConfiguration configuration)
{
    Configuration = configuration;
    Settings.ConnectionString = Configuration.GetConnectionString("connectionString");
}


//MeuProjeto.Infra
using(var connection = new SqlConnection(Settings.ConnectionString)) {
    ...
}