using GameStore.Api.Data;
using GameStore.Api.EndPoints;

var builder = WebApplication.CreateBuilder(args);

// Connection string
var connString = builder.Configuration.GetConnectionString("GameStore");
builder.Services.AddSqlite<GameStoreContext>(connString);


var app = builder.Build();

app.MapGamesEndpoints();
app.MapGenresEndponts();
await app.MigrateDbAsync();


app.Run();
