using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ConfigureInternalLoadBalancerElementRequest : APIRequest
    {
        public ConfigureInternalLoadBalancerElementRequest() : base("configureInternalLoadBalancerElement") {}

        /// <summary>
        /// the ID of the internal lb provider
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Enables/Disables the Internal Load Balancer element
        /// </summary>
        public bool Enabled { get; set; }

    }
    /// <summary>
    /// Configures an Internal Load Balancer element.
    /// </summary>
    /// <summary>
    /// Configures an Internal Load Balancer element.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        InternalLoadBalancerElementResponse ConfigureInternalLoadBalancerElement(ConfigureInternalLoadBalancerElementRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public InternalLoadBalancerElementResponse ConfigureInternalLoadBalancerElement(ConfigureInternalLoadBalancerElementRequest request) => _proxy.Request<InternalLoadBalancerElementResponse>(request);
    }
}