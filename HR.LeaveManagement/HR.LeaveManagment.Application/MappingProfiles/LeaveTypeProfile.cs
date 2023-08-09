using AutoMapper;
using HR.LeaveManagement.Domain;
using HR.LeaveManagment.Application.Features.LeaveType.Query.GetAllLeaveTypes;
using HR.LeaveManagment.Application.Features.LeaveType.Query.GetLeaveTypeDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Application.MappingProfiles
{
    public class LeaveTypeProfile : Profile
    {
        public LeaveTypeProfile()
        {
            CreateMap<LeaveTypeDto, LeaveType>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDetailDto>();
        }
    }
}
