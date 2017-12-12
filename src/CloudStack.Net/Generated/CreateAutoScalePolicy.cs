using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateAutoScalePolicyRequest : APIRequest
    {
        public CreateAutoScalePolicyRequest() : base("createAutoScalePolicy") {}

        /// <summary>
        /// the action to be executed if all the conditions evaluate to true for the specified duration.
        /// </summary>
        public string Action {
            get { return GetParameterValue<string>(nameof(Action).ToLower()); }
            set { SetParameterValue(nameof(Action).ToLower(), value); }
        }

        /// <summary>
        /// the list of IDs of the conditions that are being evaluated on every interval
        /// </summary>
        public IList<Guid> ConditionIds {
            get { return GetList<Guid>(nameof(ConditionIds).ToLower()); }
            set { SetParameterValue(nameof(ConditionIds).ToLower(), value); }
        }

        /// <summary>
        /// the duration for which the conditions have to be true before action is taken
        /// </summary>
        public int? Duration {
            get { return GetParameterValue<int?>(nameof(Duration).ToLower()); }
            set { SetParameterValue(nameof(Duration).ToLower(), value); }
        }

        /// <summary>
        /// the cool down period for which the policy should not be evaluated after the action has been taken
        /// </summary>
        public int? QuietTime {
            get { return GetParameterValue<int?>(nameof(QuietTime).ToLower()); }
            set { SetParameterValue(nameof(QuietTime).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates an autoscale policy for a provision or deprovision action, the action is taken when the all the conditions evaluates to true for the specified duration. The policy is in effect once it is attached to a autscale vm group.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateAutoScalePolicy(CreateAutoScalePolicyRequest request);
        Task<AsyncJobResponse> CreateAutoScalePolicyAsync(CreateAutoScalePolicyRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateAutoScalePolicy(CreateAutoScalePolicyRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateAutoScalePolicyAsync(CreateAutoScalePolicyRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
