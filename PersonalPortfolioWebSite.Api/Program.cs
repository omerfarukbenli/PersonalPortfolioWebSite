using Microsoft.EntityFrameworkCore;
using PersonalPortfolioWebSite.Business.Abstract;
using PersonalPortfolioWebSite.Business.Concret;
using PersonalPortfolioWebSite.Data.Abstract;
using PersonalPortfolioWebSite.Data.Abstract.IUnitOfWork;
using PersonalPortfolioWebSite.Data.Concrete.EntityFramework.Context;
using PersonalPortfolioWebSite.Data.Concrete.EntityFramework.Repositories;
using PersonalPortfolioWebSite.Data.Concrete.EntityFramework.UnitOfWork;
using PersonalPortfolioWebSite.Entities.Mapping;
using System.Reflection;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);




builder.Services.AddDbContext<ApplicationDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(ApplicationDbContext)).GetName().Name);
    });
});


builder.Services.AddAutoMapper(typeof(MapProfile));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IContactRepository, EfContactRepository>();
builder.Services.AddScoped<IContactPartService, ContactManager>();
builder.Services.AddScoped<IRepoRepository, EfRepoRepository>();
builder.Services.AddScoped<IRepoService, RepoManager>();
builder.Services.AddScoped<IHomeRepository, EfHomePartRepository>();
builder.Services.AddScoped<IHomePartService, HomeManager>();
builder.Services.AddScoped<IAboutRepository, EfAboutRepository>();
builder.Services.AddScoped<IAboutPartService, AboutManager>();
builder.Services.AddScoped<ILinkRepository, EfLinkRepository>();
builder.Services.AddScoped<ILinkService, LinkManager>();




builder.Services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
{
    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
}));



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder => builder.WithOrigins("http://localhost:4200").AllowAnyHeader()); //sonradan angular için//izin ver
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

