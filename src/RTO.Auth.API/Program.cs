using ASA.Auth.API.Configuration;
using RTO.Auth.API.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiConfiguration();
builder.Services.AddDependencyConfiguration(builder.Configuration);
builder.Services.AddSwaggerConfiguration();
builder.Services.AddSettingsConfiguration(builder.Configuration);
builder.Services.AddDistributedCacheConfiguration(builder.Configuration);

var app = builder.Build();

app.UseApiConfiguration();
app.UseSwaggerConfiguration();

app.Run();
