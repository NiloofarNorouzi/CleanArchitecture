using AutoMapper;
using HR.LeaveManagment.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Application.Features.LeaveType.Command.UpdateLeaveType
{
    public class UpdateLeaveTypeCommandHandler : IRequestHandler<UpdateLeaveTypeCommand, Unit>
    {
        private readonly IMapper _imapper;
        private readonly ILeaveTypeRepository _repository;
        public UpdateLeaveTypeCommandHandler(IMapper imapper, ILeaveTypeRepository repository)
        {
            _imapper = imapper;
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            // Validate request

            var leavetypeToUpdate = _imapper.Map<LeaveManagement.Domain.LeaveType>(request);

            await _repository.UpdateEntity(leavetypeToUpdate);

            return Unit.Value;
        }
    }
}
