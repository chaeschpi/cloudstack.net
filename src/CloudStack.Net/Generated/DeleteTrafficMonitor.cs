using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteTrafficMonitorRequest : APIRequest
    {
        public DeleteTrafficMonitorRequest() : base("deleteTrafficMonitor") {}

        /// <summary>
        /// Id of the Traffic Monitor Host.
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Deletes an traffic monitor host.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        SuccessResponse DeleteTrafficMonitor(DeleteTrafficMonitorRequest request);
        Task<SuccessResponse> DeleteTrafficMonitorAsync(DeleteTrafficMonitorRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public SuccessResponse DeleteTrafficMonitor(DeleteTrafficMonitorRequest request) => Proxy.Request<SuccessResponse>(request);
        public Task<SuccessResponse> DeleteTrafficMonitorAsync(DeleteTrafficMonitorRequest request) => Proxy.RequestAsync<SuccessResponse>(request);
    }
}
