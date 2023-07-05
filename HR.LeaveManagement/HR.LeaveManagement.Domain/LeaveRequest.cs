using HR.LeaveManagement.Domain.Common;

namespace HR.LeaveManagement.Domain;

public class LeaveRequest : BaseEntity
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime DateRequested{ get; set; } 
    public string RequestComments{ get; set; } = string.Empty;
    public LeaveType? LeaveType { get; set; }
    public int LeaveTypeId { get; set; }
    public bool Approved{ get; set; }=false;
    public bool Canceled { get; set; }= false;
    public string RequestingEmployeeId{ get; set; }=string.Empty;
}
