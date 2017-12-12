using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteInstanceGroupRequest : APIRequest
    {
        public DeleteInstanceGroupRequest() : base("deleteInstanceGroup") {}

        /// <summary>
        /// the ID of the instance group
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes a vm group
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteInstanceGroup(DeleteInstanceGroupRequest request);
        Task<SuccessResponse> DeleteInstanceGroupAsync(DeleteInstanceGroupRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteInstanceGroup(DeleteInstanceGroupRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteInstanceGroupAsync(DeleteInstanceGroupRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
