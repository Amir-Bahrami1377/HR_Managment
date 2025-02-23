using AutoMapper;
using HR_Managment.Application.DTOs;
using HR_Managment.Application.DTOs.LeaveRequest;
using HR_Managment.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Managment.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
        }

    }
}
