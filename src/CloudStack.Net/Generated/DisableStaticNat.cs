using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DisableStaticNatRequest : APIRequest
    {
        public DisableStaticNatRequest() : base("disableStaticNat") {}

        /// <summary>
        /// the public IP address ID for which static NAT feature is being disabled
        /// </summary>
        public Guid IpAddressId {
            get { return GetParameterValue<Guid>(nameof(IpAddressId).ToLower()); }
            set { SetParameterValue(nameof(IpAddressId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Disables static rule for given IP address
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DisableStaticNat(DisableStaticNatRequest request);
        Task<AsyncJobResponse> DisableStaticNatAsync(DisableStaticNatRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DisableStaticNat(DisableStaticNatRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DisableStaticNatAsync(DisableStaticNatRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
