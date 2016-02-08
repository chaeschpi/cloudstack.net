using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListPaloAltoFirewallsRequest : APIRequest
    {
        public ListPaloAltoFirewallsRequest() : base("listPaloAltoFirewalls") {}

        /// <summary>
        /// Palo Alto firewall device ID
        /// </summary>
        public Guid FwDeviceId {
            get { return (Guid) Parameters[nameof(FwDeviceId).ToLower()]; }
            set { Parameters[nameof(FwDeviceId).ToLower()] = value; }
        }

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

    }
    /// <summary>
    /// lists Palo Alto firewall devices in a physical network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<PaloAltoFirewallResponse> ListPaloAltoFirewalls(ListPaloAltoFirewallsRequest request);
        Task<ListResponse<PaloAltoFirewallResponse>> ListPaloAltoFirewallsAsync(ListPaloAltoFirewallsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<PaloAltoFirewallResponse> ListPaloAltoFirewalls(ListPaloAltoFirewallsRequest request) => _proxy.Request<ListResponse<PaloAltoFirewallResponse>>(request);
        public Task<ListResponse<PaloAltoFirewallResponse>> ListPaloAltoFirewallsAsync(ListPaloAltoFirewallsRequest request) => _proxy.RequestAsync<ListResponse<PaloAltoFirewallResponse>>(request);
    }
}
