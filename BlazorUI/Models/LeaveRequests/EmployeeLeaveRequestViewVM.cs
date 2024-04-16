using BlazorUI.Models.LeaveAllocations;

namespace BlazorUI.Models.LeaveRequests;

public class EmployeeLeaveRequestViewVM
{
    public List<LeaveAllocationVM> LeaveAllocations { get; set; }
    public List<LeaveRequestVM> LeaveRequests { get; set; }
}
