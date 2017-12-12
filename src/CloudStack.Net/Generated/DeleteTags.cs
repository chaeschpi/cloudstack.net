using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteTagsRequest : APIRequest
    {
        public DeleteTagsRequest() : base("deleteTags") {}

        /// <summary>
        /// Delete tags for resource id(s)
        /// </summary>
        public IList<string> ResourceIds {
            get { return GetList<string>(nameof(ResourceIds).ToLower()); }
            set { SetParameterValue(nameof(ResourceIds).ToLower(), value); }
        }

        /// <summary>
        /// Delete tag by resource type
        /// </summary>
        public string ResourceType {
            get { return GetParameterValue<string>(nameof(ResourceType).ToLower()); }
            set { SetParameterValue(nameof(ResourceType).ToLower(), value); }
        }

        /// <summary>
        /// Delete tags matching key/value pairs
        /// </summary>
        public IList<IDictionary<string, object>> Tags {
            get { return GetList<IDictionary<string, object>>(nameof(Tags).ToLower()); }
            set { SetParameterValue(nameof(Tags).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deleting resource tag(s)
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteTags(DeleteTagsRequest request);
        Task<AsyncJobResponse> DeleteTagsAsync(DeleteTagsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteTags(DeleteTagsRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteTagsAsync(DeleteTagsRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
