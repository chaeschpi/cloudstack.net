using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class GetSolidFireVolumeSizeRequest : APIRequest
    {
        public GetSolidFireVolumeSizeRequest() : base("getSolidFireVolumeSize") {}

        /// <summary>
        /// Storage Pool UUID
        /// </summary>
        public string Storageid {
            get { return GetParameterValue<string>(nameof(Storageid).ToLower()); }
            set { SetParameterValue(nameof(Storageid).ToLower(), value); }
        }

        /// <summary>
        /// Volume UUID
        /// </summary>
        public string Volumeid {
            get { return GetParameterValue<string>(nameof(Volumeid).ToLower()); }
            set { SetParameterValue(nameof(Volumeid).ToLower(), value); }
        }

    }
    /// <summary>
    /// Get the SF volume size including Hypervisor Snapshot Reserve
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ApiSolidFireVolumeSizeResponse GetSolidFireVolumeSize(GetSolidFireVolumeSizeRequest request);
        Task<ApiSolidFireVolumeSizeResponse> GetSolidFireVolumeSizeAsync(GetSolidFireVolumeSizeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ApiSolidFireVolumeSizeResponse GetSolidFireVolumeSize(GetSolidFireVolumeSizeRequest request) => Proxy.Request<ApiSolidFireVolumeSizeResponse>(request);
        public Task<ApiSolidFireVolumeSizeResponse> GetSolidFireVolumeSizeAsync(GetSolidFireVolumeSizeRequest request) => Proxy.RequestAsync<ApiSolidFireVolumeSizeResponse>(request);
    }
}
