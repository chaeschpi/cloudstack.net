using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteOpenDaylightControllerRequest : APIRequest
    {
        public DeleteOpenDaylightControllerRequest() : base("deleteOpenDaylightController") {}

        /// <summary>
        /// OpenDaylight Controller ID
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Removes an OpenDyalight controler
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteOpenDaylightController(DeleteOpenDaylightControllerRequest request);
        Task<AsyncJobResponse> DeleteOpenDaylightControllerAsync(DeleteOpenDaylightControllerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteOpenDaylightController(DeleteOpenDaylightControllerRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteOpenDaylightControllerAsync(DeleteOpenDaylightControllerRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
