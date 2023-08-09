using AutoMapper;
using HR.LeaveManagment.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Application.Features.LeaveType.Command.CreateLeaveType
{
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _repository;

        public CreateLeaveTypeCommandHandler(IMapper mapper, ILeaveTypeRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            // Validate

            // Map
            var leaveTypeToCreate = _mapper.Map<LeaveManagement.Domain.LeaveType>(request);

            // Create
            await _repository.AddEntity(leaveTypeToCreate);

            // Return
            return leaveTypeToCreate.Id;
        }
    }
}
