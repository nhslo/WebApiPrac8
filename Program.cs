using Asp.Versioning;
using StudentApi.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddSingleton<StudentService>();
builder.Services.AddApiVersioning(options =>
{
    options.AssumeDefaultVersionWhenUnspecified = false;
    options.ReportApiVersions = true;
    options.ApiVersionReader = ApiVersionReader.Combine(
        new UrlSegmentApiVersionReader(), new HeaderApiVersionReader("X-Api-Version"));
}).AddMvc();
var app = builder.Build();
app.MapControllers();
app.Run();
