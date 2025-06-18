using Estacionamiento.entitis;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddSingleton<Espacio>();
builder.Services.AddSingleton<vehiculos>();


builder.Services.AddControllers(); 

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();

