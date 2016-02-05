using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            get { return (Guid) Parameters[nameof(Bcfdeviceid).ToLower()]; }
            set { Parameters[nameof(Bcfdeviceid).ToLower()] = value; }
        }

    }
    /// <summary>
    ///  delete a BigSwitch BCF Controller device
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteBigSwitchBcfDevice(DeleteBigSwitchBcfDeviceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteBigSwitchBcfDevice(DeleteBigSwitchBcfDeviceRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
