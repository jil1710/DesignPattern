
using CQRS.Commands;
using CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Models;
using RepositoryPattern.Repository;
using System.Reflection;

namespace CQRS
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

            builder.Services.AddMediatR(x =>
            {
                x.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
                var assemblyNames = Assembly.GetExecutingAssembly().GetReferencedAssemblies();
                var Assemblies = new List<Assembly>();

                foreach (var item in assemblyNames)
                {
                    Assemblies.Add(Assembly.Load(item));
                }
                foreach (var item in Assemblies)
                {
                    x.RegisterServicesFromAssembly(item);
                }
            });

            builder.Services.AddScoped<IUserRepository, UserRepository>();

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


            app.MapGet("/users", (ISender sender, CancellationToken token) =>
            {
                return Results.Ok(sender.Send(new GetAllUserQuery(), token).Result);
            });


            app.MapGet("/users/{id}", (int id, ISender sender, CancellationToken token) =>
            {
                return Results.Ok(sender.Send(new GetUserById(id), token).Result);
            });

            app.MapPost("/add-user", ([FromBody] AddUserRequest addUserRequest, ISender sender, CancellationToken token) =>
            {
                sender.Send(addUserRequest, token);
                Results.Ok("Add Successfully");
            });



            app.Run();
        }
    }
}