using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ReleaseDedicatedGuestVlanRangeRequest : APIRequest
    {
        public ReleaseDedicatedGuestVlanRangeRequest() : base("releaseDedicatedGuestVlanRange") {}

        /// <summary>
        /// the ID of the dedicated guest vlan range
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Releases a dedicated guest vlan range to the system
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ReleaseDedicatedGuestVlanRange(ReleaseDedicatedGuestVlanRangeRequest request);
        Task<AsyncJobResponse> ReleaseDedicatedGuestVlanRangeAsync(ReleaseDedicatedGuestVlanRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ReleaseDedicatedGuestVlanRange(ReleaseDedicatedGuestVlanRangeRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ReleaseDedicatedGuestVlanRangeAsync(ReleaseDedicatedGuestVlanRangeRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
