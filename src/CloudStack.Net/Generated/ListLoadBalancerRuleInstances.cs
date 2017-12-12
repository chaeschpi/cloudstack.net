using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListLoadBalancerRuleInstancesRequest : APIListRequest
    {
        public ListLoadBalancerRuleInstancesRequest() : base("listLoadBalancerRuleInstances") {}

        /// <summary>
        /// the ID of the load balancer rule
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// true if listing all virtual machines currently applied to the load balancer rule; default is true
        /// </summary>
        public bool? Applied {
            get { return GetParameterValue<bool?>(nameof(Applied).ToLower()); }
            set { SetParameterValue(nameof(Applied).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// true if load balancer rule VM IP information to be included; default is false
        /// </summary>
        public bool? Lbvmips {
            get { return GetParameterValue<bool?>(nameof(Lbvmips).ToLower()); }
            set { SetParameterValue(nameof(Lbvmips).ToLower(), value); }
        }

    }
    /// <summary>
    /// List all virtual machine instances that are assigned to a load balancer rule.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<LoadBalancerRuleVmMapResponse> ListLoadBalancerRuleInstances(ListLoadBalancerRuleInstancesRequest request);
        Task<ListResponse<LoadBalancerRuleVmMapResponse>> ListLoadBalancerRuleInstancesAsync(ListLoadBalancerRuleInstancesRequest request);
        ListResponse<LoadBalancerRuleVmMapResponse> ListLoadBalancerRuleInstancesAllPages(ListLoadBalancerRuleInstancesRequest request);
        Task<ListResponse<LoadBalancerRuleVmMapResponse>> ListLoadBalancerRuleInstancesAllPagesAsync(ListLoadBalancerRuleInstancesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<LoadBalancerRuleVmMapResponse> ListLoadBalancerRuleInstances(ListLoadBalancerRuleInstancesRequest request) => Proxy.Request<ListResponse<LoadBalancerRuleVmMapResponse>>(request);
        public Task<ListResponse<LoadBalancerRuleVmMapResponse>> ListLoadBalancerRuleInstancesAsync(ListLoadBalancerRuleInstancesRequest request) => Proxy.RequestAsync<ListResponse<LoadBalancerRuleVmMapResponse>>(request);
        public ListResponse<LoadBalancerRuleVmMapResponse> ListLoadBalancerRuleInstancesAllPages(ListLoadBalancerRuleInstancesRequest request) => Proxy.RequestAllPages<LoadBalancerRuleVmMapResponse>(request);
        public Task<ListResponse<LoadBalancerRuleVmMapResponse>> ListLoadBalancerRuleInstancesAllPagesAsync(ListLoadBalancerRuleInstancesRequest request) => Proxy.RequestAllPagesAsync<LoadBalancerRuleVmMapResponse>(request);
    }
}
