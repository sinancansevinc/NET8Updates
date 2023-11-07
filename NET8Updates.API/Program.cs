using NET8Updates.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Singleton is a single instance for the lifetime of the application domain.
//Scoped is a single instance for the duration of the scoped request, which means per HTTP request in ASP.NET.
//Transient is a single instance per code request.


builder.Services.AddKeyedTransient<IUserService, UserService>("user");

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
