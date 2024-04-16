using Blazored.LocalStorage;
using BlazorUI.Contracts;
using BlazorUI.Services.Base;

namespace BlazorUI.Services
{
    public class LeaveRequestService : BaseHttpService, ILeaveRequestService
    {

        public LeaveRequestService(IClient client, ILocalStorageService localStorage) : base(client, localStorage)
        {

        }
    }
}
