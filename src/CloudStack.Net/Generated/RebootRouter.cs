using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RebootRouterRequest : APIRequest
    {
        public RebootRouterRequest() : base("rebootRouter") {}

        /// <summary>
        /// the ID of the router
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Starts a router.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RebootRouter(RebootRouterRequest request);
        Task<AsyncJobResponse> RebootRouterAsync(RebootRouterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RebootRouter(RebootRouterRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RebootRouterAsync(RebootRouterRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
