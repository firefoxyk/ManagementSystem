namespace ManagementSystem.Application.Appeal.Create
{
    using ManagementSystem.Domain.Appeal;
    using ManagementSystem.Domain.Primitives;
    using MediatR;

    internal sealed class CreateAppealCommandHandler : IRequestHandler<CreateAppealCommand, Unit>
    {
        private readonly IAppealRepository _appealRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateAppealCommandHandler(IUnitOfWork unitOfWork, IAppealRepository appealRepository)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _appealRepository = appealRepository ?? throw new ArgumentNullException(nameof(appealRepository));
        }

        public async Task<Unit> Handle(CreateAppealCommand command, CancellationToken cancellationToken)
        {
            try
            {
                //спроси нужна ли валидация??
                var appeal = new Appeal (new AppealId(Guid.NewGuid()), command.UserId, command.Headline, command.Body);

                await _appealRepository.Add(appeal);
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
