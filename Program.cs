using BearerAuthApp.Data;
using BearerAuthApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

#region ADD DB CONFIGURATION
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("Default"));
});
#endregion

#region ADD AUTH CONFIGURATION
builder.Services
    .AddAuthorization()
    .AddAuthentication()
    .AddBearerToken(IdentityConstants.BearerScheme);
#endregion

#region ADD IDENTITY CORE CONFIGURATION
builder.Services.AddIdentityCore<UserModel>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddApiEndpoints();
#endregion

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapIdentityApi<UserModel>();

app.MapControllers();

app.Run();
