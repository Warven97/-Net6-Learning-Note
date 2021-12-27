var builder = WebApplication.CreateBuilder(args);

{
    //Nuget“˝»Î£∫
    //1.Log4Net
    //2.Microsoft.Extensions.Logging.Log4Net.AspNetCore
    builder.Logging.AddLog4Net("CfgFile/log4net.config");
}

// Add services to the container.
builder.Services.AddControllersWithViews();

{
    builder.Services.AddSession();
}


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseSession();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
