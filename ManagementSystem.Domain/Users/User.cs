namespace ManagementSystem.Domain.Users
{
    using ManagementSystem.Domain.Primitives;
    using ManagementSystem.Domain.ValueObjects;

    public sealed class User : AggregateRoot
    {
        public User(UserId id, string userSurname, string userName, Address userAddress, Email email, PhoneNumber phoneNumber, bool active)
        {
            Id = id;
            Surname = userSurname;
            Name = userName;
            Address = userAddress;
            Email = email;
            PhoneNumber = phoneNumber;
            Active = active;
        }
        private User()//для Entity Framework
        { }

        public UserId Id { get; private set; }
        public string Surname { get; private set; }
        public string Name { get; private set; }
        public Address Address { get; private set; }
        public Email Email { get; private set; }
        public PhoneNumber PhoneNumber { get; private set; }
        public bool Active { get; private set; }
    }
}
