using HR_Managment.Application.DTOs.Common;
using HR_Managment.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Managment.Application.DTOs.LeaveRequest
{
    public class LeaveRequestListDto:BaseDto
    {
        public LeaveType LeaveType { get; set; }
        public DateTime DateRequested { get; set; }
        public bool Aoorived { get; set; }
    }
}
