namespace ManagementSystem.Domain.Users
{
    using ManagementSystem.Domain.Primitives;
    using ManagementSystem.Domain.ValueObjects;

    public sealed class User : AggregateRoot
    {
        public User(UserId id, string userSurname, string userName, Address userAddress, Email email, PhoneNumber phoneNumber, bool active)
        {
            UserId = id;
            UserSurname = userSurname;
            UserName = userName;
            UserAddress = userAddress;
            Email = email;
            PhoneNumber = phoneNumber;
            Active = active;
        }
        private User()//для Entity Framework
        { }

        public UserId UserId { get; private set; }
        public string UserSurname { get; private set; }
        public string UserName { get; private set; }
        public Address UserAddress { get; private set; }
        public Email Email { get; private set; }
        public PhoneNumber PhoneNumber { get; private set; }
        public bool Active { get; private set; }
    }
}
