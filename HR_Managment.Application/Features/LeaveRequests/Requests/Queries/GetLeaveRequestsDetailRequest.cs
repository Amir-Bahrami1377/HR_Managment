using HR_Managment.Application.DTOs.LeaveRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Managment.Application.Features.LeaveRequests.Requests.Queries
{
    public class GetLeaveRequestsDetailRequest: IRequest<LeaveRequestDto>
    {
        public int Id { get; set; }
    }
}
