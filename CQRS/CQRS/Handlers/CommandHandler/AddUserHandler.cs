using CQRS.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Models;
using RepositoryPattern.Repository;

namespace CQRS.Handlers.CommandHandler
{
    public class AddUserHandler : IRequestHandler<AddUserRequest,bool>
    {
        private readonly IUserRepository userRepository;

        public AddUserHandler(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public async Task<bool> Handle(AddUserRequest request, CancellationToken cancellationToken)
        {
            var res = await userRepository.AddUser(new User() { Id = request.Id, Name = request.Name,Email = request.Email,Password=request.Password});

            return res;
        }
    }
}
