using AutoMapper;
using HR_Managment.Application.DTOs;
using HR_Managment.Application.Features.LeaveTypes.Requests.Queries;
using HR_Managment.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HR_Managment.Application.Features.LeaveTypes.Handler.Queries
{
    public class GetLeaveTypeDetailRequestHandler : IRequestHandler<GetLeaveTypeDetailRequest, LeaveTypeDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public GetLeaveTypeDetailRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            leaveTypeRepository = leaveTypeRepository;
            mapper = mapper;
        }
        public async Task<LeaveTypeDto> Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveType = _leaveTypeRepository.GetAsync(request.Id);
            return _mapper.Map<LeaveTypeDto>(leaveType);
        }
    }
}
