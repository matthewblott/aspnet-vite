var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddSpaStaticFiles(configuration => {
  configuration.RootPath = "Frontend/dist";
});
var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

const string spaPath = "/dist";

if (app.Environment.IsDevelopment())
{
  app.MapWhen(y => y.Request.Path.StartsWithSegments(spaPath), client =>
  {
    client.UseSpa(spa =>
    {
      spa.UseProxyToSpaDevelopmentServer("http://localhost:5173/");
    });
  }); 
}
app.MapFallbackToFile("index.html");
app.Run();
