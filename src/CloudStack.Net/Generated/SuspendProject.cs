using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class SuspendProjectRequest : APIRequest
    {
        public SuspendProjectRequest() : base("suspendProject") {}

        /// <summary>
        /// id of the project to be suspended
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Suspends a project
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse SuspendProject(SuspendProjectRequest request);
        Task<AsyncJobResponse> SuspendProjectAsync(SuspendProjectRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse SuspendProject(SuspendProjectRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> SuspendProjectAsync(SuspendProjectRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
