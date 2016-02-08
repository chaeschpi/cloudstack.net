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
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
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
        public SuccessResponse DeleteInstanceGroup(DeleteInstanceGroupRequest request) => _proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteInstanceGroupAsync(DeleteInstanceGroupRequest request) => _proxy.RequestAsync<SuccessResponse>(request);
    }
}
