using BadgerClan.Logic;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Endpoint for sending a MoveRequest to BadgerClan
app.MapPost("/MoveLeft", (MoveRequest request) =>
{
    // This stuff is not going to be here eventually
    List<Move> moves = new();
    MoveResponse response = new MoveResponse(moves);
    return response;
});

app.Run();