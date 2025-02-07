using BadgerClan.Logic;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Endpoints for sending MoveRequests to BadgerClan
app.MapGet("/MoveLeft", () =>
{
    return Results.Ok();
});

app.Run();