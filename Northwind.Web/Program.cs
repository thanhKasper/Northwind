
#region Configure the web server host and services.
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
var app = builder.Build();
#endregion

#region Configure the HTTP pipeline and routes
if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}
#endregion
app.UseHttpsRedirection(); // if we access through http it will direct us to https
app.UseDefaultFiles(); // index.html, default.html, and so on
app.UseStaticFiles();
app.MapRazorPages();
app.MapGet("/greeting", () => $"Your ASPNETCORE_ENVIRONMENT is: {app.Environment.EnvironmentName}");

// Start the web server, host the website, and wait for requests.
app.Run(); // This is a thread-blocking call.
WriteLine("This executes after the web server has stopped!");
