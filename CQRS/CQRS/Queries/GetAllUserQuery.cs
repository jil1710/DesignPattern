
using MediatR;
using RepositoryPattern.Models;

namespace CQRS.Queries
{
    public sealed record GetAllUserQuery() : IRequest<List<User>>; 

    public sealed record GetUserById(int id) : IRequest<User>;
    
}
