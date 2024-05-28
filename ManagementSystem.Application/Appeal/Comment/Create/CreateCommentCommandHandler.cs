namespace ManagementSystem.Application.Appeal.Comment.Create
{
    using ManagementSystem.Application.Appeal.Comments.Create;
    using ManagementSystem.Domain.Comments;
    using ManagementSystem.Domain.Primitives;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    internal sealed class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand, Unit>
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCommentCommandHandler(IUnitOfWork unitOfWork, ICommentRepository commentRepository)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _commentRepository = commentRepository ?? throw new ArgumentNullException(nameof(commentRepository));
        }
        public async Task<Unit> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            try
            {
                Comment comment = new Comment(new CommentId(Guid.NewGuid()), request.AppealId, request.UserId, request.Body);

                await _commentRepository.Add(comment);
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
