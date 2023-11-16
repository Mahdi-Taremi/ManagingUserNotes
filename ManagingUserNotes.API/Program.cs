using ManagingUserNotes.API.DataAccess;
using ManagingUserNotes.API.Repositoties.Interfaces;
using ManagingUserNotes.API.Repositoties.Services;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

/*  *** Add services to the container. *** */
#region services

// use Controllers
builder.Services.AddControllers();

// 1.(Swagger) First stage for add Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add Access to Database 
builder.Services.AddDbContext<DbContextManagingUserNotes>(options =>
{
    var ConnectionStrings = builder.Configuration.GetConnectionString("ManagingUserNotesConnectionString");
    options.UseSqlite(ConnectionStrings);
});

// Add Repositories
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<INoteRepository, NoteRepository>();

// Add AddAutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

#endregion

var app = builder.Build();

/* *** Configure the HTTP request pipeline. *** */
#region Pipeline
// 2.(Swagger) Second  stage for add Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Manage Routing
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

#endregion



app.Run();