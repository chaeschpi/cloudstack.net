using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeletePhysicalNetworkRequest : APIRequest
    {
        public DeletePhysicalNetworkRequest() : base("deletePhysicalNetwork") {}

        /// <summary>
        /// the ID of the Physical network
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a Physical Network.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeletePhysicalNetwork(DeletePhysicalNetworkRequest request);
        Task<AsyncJobResponse> DeletePhysicalNetworkAsync(DeletePhysicalNetworkRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeletePhysicalNetwork(DeletePhysicalNetworkRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeletePhysicalNetworkAsync(DeletePhysicalNetworkRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
