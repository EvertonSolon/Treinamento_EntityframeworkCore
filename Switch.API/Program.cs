using Microsoft.EntityFrameworkCore;
using Switch.Infra.Data.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SwitchContext>(options =>
            options.UseLazyLoadingProxies()
            .UseSqlServer(builder.Configuration.GetConnectionString("SwitchDB"),
             b => b.MigrationsAssembly(typeof(SwitchContext).Assembly.FullName)));

builder.Services.AddMvcCore();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
