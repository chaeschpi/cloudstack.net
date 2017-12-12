using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class CancelHostMaintenanceRequest : APIRequest
    {
        public CancelHostMaintenanceRequest() : base("cancelHostMaintenance") {}

        /// <summary>
        /// the host ID
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

    }
    /// <summary>
    /// Cancels host maintenance.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse CancelHostMaintenance(CancelHostMaintenanceRequest request);
        Task<AsyncJobResponse> CancelHostMaintenanceAsync(CancelHostMaintenanceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse CancelHostMaintenance(CancelHostMaintenanceRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> CancelHostMaintenanceAsync(CancelHostMaintenanceRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
