using HR_Managment.Application.DTOs;
using HR_Managment.Application.Features.LeaveAllocations.Requests.Queries;
using HR_Managment.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HR_Managment.Application.Features.LeaveAllocations.Handler.Queries
{
    public class LeaveAllocationListRequestHandler : IRequestHandler<GetLeaveAllocationListRequest, List<LeaveAllocationDto>>
    {
        public LeaveAllocationListRequestHandler()
        {
            
        }
        public Task<List<LeaveAllocationDto>> Handle(GetLeaveAllocationListRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
