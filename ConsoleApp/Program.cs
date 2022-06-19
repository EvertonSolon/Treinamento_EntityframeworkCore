using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Switch.Domain.Entities;
using Switch.Domain.Enums;
using Switch.Infra.CrossCutting.Logging;
using Switch.Infra.Data.Context;


IConfigurationBuilder builder = new ConfigurationBuilder()
                                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
IConfigurationRoot configuration = builder.Build();

var optionsBuilder = new DbContextOptionsBuilder<SwitchContext>();
optionsBuilder.UseLazyLoadingProxies()
            .UseSqlServer(configuration.GetConnectionString("SwitchDB"),
             b => b.MigrationsAssembly(typeof(SwitchContext).Assembly.FullName).MaxBatchSize(100));

Usuario CriarUsuario(string nome)
{


    var usuario = new Usuario
    {
        Nome = nome,
        SobreNome = "SobrenomeUser",
        Email = "user@teste.com",
        Senha = "abc123",
        DataNascimento = DateTime.Now.AddYears(-43),
        Sexo = SexoEnum.Masculino,
        UrlFoto = @"c:\temp"
    };

    return usuario;
}

var usuario1 = CriarUsuario("user teste 1");
//var usuario2 = CriarUsuario("user teste 2");
//var usuario3 = CriarUsuario("user teste 3");
//var usuario4 = CriarUsuario("user teste 4");
//var usuario5 = CriarUsuario("user teste 5");
//var usuario6 = CriarUsuario("user teste 6");

try
{
    using (var dbcontext = new SwitchContext(optionsBuilder.Options))
    {
        //dbcontext.GetService<ILoggerFactory>().AddProvider(new Logger());
        dbcontext.Usuarios.Add(usuario1);
        dbcontext.SaveChanges();
        
    }
    
    Console.WriteLine("Sucesso ao inserir os dados!");
}
catch (Exception ex)
{
    Console.WriteLine(ex.InnerException.Message);
    Console.ReadKey();
}

