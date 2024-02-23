using Microsoft.AspNetCore.SignalR;
using SocketSignalR;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddSignalR();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

// Configuraci�n de CORS
app.UseCors(builder =>
{
    builder.AllowAnyOrigin() // Permitir solicitudes desde cualquier origen
           .AllowAnyMethod() // Permitir cualquier m�todo HTTP
           .AllowAnyHeader(); // Permitir cualquier encabezado HTTP
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.MapHub<SocketHub>("/SocketHub");

app.Run();


