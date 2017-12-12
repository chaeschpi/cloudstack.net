using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ReplaceNetworkACLListRequest : APIRequest
    {
        public ReplaceNetworkACLListRequest() : base("replaceNetworkACLList") {}

        /// <summary>
        /// the ID of the network ACL
        /// </summary>
        public Guid AclId {
            get { return GetParameterValue<Guid>(nameof(AclId).ToLower()); }
            set { SetParameterValue(nameof(AclId).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the private gateway
        /// </summary>
        public Guid? Gatewayid {
            get { return GetParameterValue<Guid?>(nameof(Gatewayid).ToLower()); }
            set { SetParameterValue(nameof(Gatewayid).ToLower(), value); }
        }

        /// <summary>
        /// the ID of the network
        /// </summary>
        public Guid? NetworkId {
            get { return GetParameterValue<Guid?>(nameof(NetworkId).ToLower()); }
            set { SetParameterValue(nameof(NetworkId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Replaces ACL associated with a network or private gateway
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse ReplaceNetworkACLList(ReplaceNetworkACLListRequest request);
        Task<AsyncJobResponse> ReplaceNetworkACLListAsync(ReplaceNetworkACLListRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse ReplaceNetworkACLList(ReplaceNetworkACLListRequest request) => Proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> ReplaceNetworkACLListAsync(ReplaceNetworkACLListRequest request) => Proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
