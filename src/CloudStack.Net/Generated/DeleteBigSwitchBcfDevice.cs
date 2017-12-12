using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteBigSwitchBcfDeviceRequest : APIRequest
    {
        public DeleteBigSwitchBcfDeviceRequest() : base("deleteBigSwitchBcfDevice") {}

        /// <summary>
        /// BigSwitch device ID
        /// </summary>
        public Guid Bcfdeviceid {
            get { return GetParameterValue<Guid>(nameof(Bcfdeviceid).ToLower()); }
            set { SetParameterValue(nameof(Bcfdeviceid).ToLower(), value); }
        }

    }
    /// <summary>
    ///  delete a BigSwitch BCF Controller device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteBigSwitchBcfDevice(DeleteBigSwitchBcfDeviceRequest request);
        Task<AsyncJobResponse> DeleteBigSwitchBcfDeviceAsync(DeleteBigSwitchBcfDeviceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteBigSwitchBcfDevice(DeleteBigSwitchBcfDeviceRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> DeleteBigSwitchBcfDeviceAsync(DeleteBigSwitchBcfDeviceRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
