using ProxyKit;


var builder = WebApplication.CreateBuilder(args);
var  MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddResponseCompression();
builder.Services.AddProxy();

// Cors
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy  =>
                      {
                          policy.WithOrigins("http://localhost:3000")
                                 .AllowAnyHeader()
                                 .AllowAnyMethod();
                      });
});


var app = builder.Build();

app.UseResponseCompression();
app.UseStaticFiles();
app.UseRouting();
// TODO: Setup auth here.
app.MapRazorPages();
app.UseCors(MyAllowSpecificOrigins);

app.Map("/api", api => {
  api.RunProxy(async context => {
    var forwardContext = context.ForwardTo("https://postman-echo.com");
    // TODO: Add auth header here.
    return await forwardContext.Send();
  });
});

var isDev = app.Services.GetRequiredService<IWebHostEnvironment>().IsDevelopment();
// if (isDev)
//   app.UseSpa(spa => spa.UseProxyToSpaDevelopmentServer("http://localhost:3000"));
// else
  app.UseSpa(spa => {});
  
app.Run();
