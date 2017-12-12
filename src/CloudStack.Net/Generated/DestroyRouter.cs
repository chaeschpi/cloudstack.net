using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DestroyRouterRequest : APIRequest
    {
        public DestroyRouterRequest() : base("destroyRouter") {}

        /// <summary>
        /// the ID of the router
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Destroys a router.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DestroyRouter(DestroyRouterRequest request);
        Task<AsyncJobResponse> DestroyRouterAsync(DestroyRouterRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DestroyRouter(DestroyRouterRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DestroyRouterAsync(DestroyRouterRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
