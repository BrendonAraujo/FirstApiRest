// Ignore Spelling: app

using FirstRestAPI.Config;

var builder = WebApplication.CreateBuilder(args);

builder.AddDBContextConfig();

builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("Development",
        builder => builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
});

builder.Services.ApplyDependencyInjection();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("Development");
app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
