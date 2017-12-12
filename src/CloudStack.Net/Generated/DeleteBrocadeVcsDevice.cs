using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteBrocadeVcsDeviceRequest : APIRequest
    {
        public DeleteBrocadeVcsDeviceRequest() : base("deleteBrocadeVcsDevice") {}

        /// <summary>
        /// Brocade Switch ID
        /// </summary>
        public Guid Vcsdeviceid {
            get { return GetParameterValue<Guid>(nameof(Vcsdeviceid).ToLower()); }
            set { SetParameterValue(nameof(Vcsdeviceid).ToLower(), value); }
        }

    }
    /// <summary>
    ///  delete a Brocade VCS Switch
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteBrocadeVcsDevice(DeleteBrocadeVcsDeviceRequest request);
        Task<AsyncJobResponse> DeleteBrocadeVcsDeviceAsync(DeleteBrocadeVcsDeviceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteBrocadeVcsDevice(DeleteBrocadeVcsDeviceRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteBrocadeVcsDeviceAsync(DeleteBrocadeVcsDeviceRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
