using HR_Managment.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Managment.Application.DTOs
{
    public class LeaveTypeDto:BaseDto
    {
        public string Name { get; set; }
        public int DefaultDay { get; set; }
    }
}
