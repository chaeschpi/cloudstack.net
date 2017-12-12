using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DedicatePublicIpRangeRequest : APIRequest
    {
        public DedicatePublicIpRangeRequest() : base("dedicatePublicIpRange") {}

        /// <summary>
        /// the id of the VLAN IP range
        /// </summary>
        public Guid Id {
            get { return GetParameterValue<Guid>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// domain ID of the account owning a VLAN
        /// </summary>
        public Guid DomainId {
            get { return GetParameterValue<Guid>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// account who will own the VLAN
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// project who will own the VLAN
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Dedicates a Public IP range to an account
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        VlanIpRangeResponse DedicatePublicIpRange(DedicatePublicIpRangeRequest request);
        Task<VlanIpRangeResponse> DedicatePublicIpRangeAsync(DedicatePublicIpRangeRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public VlanIpRangeResponse DedicatePublicIpRange(DedicatePublicIpRangeRequest request) => Proxy.Request<VlanIpRangeResponse>(request);
        public Task<VlanIpRangeResponse> DedicatePublicIpRangeAsync(DedicatePublicIpRangeRequest request) => Proxy.RequestAsync<VlanIpRangeResponse>(request);
    }
}
