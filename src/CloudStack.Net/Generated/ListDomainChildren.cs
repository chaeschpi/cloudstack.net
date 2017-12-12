using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListDomainChildrenRequest : APIListRequest
    {
        public ListDomainChildrenRequest() : base("listDomainChildren") {}

        /// <summary>
        /// list children domain by parent domain ID.
        /// </summary>
        public Guid? Id {
            get { return GetParameterValue<Guid?>(nameof(Id).ToLower()); }
            set { SetParameterValue(nameof(Id).ToLower(), value); }
        }

        /// <summary>
        /// to return the entire tree, use the value "true". To return the first level children, use the value "false".
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
        /// list children domains by name
        /// </summary>
        public string Name {
            get { return GetParameterValue<string>(nameof(Name).ToLower()); }
            set { SetParameterValue(nameof(Name).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all children domains belonging to a specified domain
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<DomainResponse> ListDomainChildren(ListDomainChildrenRequest request);
        Task<ListResponse<DomainResponse>> ListDomainChildrenAsync(ListDomainChildrenRequest request);
        ListResponse<DomainResponse> ListDomainChildrenAllPages(ListDomainChildrenRequest request);
        Task<ListResponse<DomainResponse>> ListDomainChildrenAllPagesAsync(ListDomainChildrenRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<DomainResponse> ListDomainChildren(ListDomainChildrenRequest request) => Proxy.Request<ListResponse<DomainResponse>>(request);
        public Task<ListResponse<DomainResponse>> ListDomainChildrenAsync(ListDomainChildrenRequest request) => Proxy.RequestAsync<ListResponse<DomainResponse>>(request);
        public ListResponse<DomainResponse> ListDomainChildrenAllPages(ListDomainChildrenRequest request) => Proxy.RequestAllPages<DomainResponse>(request);
        public Task<ListResponse<DomainResponse>> ListDomainChildrenAllPagesAsync(ListDomainChildrenRequest request) => Proxy.RequestAllPagesAsync<DomainResponse>(request);
    }
}
