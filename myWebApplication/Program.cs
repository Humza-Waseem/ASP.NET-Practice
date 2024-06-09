var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "hELLO wORLD!");//This line maps the root URL ("/") of the web application to a function that returns the string "Hello World!". This means that when you navigate to the root URL of the web application, you will see "Hello World!" displayed

app.Run();
