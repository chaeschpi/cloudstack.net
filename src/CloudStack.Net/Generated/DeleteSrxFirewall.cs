using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteSrxFirewallRequest : APIRequest
    {
        public DeleteSrxFirewallRequest() : base("deleteSrxFirewall") {}

        /// <summary>
        /// srx firewall device ID
        /// </summary>
        public Guid FwDeviceId {
            get { return GetParameterValue<Guid>(nameof(FwDeviceId).ToLower()); }
            set { SetParameterValue(nameof(FwDeviceId).ToLower(), value); }
        }

    }
    /// <summary>
    ///  delete a SRX firewall device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteSrxFirewall(DeleteSrxFirewallRequest request);
        Task<AsyncJobResponse> DeleteSrxFirewallAsync(DeleteSrxFirewallRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteSrxFirewall(DeleteSrxFirewallRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteSrxFirewallAsync(DeleteSrxFirewallRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
