var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("time/utc", () => Results.Ok(DateTime.Now));
app.MapGet("time2/utc", () => Results.Ok(DateTime.Now));
app.MapGet("time3/utc", () => Results.Ok(DateTime.Now));
app.MapGet("time4/utc", () => Results.Ok(DateTime.Now));


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
