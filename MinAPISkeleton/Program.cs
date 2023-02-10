var builder = WebApplication.CreateBuilder(args);

// todo - add db context for mongodb

// Inject swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// .MapPost
// .MapPut
// .MapDelete

app.Run();

