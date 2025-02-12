using BadgerClan.API.Bots;
using BadgerClan.Logic;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
var app = builder.Build();
List<Move> myMoves = new();
GameState? currentState = null;

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapPost("/", (GameState state) => 
{
    currentState = state;
    return Bot.MakeMoves(state, myMoves);
});


#region MAUI Button Endpoints
// Endpoints for sending MoveRequests to BadgerClan
app.MapGet("/MoveLeft", () =>
{
    if (currentState == null)
    {
        throw new Exception("Ya gotta wait for the game to start before you can move, silly :)");
        // In other words, the server hasn't passed the GameState object yet
    }
    else
    {
        foreach (Unit unit in currentState.Units)
        {
            // TODO: Check for out-of-bounds moves
            myMoves.Add(new Move(MoveType.Walk, unit.Id, unit.Location.MoveWest(1)));
        }
    }

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

#endregion

app.Run();

public record GameState(IEnumerable<Unit> Units, IEnumerable<int> TeamIds, int YourTeamId, int TurnNumber, string GameId, int BoardSize, int Medpacs, int NextMedpac);
public record Unit(string Type, int Id, int Attack, int AttackDistance, int Health, int MaxHealth, double Moves, double MaxMoves, Coordinate Location, int Team);