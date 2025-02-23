using HR_Managment.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Managment.Domain
{
    public class LeaveType: BaseDomainEntity
    {
        public string Name { get; set; }
        public int DefaultDay { get; set; }
    }
}
