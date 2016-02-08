using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNuageVspDevicesRequest : APIRequest
    {
        public ListNuageVspDevicesRequest() : base("listNuageVspDevices") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return (string) Parameters[nameof(Keyword).ToLower()]; }
            set { Parameters[nameof(Keyword).ToLower()] = value; }
        }

        public int? Page {
            get { return (int?) Parameters[nameof(Page).ToLower()]; }
            set { Parameters[nameof(Page).ToLower()] = value; }
        }

        public int? PageSize {
            get { return (int?) Parameters[nameof(PageSize).ToLower()]; }
            set { Parameters[nameof(PageSize).ToLower()] = value; }
        }

        /// <summary>
        /// the Physical Network ID
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return (Guid) Parameters[nameof(PhysicalNetworkId).ToLower()]; }
            set { Parameters[nameof(PhysicalNetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// the Nuage VSP device ID
        /// </summary>
        public Guid Vspdeviceid {
            get { return (Guid) Parameters[nameof(Vspdeviceid).ToLower()]; }
            set { Parameters[nameof(Vspdeviceid).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Lists Nuage VSP devices
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NuageVspDeviceResponse> ListNuageVspDevices(ListNuageVspDevicesRequest request);
        Task<ListResponse<NuageVspDeviceResponse>> ListNuageVspDevicesAsync(ListNuageVspDevicesRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NuageVspDeviceResponse> ListNuageVspDevices(ListNuageVspDevicesRequest request) => _proxy.Request<ListResponse<NuageVspDeviceResponse>>(request);
        public Task<ListResponse<NuageVspDeviceResponse>> ListNuageVspDevicesAsync(ListNuageVspDevicesRequest request) => _proxy.RequestAsync<ListResponse<NuageVspDeviceResponse>>(request);
    }
}
