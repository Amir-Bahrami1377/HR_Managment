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
    public class GetLeaveRequestsListRequestHandler : IRequestHandler<GetLeaveRequestsListRequest, List<LeaveRequestListDto>>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;
        public GetLeaveRequestsListRequestHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _mapper = mapper;
            _leaveRequestRepository = leaveRequestRepository;
        }
        public async Task<List<LeaveRequestListDto>> Handle(GetLeaveRequestsListRequest request, CancellationToken cancellationToken)
        {
            var leaveRequestsList = await _leaveRequestRepository.GetLeaveRequestsWithDetailsAsync();
            return _mapper.Map<List<LeaveRequestListDto>>(leaveRequestsList);
        }
    }
}
