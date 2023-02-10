var builder = WebApplication.CreateBuilder(args);

// todo - add db context for mongodb, add appropriate rest calls to api

// todo - add logging

// Inject swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    // Don't use this for release builds, shows stack trace
    app.UseDeveloperExceptionPage();
}
app.UseHttpsRedirection();

app.MapGet("/", () => "Get done");

app.MapPut("/", () => "Put done");

app.MapPost("/", () => "Post done");

app.MapDelete("/", () =>
{
    throw new NotImplementedException("delete not implemented");
});

app.UseSwagger();
app.UseSwaggerUI();

app.Run();

