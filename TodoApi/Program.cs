using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using TodoApi.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers();
//builder.Services.AddDbContext<TodoContext>(opt =>
//opt.UseInMemoryDatabase("TodoList"));


builder.Services.AddControllers();

builder.Services.AddDbContext<AppSettingsDbContext>(options =>
{
   // options.UseSqlServer(builder.Configuration.GetConnectionString("AppSettingsDbContext"));
options.UseMySql("server=localhost;user=testihahmo;password=pass12345;database=tododatabase", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.9.4-mariadb"));

});



/*
builder.Services.AddControllers();
builder.Services.AddDbContext<TodoDBcontext>(options =>
{
    options.UseSqlServer(builder.Configuration["DefaultConnection"]);
});
*/

/*
builder.Services.AddControllers();
builder.Services.AddDbContext<TodoDBcontext>(
    opt => opt.UseSqlServer("tododatabase"));
*/


//SWAGGER
//builder.Services.AddSwaggerGen(c =>
//{
//   c.SwaggerDoc("v1", new() { Title = "TodoApi", Version = "v1" });
//});




var app = builder.Build();

// Configure the HTTP request pipeline.
if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();


    // SWAGGER
    //app.UseSwagger();
    //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TodoApi v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

