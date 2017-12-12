using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class RemoveGuestOsMappingRequest : APIRequest
    {
        public RemoveGuestOsMappingRequest() : base("removeGuestOsMapping") {}

        /// <summary>
        /// ID of the guest OS mapping
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Removes a Guest OS Mapping.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse RemoveGuestOsMapping(RemoveGuestOsMappingRequest request);
        Task<AsyncJobResponse> RemoveGuestOsMappingAsync(RemoveGuestOsMappingRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse RemoveGuestOsMapping(RemoveGuestOsMappingRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> RemoveGuestOsMappingAsync(RemoveGuestOsMappingRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
