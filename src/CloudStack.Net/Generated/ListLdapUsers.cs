using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class ListLdapUsersRequest : APIListRequest
    {
        public ListLdapUsersRequest() : base("listLdapUsers") {}

        /// <summary>
        /// List by keyword
        /// </summary>
        public string Keyword {
            get { return GetParameterValue<string>(nameof(Keyword).ToLower()); }
            set { SetParameterValue(nameof(Keyword).ToLower(), value); }
        }

        /// <summary>
        /// Determines whether all ldap users are returned or just non-cloudstack users
        /// </summary>
        public string ListType {
            get { return GetParameterValue<string>(nameof(ListType).ToLower()); }
            set { SetParameterValue(nameof(ListType).ToLower(), value); }
        }

    }
    /// <summary>
    /// Lists all LDAP Users
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        ListResponse<LdapUserResponse> ListLdapUsers(ListLdapUsersRequest request);
        Task<ListResponse<LdapUserResponse>> ListLdapUsersAsync(ListLdapUsersRequest request);
        ListResponse<LdapUserResponse> ListLdapUsersAllPages(ListLdapUsersRequest request);
        Task<ListResponse<LdapUserResponse>> ListLdapUsersAllPagesAsync(ListLdapUsersRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public ListResponse<LdapUserResponse> ListLdapUsers(ListLdapUsersRequest request) => Proxy.Request<ListResponse<LdapUserResponse>>(request);
        public Task<ListResponse<LdapUserResponse>> ListLdapUsersAsync(ListLdapUsersRequest request) => Proxy.RequestAsync<ListResponse<LdapUserResponse>>(request);
        public ListResponse<LdapUserResponse> ListLdapUsersAllPages(ListLdapUsersRequest request) => Proxy.RequestAllPages<LdapUserResponse>(request);
        public Task<ListResponse<LdapUserResponse>> ListLdapUsersAllPagesAsync(ListLdapUsersRequest request) => Proxy.RequestAllPagesAsync<LdapUserResponse>(request);
    }
}
