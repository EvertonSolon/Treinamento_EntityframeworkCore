using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Switch.Domain.Entities;
using Switch.Domain.Enums;
using Switch.Infra.Data.Context;


IConfigurationBuilder builder = new ConfigurationBuilder()
                                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
IConfigurationRoot configuration = builder.Build();

var optionsBuilder = new DbContextOptionsBuilder<SwitchContext>();
optionsBuilder.UseLazyLoadingProxies()
            .UseSqlServer(configuration.GetConnectionString("SwitchDB"),
             b => b.MigrationsAssembly(typeof(SwitchContext).Assembly.FullName));


var usuario = new Usuario { 
                            Nome = "User 1", 
                            SobreNome = "SobrenomeUser",
                            Email = "user@teste.com",
                            Senha = "abc123",
                            DataNascimento = DateTime.Now.AddYears(-43),
                            Sexo = SexoEnum.Masculino,
                            UrlFoto = @"c:\temp"
                            };
try
{
    using (var dbcontext = new SwitchContext(optionsBuilder.Options))
    {
        dbcontext.Usuarios.Add(usuario);
        dbcontext.SaveChanges();
    }
    
    Console.WriteLine("Sucesso ao inserir os dados!");
}
catch (Exception ex)
{
    Console.WriteLine(ex.InnerException.Message);
    Console.ReadKey();
}

