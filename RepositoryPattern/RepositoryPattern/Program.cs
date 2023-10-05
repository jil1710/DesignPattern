using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Models;
using RepositoryPattern.Repository;

namespace RepositoryPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<UserContext>(option =>
            {
                var conn = builder.Configuration.GetConnectionString("Default");
                option.UseSqlServer(conn);
            });

            builder.Services.AddScoped<IUserRepository,UserRepository>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();


            app.MapGet("/users", async (IUserRepository repository, CancellationToken token) =>
            {
                return Results.Ok(await repository.GetUsers());
            });


            app.MapGet("/users/{id}", async (int id, IUserRepository repository, CancellationToken token) =>
            {
                var user = await repository.GetUserById(id);
                if (user != null)
                {
                    return Results.Ok(user);
                }

                return Results.NotFound("User Not Found!");
            });

            app.MapPost("/add-user", async (User user, IUserRepository repository, CancellationToken token) =>
            {
                var result = await repository.AddUser(user);
                if (result)
                {
                    return Results.Ok("Add Successfully");
                }

                return Results.BadRequest(result);
            });


            app.Run();
        }
    }
}