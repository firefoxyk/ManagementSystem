namespace ManagementSystem.Application.Appeal.Create
{
    using MediatR;
    public record class CreateAppealCommand(
        Guid UserId,
        string Headline,
        string Body
        ) : IRequest<Unit>;//спроси тут
}
