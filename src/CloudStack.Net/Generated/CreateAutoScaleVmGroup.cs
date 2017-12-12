using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CreateAutoScaleVmGroupRequest : APIRequest
    {
        public CreateAutoScaleVmGroupRequest() : base("createAutoScaleVmGroup") {}

        /// <summary>
        /// the ID of the load balancer rule
        /// </summary>
        public Guid LbRuleId {
            get { return GetParameterValue<Guid>(nameof(LbRuleId).ToLower()); }
            set { SetParameterValue(nameof(LbRuleId).ToLower(), value); }
        }

        /// <summary>
        /// the maximum number of members in the vmgroup, The number of instances in the vm group will be equal to or less than this number.
        /// </summary>
        public int? MaxMembers {
            get { return GetParameterValue<int?>(nameof(MaxMembers).ToLower()); }
            set { SetParameterValue(nameof(MaxMembers).ToLower(), value); }
        }

        /// <summary>
        /// the minimum number of members in the vmgroup, the number of instances in the vm group will be equal to or more than this number.
        /// </summary>
        public int? MinMembers {
            get { return GetParameterValue<int?>(nameof(MinMembers).ToLower()); }
            set { SetParameterValue(nameof(MinMembers).ToLower(), value); }
        }

        /// <summary>
        /// list of scaledown autoscale policies
        /// </summary>
        public IList<Guid> ScaleDownPolicyIds {
            get { return GetList<Guid>(nameof(ScaleDownPolicyIds).ToLower()); }
            set { SetParameterValue(nameof(ScaleDownPolicyIds).ToLower(), value); }
        }

        /// <summary>
        /// list of scaleup autoscale policies
        /// </summary>
        public IList<Guid> ScaleUpPolicyIds {
            get { return GetList<Guid>(nameof(ScaleUpPolicyIds).ToLower()); }
            set { SetParameterValue(nameof(ScaleUpPolicyIds).ToLower(), value); }
        }

        /// <summary>
        /// the autoscale profile that contains information about the vms in the vm group.
        /// </summary>
        public Guid Vmprofileid {
            get { return GetParameterValue<Guid>(nameof(Vmprofileid).ToLower()); }
            set { SetParameterValue(nameof(Vmprofileid).ToLower(), value); }
        }

        /// <summary>
        /// an optional field, whether to the display the group to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

        /// <summary>
        /// the frequency at which the conditions have to be evaluated
        /// </summary>
        public int? Interval {
            get { return GetParameterValue<int?>(nameof(Interval).ToLower()); }
            set { SetParameterValue(nameof(Interval).ToLower(), value); }
        }

    }
    /// <summary>
    /// Creates and automatically starts a virtual machine based on a service offering, disk offering, and template.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CreateAutoScaleVmGroup(CreateAutoScaleVmGroupRequest request);
        Task<AsyncJobResponse> CreateAutoScaleVmGroupAsync(CreateAutoScaleVmGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CreateAutoScaleVmGroup(CreateAutoScaleVmGroupRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CreateAutoScaleVmGroupAsync(CreateAutoScaleVmGroupRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
