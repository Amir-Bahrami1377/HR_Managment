using HR_Managment.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HR_Managment.Application.Persistence.Contracts
{
    public interface ILeaveRequestRepository: IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestWithDetailsAsync(int id);
        Task<List<LeaveRequest>> GetLeaveRequestsWithDetailsAsync();
    }
}
