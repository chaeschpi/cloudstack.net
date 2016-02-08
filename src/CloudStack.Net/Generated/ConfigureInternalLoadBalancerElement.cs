using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ConfigureInternalLoadBalancerElementRequest : APIRequest
    {
        public ConfigureInternalLoadBalancerElementRequest() : base("configureInternalLoadBalancerElement") {}

        /// <summary>
        /// the ID of the internal lb provider
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// Enables/Disables the Internal Load Balancer element
        /// </summary>
        public bool Enabled {
            get { return (bool) Parameters[nameof(Enabled).ToLower()]; }
            set { Parameters[nameof(Enabled).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Configures an Internal Load Balancer element.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ConfigureInternalLoadBalancerElement(ConfigureInternalLoadBalancerElementRequest request);
        Task<AsyncJobResponse> ConfigureInternalLoadBalancerElementAsync(ConfigureInternalLoadBalancerElementRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ConfigureInternalLoadBalancerElement(ConfigureInternalLoadBalancerElementRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ConfigureInternalLoadBalancerElementAsync(ConfigureInternalLoadBalancerElementRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
