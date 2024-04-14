using Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Domain;

public class LeaveType: BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public int DefaultDays { get; set; }

}
