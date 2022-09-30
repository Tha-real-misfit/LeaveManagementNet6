using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;

namespace LeaveManagement.Web.Repositories
{
    public class LeaveTypeRepo : GenericRepo<LeaveType>, ILeaveTypeRepo
    {
        public LeaveTypeRepo(ApplicationDbContext context) : base(context)
        {
        }
    }
}
