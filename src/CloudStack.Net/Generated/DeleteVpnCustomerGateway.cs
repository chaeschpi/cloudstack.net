using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteVpnCustomerGatewayRequest : APIRequest
    {
        public DeleteVpnCustomerGatewayRequest() : base("deleteVpnCustomerGateway") {}

        /// <summary>
        /// id of customer gateway
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Delete site to site vpn customer gateway
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteVpnCustomerGateway(DeleteVpnCustomerGatewayRequest request);
        Task<AsyncJobResponse> DeleteVpnCustomerGatewayAsync(DeleteVpnCustomerGatewayRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteVpnCustomerGateway(DeleteVpnCustomerGatewayRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteVpnCustomerGatewayAsync(DeleteVpnCustomerGatewayRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
