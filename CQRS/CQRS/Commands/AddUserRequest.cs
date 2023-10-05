using MediatR;

namespace CQRS.Commands
{
    public class AddUserRequest : IRequest<bool>
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;
    }
}
