using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DestroyVolumeOnFilerRequest : APIRequest
    {
        public DestroyVolumeOnFilerRequest() : base("destroyVolumeOnFiler") {}

        /// <summary>
        /// aggregate name.
        /// </summary>
        public string Aggregatename {
            get { return (string) Parameters[nameof(Aggregatename).ToLower()]; }
            set { Parameters[nameof(Aggregatename).ToLower()] = value; }
        }

        /// <summary>
        /// ip address.
        /// </summary>
        public string Ipaddress {
            get { return (string) Parameters[nameof(Ipaddress).ToLower()]; }
            set { Parameters[nameof(Ipaddress).ToLower()] = value; }
        }

        /// <summary>
        /// volume name.
        /// </summary>
        public string VolumeName {
            get { return (string) Parameters[nameof(VolumeName).ToLower()]; }
            set { Parameters[nameof(VolumeName).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Destroy a Volume
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        DeleteVolumeOnFilerCmdResponse DestroyVolumeOnFiler(DestroyVolumeOnFilerRequest request);
        Task<DeleteVolumeOnFilerCmdResponse> DestroyVolumeOnFilerAsync(DestroyVolumeOnFilerRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public DeleteVolumeOnFilerCmdResponse DestroyVolumeOnFiler(DestroyVolumeOnFilerRequest request) => _proxy.Request<DeleteVolumeOnFilerCmdResponse>(request);
        public Task<DeleteVolumeOnFilerCmdResponse> DestroyVolumeOnFilerAsync(DestroyVolumeOnFilerRequest request) => _proxy.RequestAsync<DeleteVolumeOnFilerCmdResponse>(request);
    }
}
