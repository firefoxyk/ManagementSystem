namespace ManagementSystem.Application.Appeal.Comments.Create
{
    using MediatR;
    using ManagementSystem.Domain.Appeal;
    using ManagementSystem.Domain.Users;

    public record class CreateCommentCommand(
        Guid AppealId,
        Guid UserId,
        string Body
        ) : IRequest<Unit>;//спроси тут
}