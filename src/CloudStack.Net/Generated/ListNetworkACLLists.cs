using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListNetworkACLListsRequest : APIListRequest
    {
        public ListNetworkACLListsRequest() : base("listNetworkACLLists") {}

        /// <summary>
        /// list resources by account. Must be used with the domainId parameter.
        /// </summary>
        public string Account {
            get { return GetParameterValue<string>(nameof(Account).ToLower()); }
            set { SetParameterValue(nameof(Account).ToLower(), value); }
        }

        /// <summary>
        /// list only resources belonging to the domain specified
        /// </summary>
        public Guid? DomainId {
            get { return GetParameterValue<Guid?>(nameof(DomainId).ToLower()); }
            set { SetParameterValue(nameof(DomainId).ToLower(), value); }
        }

        /// <summary>
        /// list resources by display flag; only ROOT admin is eligible to pass this parameter
        /// </summary>
        public bool? Fordisplay {
            get { return GetParameterValue<bool?>(nameof(Fordisplay).ToLower()); }
            set { SetParameterValue(nameof(Fordisplay).ToLower(), value); }
        }

        /// <summary>
        /// Lists network ACL with the specified ID.
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// defaults to false, but if true, lists all resources from the parent specified by the domainId till leaves.
        /// </summary>
        public bool? Isrecursive {
            get { return GetParameterValue<bool?>(nameof(Isrecursive).ToLower()); }
            set { SetParameterValue(nameof(Isrecursive).ToLower(), value); }
        }

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// If set to false, list only resources belonging to the command's caller; if set to true - list resources that the caller is authorized to see. Default value is false
        /// </summary>
        public bool? ListAll {
            get { return GetParameterValue<bool?>(nameof(ListAll).ToLower()); }
            set { SetParameterValue(nameof(ListAll).ToLower(), value); }
        }

        /// <summary>
        /// list network ACLs by specified name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

        /// <summary>
        /// list network ACLs by network ID
        /// </summary>
        public Guid? NetworkId {
            get { return GetParameterValue<Guid?>(nameof(NetworkId).ToLower()); }
            set { SetParameterValue(nameof(NetworkId).ToLower(), value); }
        }

        /// <summary>
        /// list objects by project
        /// </summary>
        public Guid? ProjectId {
            get { return GetParameterValue<Guid?>(nameof(ProjectId).ToLower()); }
            set { SetParameterValue(nameof(ProjectId).ToLower(), value); }
        }

        /// <summary>
        /// list network ACLs by VPC ID
        /// </summary>
        public Guid? VpcId {
            get { return GetParameterValue<Guid?>(nameof(VpcId).ToLower()); }
            set { SetParameterValue(nameof(VpcId).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all network ACLs
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<NetworkACLResponse> ListNetworkACLLists(ListNetworkACLListsRequest request);
        Task<ListResponse<NetworkACLResponse>> ListNetworkACLListsAsync(ListNetworkACLListsRequest request);
        ListResponse<NetworkACLResponse> ListNetworkACLListsAllPages(ListNetworkACLListsRequest request);
        Task<ListResponse<NetworkACLResponse>> ListNetworkACLListsAllPagesAsync(ListNetworkACLListsRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<NetworkACLResponse> ListNetworkACLLists(ListNetworkACLListsRequest request) => Proxy.Request<ListResponse<NetworkACLResponse>>(request);
        public Task<ListResponse<NetworkACLResponse>> ListNetworkACLListsAsync(ListNetworkACLListsRequest request) => Proxy.RequestAsync<ListResponse<NetworkACLResponse>>(request);
        public ListResponse<NetworkACLResponse> ListNetworkACLListsAllPages(ListNetworkACLListsRequest request) => Proxy.RequestAllPages<NetworkACLResponse>(request);
        public Task<ListResponse<NetworkACLResponse>> ListNetworkACLListsAllPagesAsync(ListNetworkACLListsRequest request) => Proxy.RequestAllPagesAsync<NetworkACLResponse>(request);
    }
}
