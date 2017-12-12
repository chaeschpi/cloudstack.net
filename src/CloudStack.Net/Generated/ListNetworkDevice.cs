using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNetworkDeviceRequest : APIListRequest
    {
        public ListNetworkDeviceRequest() : base("listNetworkDevice") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// parameters for network device
        /// </summary>
        public IList<IDictionary<string, object>> Networkdeviceparameterlist {
            get { return GetList<IDictionary<string, object>>(nameof(Networkdeviceparameterlist).ToLower()); }
            set { SetParameterValue(nameof(Networkdeviceparameterlist).ToLower(), value); }
        }

        /// <summary>
        /// Network device type, now supports ExternalDhcp, PxeServer, NetscalerMPXLoadBalancer, NetscalerVPXLoadBalancer, NetscalerSDXLoadBalancer, F5BigIpLoadBalancer, JuniperSRXFirewall, PaloAltoFirewall
        /// </summary>
        public string Networkdevicetype {
            get { return GetParameterValue<string>(nameof(Networkdevicetype).ToLower()); }
            set { SetParameterValue(nameof(Networkdevicetype).ToLower(), value); }
        }

    }
    /// <summary>
    /// List network devices
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NetworkDeviceResponse> ListNetworkDevice(ListNetworkDeviceRequest request);
        Task<ListResponse<NetworkDeviceResponse>> ListNetworkDeviceAsync(ListNetworkDeviceRequest request);
        ListResponse<NetworkDeviceResponse> ListNetworkDeviceAllPages(ListNetworkDeviceRequest request);
        Task<ListResponse<NetworkDeviceResponse>> ListNetworkDeviceAllPagesAsync(ListNetworkDeviceRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NetworkDeviceResponse> ListNetworkDevice(ListNetworkDeviceRequest request) => Proxy.Request<ListResponse<NetworkDeviceResponse>>(request);
        public Task<ListResponse<NetworkDeviceResponse>> ListNetworkDeviceAsync(ListNetworkDeviceRequest request) => Proxy.RequestAsync<ListResponse<NetworkDeviceResponse>>(request);
        public ListResponse<NetworkDeviceResponse> ListNetworkDeviceAllPages(ListNetworkDeviceRequest request) => Proxy.RequestAllPages<NetworkDeviceResponse>(request);
        public Task<ListResponse<NetworkDeviceResponse>> ListNetworkDeviceAllPagesAsync(ListNetworkDeviceRequest request) => Proxy.RequestAllPagesAsync<NetworkDeviceResponse>(request);
    }
}
