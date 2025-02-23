using HR_Managment.Application.DTOs;
using HR_Managment.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Managment.Application.Features.LeaveAllocations.Requests.Queries
{
    public class GetLeaveAllocationListRequest: IRequest<List<LeaveAllocationDto>>
    {
    }
}
