using AutoMapper;
using HR_Managment.Application.DTOs.LeaveRequest;
using HR_Managment.Application.Features.LeaveRequests.Requests.Queries;
using HR_Managment.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HR_Managment.Application.Features.LeaveRequests.Handler.Queries
{
    public class GetLeaveRequestsDetailHandler : IRequestHandler<GetLeaveRequestsDetailRequest, LeaveRequestDto>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;
        public GetLeaveRequestsDetailHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }
        public async Task<LeaveRequestDto> Handle(GetLeaveRequestsDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.GetLeaveRequestWithDetailsAsync(request.Id);
            return _mapper.Map<LeaveRequestDto>(leaveRequest);
        }
    }
}
