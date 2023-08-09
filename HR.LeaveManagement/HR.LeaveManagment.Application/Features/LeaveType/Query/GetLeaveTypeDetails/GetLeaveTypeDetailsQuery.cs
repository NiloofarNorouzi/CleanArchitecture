using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Application.Features.LeaveType.Query.GetLeaveTypeDetails
{
    public record GetLeaveTypeDetailsQuery(int id) : IRequest<LeaveTypeDetailDto>;
    
    
}
