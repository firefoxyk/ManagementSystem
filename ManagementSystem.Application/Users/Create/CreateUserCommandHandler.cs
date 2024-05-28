namespace ManagementSystem.Application.Users.Create
{
    using ManagementSystem.Domain.Primitives;
    using ManagementSystem.Domain.Users;
    using ManagementSystem.Domain.ValueObjects;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    internal sealed class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Unit>
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateUserCommandHandler(IUnitOfWork unitOfWork, IUserRepository userRepository)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }
        public async Task<Unit> Handle(CreateUserCommand command, CancellationToken cancellationToken)
        {
            try
            {
                if (PhoneNumber.Create(command.PhoneNumber) is not PhoneNumber phoneNumber)
                {
                    throw new ArgumentNullException(nameof(phoneNumber));
                }

                if (Email.Create(command.Email) is not Email email)
                {
                    throw new ArgumentNullException(nameof(email));
                }

                if (Address.Create(command.Region, command.City, command.District, command.Street, command.House, command.Apartment, command.ZipCode) is not Address address)
                {
                    throw new ArgumentNullException(nameof(address));
                }

                User user = new User(new UserId(Guid.NewGuid()), command.UserSurname, command.UserName, address, email, phoneNumber, true);

                await _userRepository.Add(user);
                await _unitOfWork.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
            catch
            {
                throw;
            }
        }
    }
}
