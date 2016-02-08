using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class AddNetworkServiceProviderRequest : APIRequest
    {
        public AddNetworkServiceProviderRequest() : base("addNetworkServiceProvider") {}

        /// <summary>
        /// the name for the physical network service provider
        /// </summary>
        public string Name {
            get { return (string) Parameters[nameof(Name).ToLower()]; }
            set { Parameters[nameof(Name).ToLower()] = value; }
        }

        /// <summary>
        /// the Physical Network ID to add the provider to
        /// </summary>
        public Guid PhysicalNetworkId {
            get { return (Guid) Parameters[nameof(PhysicalNetworkId).ToLower()]; }
            set { Parameters[nameof(PhysicalNetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// the destination Physical Network ID to bridge to
        /// </summary>
        public Guid DestinationPhysicalNetworkId {
            get { return (Guid) Parameters[nameof(DestinationPhysicalNetworkId).ToLower()]; }
            set { Parameters[nameof(DestinationPhysicalNetworkId).ToLower()] = value; }
        }

        /// <summary>
        /// the list of services to be enabled for this physical network service provider
        /// </summary>
        public IList<string> Servicelist {
            get { return GetList<string>(nameof(Servicelist).ToLower()); }
            set { Parameters[nameof(Servicelist).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Adds a network serviceProvider to a physical network
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse AddNetworkServiceProvider(AddNetworkServiceProviderRequest request);
        Task<AsyncJobResponse> AddNetworkServiceProviderAsync(AddNetworkServiceProviderRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse AddNetworkServiceProvider(AddNetworkServiceProviderRequest request) => _proxy.Request<AsyncJobResponse>(request);
        public Task<AsyncJobResponse> AddNetworkServiceProviderAsync(AddNetworkServiceProviderRequest request) => _proxy.RequestAsync<AsyncJobResponse>(request);
    }
}
