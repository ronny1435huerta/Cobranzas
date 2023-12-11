using Cobranzas.Models.Interface;
using Cobranzas.Models.Repository;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.CookiePolicy;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IUsuario, UsuarioRepositorio>();
builder.Services.AddSingleton<IBase_General, Base_GeneralRepositorio>();
builder.Services.AddSingleton<IPrincipal, PrincipalRepositorio>();
builder.Services.AddSingleton<IDemanda_Interna, Demanda_InternaRepositorio>();
builder.Services.AddSingleton<ITipo_impulso, Tipo_impulsoRepositorio>();
builder.Services.AddSingleton<IStatus_arbitraje, Status_arbitrajeRepositorio>();
builder.Services.AddSingleton<IStatus_judicial, Status_judicialRepositorio>();
builder.Services.AddSingleton<IStatus_poder_judicial, Status_poder_judicialRepositorio>();
builder.Services.AddSingleton<IApoderado, ApoderadoRepositorio>();
builder.Services.AddSingleton<IPasos_cobranza, Pasos_cobranzasRepositorio>();
builder.Services.AddSingleton<IDemanda_Judicial, Demanda_JudicialRepositorio>();


//Configurar autenticacion....
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(option => {
        //ruta pagina de logueo..
        option.LoginPath = "/Autenticacion/Logueo";
        //ruta mensaje para acceso no autorizado
        option.AccessDeniedPath = "/Autenticacion/Mensaje";

    });//fin de la configuracion para autenticacion...
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("RequireLoggedIn", policy => policy.RequireAuthenticatedUser());
});
//limitamos el envío de las cookies
builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.MinimumSameSitePolicy = SameSiteMode.Strict;
    options.HttpOnly = HttpOnlyPolicy.Always;

});
// Configurar la licencia de QuestPDF
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Autenticacion}/{action=Logueo}");

app.Run();
