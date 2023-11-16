using ManagingUserNotes.API.DataAccess;

var builder = WebApplication.CreateBuilder(args);

/*  *** Add services to the container. *** */
#region services

// use Controllers
builder.Services.AddControllers();

// 1.(Swagger) First stage for add Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add Access to Database 
builder.Services.AddDbContext<DbContextManagingUserNotes>();

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