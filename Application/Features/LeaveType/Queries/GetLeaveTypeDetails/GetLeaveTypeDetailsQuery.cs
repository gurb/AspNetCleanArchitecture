using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.LeaveType.Queries.GetLeaveTypeDetails
{
    //public class GetLeaveTypesDetailsQuery: IRequest<LeaveTypeDetailsDto>
    //{
    //    public int Id { get; set; }
    //}

    public record GetLeaveTypesDetailsQuery(int Id) : IRequest<LeaveTypeDetailsDto>;
}
