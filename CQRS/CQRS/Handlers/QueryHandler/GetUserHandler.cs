
using CQRS.Queries;
using MediatR;
using RepositoryPattern.Models;
using RepositoryPattern.Repository;

namespace CQRS.Handlers.QueryHandler
{
    public class GetUserHandler : IRequestHandler<GetAllUserQuery, List<User>>
    {
        private readonly IUserRepository userRepository;

        public GetUserHandler(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<List<User>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            return await userRepository.GetUsers();
        }
    }


    public class GetUserByIdHandler : IRequestHandler<GetUserById, User>
    {
        private readonly IUserRepository userRepository;

        public GetUserByIdHandler(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public async Task<User> Handle(GetUserById request, CancellationToken cancellationToken)
        {
            return await userRepository.GetUserById(request.id);
        }
    }
}
