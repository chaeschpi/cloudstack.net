using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ConfigurePaloAltoFirewallRequest : APIRequest
    {
        public ConfigurePaloAltoFirewallRequest() : base("configurePaloAltoFirewall") {}

        /// <summary>
        /// Palo Alto firewall device ID
        /// </summary>
        public Guid FwDeviceId {
            get { return GetParameterValue<Guid>(nameof(FwDeviceId).ToLower()); }
            set { SetParameterValue(nameof(FwDeviceId).ToLower(), value); }
        }

        /// <summary>
        /// capacity of the firewall device, Capacity will be interpreted as number of networks device can handle
        /// </summary>
        public long? Fwdevicecapacity {
            get { return GetParameterValue<long?>(nameof(Fwdevicecapacity).ToLower()); }
            set { SetParameterValue(nameof(Fwdevicecapacity).ToLower(), value); }
        }

    }
    /// <summary>
    /// Configures a Palo Alto firewall device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ConfigurePaloAltoFirewall(ConfigurePaloAltoFirewallRequest request);
        Task<AsyncJobResponse> ConfigurePaloAltoFirewallAsync(ConfigurePaloAltoFirewallRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ConfigurePaloAltoFirewall(ConfigurePaloAltoFirewallRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ConfigurePaloAltoFirewallAsync(ConfigurePaloAltoFirewallRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
