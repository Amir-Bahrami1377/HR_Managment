using HR_Managment.Application.DTOs.Common;
using HR_Managment.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Managment.Application.DTOs
{
    public class LeaveAllocationDto: BaseDto
    {
        public int NumberOfDays { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Priod { get; set; }
    }
}
