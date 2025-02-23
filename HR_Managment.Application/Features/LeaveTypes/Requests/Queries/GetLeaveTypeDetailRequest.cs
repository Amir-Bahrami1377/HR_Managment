using HR_Managment.Application.DTOs;
using HR_Managment.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Managment.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeDetailRequest : IRequest<LeaveTypeDto>
    {
        public int Id { get; set; }
    }
}
