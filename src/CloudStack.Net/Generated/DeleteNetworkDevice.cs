using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteNetworkDeviceRequest : APIRequest
    {
        public DeleteNetworkDeviceRequest() : base("deleteNetworkDevice") {}

        /// <summary>
        /// Id of network device to delete
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes network device.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteNetworkDevice(DeleteNetworkDeviceRequest request);
        Task<SuccessResponse> DeleteNetworkDeviceAsync(DeleteNetworkDeviceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteNetworkDevice(DeleteNetworkDeviceRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteNetworkDeviceAsync(DeleteNetworkDeviceRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
