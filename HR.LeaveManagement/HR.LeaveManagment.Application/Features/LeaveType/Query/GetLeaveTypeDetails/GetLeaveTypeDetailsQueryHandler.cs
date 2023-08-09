using AutoMapper;
using HR.LeaveManagment.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Application.Features.LeaveType.Query.GetLeaveTypeDetails
{
    public class GetLeaveTypeDetailsQueryHandler : IRequestHandler<GetLeaveTypeDetailsQuery, LeaveTypeDetailDto>
    {
        private readonly ILeaveTypeRepository _repository;
        private readonly IMapper _mapper;
        public GetLeaveTypeDetailsQueryHandler(ILeaveTypeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<LeaveTypeDetailDto> Handle(GetLeaveTypeDetailsQuery request, CancellationToken cancellationToken)
        {
            var leaveTypeDetails = await _repository.GetById(request.id);
            var leaveTypeDetailsDto = _mapper.Map<LeaveTypeDetailDto>(leaveTypeDetails);

            return leaveTypeDetailsDto;
        }
    }
}
