using BuisnesLogic.Interfaces;
using BuisnesLogic.Sevices;
using Data.Configs;
using Data.DBContext;
using Data.Work;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<ConnectionProperty>(builder.Configuration.GetSection("ConnectionProperty"));
builder.Services.AddDbContext<UserDbContext>();
builder.Services.AddScoped<IWorkWithData, WorkWithData>();
builder.Services.AddScoped<IAccountServices,AccountService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedAccount = true;
    options.Password.RequireDigit = true;
}).AddEntityFrameworkStores<UserDbContext>().AddDefaultTokenProviders();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
