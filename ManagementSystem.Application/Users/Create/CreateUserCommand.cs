namespace ManagementSystem.Application.Users.Create
{
    using MediatR;
    public record CreateUserCommand(
        string UserSurname,
        string UserName,
        string Region,
        string City,
        string District,
        string Street,
        byte House,
        ushort Apartment,
        string ZipCode,
        string Email,
        string PhoneNumber
        ) : IRequest<Unit>;
}
