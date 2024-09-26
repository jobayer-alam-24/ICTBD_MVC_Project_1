var builder = WebApplication.CreateBuilder(args);

//Service Injection
builder.Services.AddControllersWithViews();
var app = builder.Build();
//Middleware Section
app.UseRouting();
app.MapControllerRoute(
    name: "students",
    pattern: "{controller=students}/{action=info}/{id?}"
);


app.MapGet("/", () => "Hello! I am Jobayer. Welcome on Dashboard.");
app.Run();
