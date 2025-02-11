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
app.MapGet("MoveLeft", () =>
{
    return Results.Ok();
});

app.MapGet("/MoveUpLeft", () =>
{
    return Results.Ok();
});


app.MapGet("/MoveDownLeft", () =>
{
    return Results.Ok();
});

app.MapGet("/MoveRight", () =>
{
    return Results.Ok();
});

app.MapGet("/MoveUpRight", () =>
{
    return Results.Ok();
});

app.MapGet("/MoveDownRight", () =>
{
    return Results.Ok();
});

app.Run();