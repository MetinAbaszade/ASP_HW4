using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ASP_HW4.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var conn = "Data Source=METIN-ABASZADE;Initial Catalog=TeacherDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
builder.Services.AddDbContext<TeacherContext>(options =>
    options.UseSqlServer(conn));

builder.Services.AddRazorPages()
    .AddRazorPagesOptions(options =>
    {

        options.Conventions.AddPageRoute("/Teacher/Index", "");

    });


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

app.UseEndpoints(endpoints => { endpoints.MapRazorPages(); });

app.Run();

